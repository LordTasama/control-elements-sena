using control_elements_sena.Forms.Create;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_elements_sena.Controllers.Entradas
{
    public class Entradas
    {
        public static string errorMessage = "";
        public static string idRegistro = null;
        public static string idElemento = null;
        public static bool CrearEntrada(string id_propietario, string nombres_propietario, string marca_elemento, string serie_elemento, string observaciones, string formato3)
        {

            using (SqlConnection connection = DatabaseConnect.GetConnection())
            {

                SqlTransaction transaction = null;

                try
                {
                    connection.Open();
                    if (idElemento != null)
                    {
                        using (SqlCommand elementExists = new SqlCommand("ComprobarEntrada", connection))
                        {
                            elementExists.CommandType = CommandType.StoredProcedure;
                            elementExists.Parameters.AddWithValue("@ide", idElemento);
                            using (SqlDataReader reader = elementExists.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    errorMessage = "Ya hay una entrada de este elemento activa";
                                    return false;
                                }

                            }
                        }
                    }

                    // Iniciar la transacción
                    transaction = connection.BeginTransaction();
                    // Crear comandos con la transacción
                    using (SqlCommand command1 = new SqlCommand("CrearRegistro", connection))
                    {
                        command1.Transaction = transaction;
                        command1.CommandType = CommandType.StoredProcedure;
                        command1.Parameters.AddWithValue("@ide", id_propietario);
                        command1.Parameters.AddWithValue("@nom", nombres_propietario);
                        if (idRegistro == null)
                        {
                            idRegistro = command1.ExecuteScalar().ToString();
                        }
                        using (SqlCommand command2 = new SqlCommand("CrearElemento", connection))
                        {
                            command2.Transaction = transaction;
                            command2.CommandType = CommandType.StoredProcedure;
                            command2.Parameters.AddWithValue("@idr", idRegistro);
                            command2.Parameters.AddWithValue("@mar", marca_elemento);
                            command2.Parameters.AddWithValue("@ser", serie_elemento);
                            command2.Parameters.AddWithValue("@fm3", formato3);
                            if (idElemento == null)
                            {
                                idElemento = command2.ExecuteScalar().ToString();
                            }
                            using (SqlCommand denunciaExists = new SqlCommand("BuscarDenuncia", connection))
                            {
                                denunciaExists.Transaction = transaction;
                                denunciaExists.CommandType = CommandType.StoredProcedure;
                                denunciaExists.Parameters.AddWithValue("@ide", idElemento);
                                using (SqlDataReader readerDenuncias = denunciaExists.ExecuteReader())
                                {
                                    if (readerDenuncias.HasRows)
                                    {
                                        readerDenuncias.Close();
                                        transaction.Rollback();
                                        errorMessage = "Este elemento ha sido denunciado, por lo tanto no se puede crear una entrada, revisa en la tabla de Denuncias los detalles.";
                                        return false;
                                    }
                                }
                            }
                            using (SqlCommand command3 = new SqlCommand("CrearEntrada", connection))
                            {
                                command3.Transaction = transaction;
                                command3.CommandType = CommandType.StoredProcedure;
                                command3.Parameters.AddWithValue("@idu", ControlPanel.idSessionUser);
                                command3.Parameters.AddWithValue("@ide", idElemento);
                                command3.Parameters.AddWithValue("@obs", observaciones.ToUpper());
                                command3.Parameters.AddWithValue("@fm3", formato3);
                                if (formato3 == "SI")
                                {
                                    command3.Parameters.AddWithValue("@hoe", DateTime.Now);
                                    command3.Parameters.AddWithValue("@hos", DateTime.Now);
                                    command3.Parameters.AddWithValue("@est", 0);
                                }
                                else
                                {
                                    command3.Parameters.AddWithValue("@hoe", DateTime.Now);
                                    command3.Parameters.AddWithValue("@hos", DBNull.Value);
                                    command3.Parameters.AddWithValue("@est", 1);
                                }

                                command3.ExecuteNonQuery();
                            }

                        }
                    }



                    // Confirmar la transacción si todo sale bien
                    transaction.Commit();
                    return true;
                }
                catch (SqlException ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                    return false;
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    errorMessage = "Error al crear usuario. Detalles: " + ex.Message;
                    return false;
                }
                finally
                {
                    // Cerrar la conexión
                    connection.Close();
                }
            }
        }
        public static (DataTable, bool) SeleccionarEntradas(string all)
        {
            DataTable entrancesTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarEntradas", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@feh", DateTime.Now);
                        command.Parameters.AddWithValue("@all", all);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(entrancesTable);

                        return (entrancesTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (entrancesTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar entradas. Detalles: " + ex.Message;
                return (entrancesTable, false);
            }
        }
        public static (DataTable, bool) SeleccionarEntradasRango(string lim, string estado)
        {
            DataTable entrancesTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarEntradasRango", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@lim", lim);
                        command.Parameters.AddWithValue("@est", estado == "Activas" ? 1 : estado == "Inactivas" ? 0 : 3);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(entrancesTable);

                        return (entrancesTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (entrancesTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar entradas. Detalles: " + ex.Message;
                return (entrancesTable, false);
            }
        }
        public static (DataTable, bool) SeleccionarEntradasParametro(string lim, string estado, string parametro)
        {
            DataTable entrancesTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarEntradasParametro", connection))
                    {
                        int status = estado == "Activas" ? 1 : estado == "Inactivas" ? 0 : 3;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@lim", lim);
                        command.Parameters.AddWithValue("@est", status);
                        command.Parameters.AddWithValue("@inf", parametro);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(entrancesTable);

                        return (entrancesTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (entrancesTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar entradas. Detalles: " + ex.Message;
                return (entrancesTable, false);
            }
        }
        public static (DataTable, bool) SeleccionarEntradasFecha(string lim, string estado, string fecha_inicial, string fecha_final)
        {
            DataTable entrancesTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarEntradasFecha", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@lim", lim);
                        command.Parameters.AddWithValue("@est", estado == "Activas" ? 1 : estado == "Inactivas" ? 0 : 3);
                        command.Parameters.AddWithValue("@fei", fecha_inicial);
                        command.Parameters.AddWithValue("@fef", fecha_final);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(entrancesTable);

                        return (entrancesTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (entrancesTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar entradas. Detalles: " + ex.Message;
                return (entrancesTable, false);
            }
        }
        public static (DataTable, bool) SeleccionarDatosRegistro(string id_registro)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarDatosRegistro", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idr", id_registro);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(data);

                        return (data, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (data, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar datos del registro. Detalles: " + ex.Message;
                return (data, false);
            }
        }
        public static bool RegistrarSalida(string id)
        {

            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SalidaElemento", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ids", id);
                        command.Parameters.AddWithValue("@hos", DateTime.Now);


                        command.ExecuteNonQuery();

                        return true;
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = "Error al registrar la salida. Detalles: " + ex.Message;
                return false;
            }
        }
    }
}

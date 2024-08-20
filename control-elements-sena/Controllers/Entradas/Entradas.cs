using control_elements_sena.Forms.Create;
using System;
using System.Collections.Generic;
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
        public static bool CrearEntrada(string id_propietario, string nombres_propietario, string marca_elemento, string serie_elemento)
        {
           
            using (SqlConnection connection = DatabaseConnect.GetConnection())
            {
                SqlTransaction transaction = null;

                try
                {
                    connection.Open();

                    // Iniciar la transacción
                    transaction = connection.BeginTransaction();
                    // Crear comandos con la transacción
                    using (SqlCommand command1 = new SqlCommand("CrearRegistro",connection))
                    {
                        command1.Transaction = transaction;
                        command1.CommandType = CommandType.StoredProcedure;
                        command1.Parameters.AddWithValue("@ide", id_propietario);
                        command1.Parameters.AddWithValue("@nom", nombres_propietario);
                        string idRegistro = command1.ExecuteScalar().ToString();
 
                        using (SqlCommand command2 = new SqlCommand("CrearElemento", connection))
                        {
                            command2.Transaction = transaction;
                            command2.CommandType = CommandType.StoredProcedure;
                            command2.Parameters.AddWithValue("@idr", idRegistro);
                            command2.Parameters.AddWithValue("@mar", marca_elemento);
                            command2.Parameters.AddWithValue("@ser", serie_elemento);
                            string idElement = command2.ExecuteScalar().ToString();

                            using (SqlCommand command3 = new SqlCommand("CrearEntrada", connection))
                            {
                                command3.Transaction = transaction;
                                command3.CommandType = CommandType.StoredProcedure;
                                command3.Parameters.AddWithValue("@idu", 1);
                                command3.Parameters.AddWithValue("@ide", idElement);
                                command3.Parameters.AddWithValue("@hoe", DateTime.Now);
                                command3.Parameters.AddWithValue("@hos", DBNull.Value);

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
        public static (DataTable, bool) SeleccionarEntradas()
        {
            DataTable entrancesTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarEntradas", connection))
                    {

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
        public static  bool RegistrarSalida()
        {

            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SalidaElemento", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
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

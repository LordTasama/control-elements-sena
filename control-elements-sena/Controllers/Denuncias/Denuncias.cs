using System;

using System.Data.SqlClient;
using System.Data;


namespace control_elements_sena.Controllers.Denuncias
{
    public class Denuncias
    {
        public static string errorMessage;
        public static (DataTable, bool) SeleccionarDenuncias()
        {
            DataTable reportsTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarDenuncias", connection))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(reportsTable);

                        return (reportsTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (reportsTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar denuncias. Detalles: " + ex.Message;
                return (reportsTable, false);
            }
        }

        public static bool CrearDenuncia(string descripcion,string id_elemento,string identificacion)
        {

            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand commandExists = new SqlCommand("SeleccionarRegistroIdentificacion", connection))
                    {
                        connection.Open();
                        commandExists.CommandType = CommandType.StoredProcedure;
                        commandExists.Parameters.AddWithValue("@ide", identificacion);

                        using(SqlDataReader reader = commandExists.ExecuteReader()) {
                            if (!reader.HasRows)
                            {
                                errorMessage = "El propietario no existe en la base de datos";
                                return false;
                            }
                        }
                        using (SqlCommand command = new SqlCommand("CrearDenuncia", connection))
                        {
                            
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@des", descripcion + " - Identificación del usuario encargado: " + ControlPanel.idEmailUser.Split(' ')[0]);
                            command.Parameters.AddWithValue("@ide", id_elemento);
                            command.Parameters.AddWithValue("@fei", DateTime.Now);
                            command.Parameters.AddWithValue("@fef", DBNull.Value);
                            command.Parameters.AddWithValue("@der", "SIN SOLUCIÓN");


                            command.ExecuteNonQuery();

                            return true;
                        }
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
                errorMessage = "Error al registrar la denuncia. Detalles: " + ex.Message;
                return false;
            }
        }

        public static bool SolucionarDenuncia(string id, string detalle_solucion)
        {

            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SolucionarDenuncia", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idd", id);
                        command.Parameters.AddWithValue("@fef", DateTime.Now);
                        command.Parameters.AddWithValue("@der", detalle_solucion+" - Identificación del usuario encargado: " + ControlPanel.idEmailUser.Split(' ')[0]);


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
                errorMessage = "Error al solucionar la denuncia. Detalles: " + ex.Message;
                return false;
            }
        }
    }
}

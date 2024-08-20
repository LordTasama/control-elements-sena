using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_elements_sena.Controllers.Registros
{
    public class Registros
    {
        public static string errorMessage;
        public static (DataTable, bool) SeleccionarRegistros()
        {
            DataTable recordsTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarRegistros", connection))
                    {

                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(recordsTable);

                        return (recordsTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (recordsTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar registros. Detalles: " + ex.Message;
                return (recordsTable, false);
            }
        }
        public static bool EditarRegistro(string id, string identificacion, string nombres)
        {

            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EditarRegistro", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@idr", id);
                        command.Parameters.AddWithValue("@ide", identificacion);
                        command.Parameters.AddWithValue("@nom", nombres);

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
                errorMessage = "Error al editar registro. Detalles: " + ex.Message;
                return false;
            }
        }
    }
}

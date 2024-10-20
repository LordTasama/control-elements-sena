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
   

        public static (DataTable, bool) SeleccionarRegistros(string all, string limit)
        {
            DataTable elementsTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarRegistros", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@all", all);
                        command.Parameters.AddWithValue("@lim", limit);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(elementsTable);

                        return (elementsTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (elementsTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar registros. Detalles: " + ex.Message;
                return (elementsTable, false);
            }
        }

        public static (DataTable, bool) SeleccionarRegistro(string parametro, string limit)
        {
            DataTable elementsTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarRegistro", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@inf", parametro);
                        command.Parameters.AddWithValue("@lim", limit);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        connection.Open();
                        adapter.Fill(elementsTable);

                        return (elementsTable, true);
                    }
                }
            }
            catch (SqlException ex)
            {
                errorMessage = "Error con la base de datos. Código de error: " + ex.Number + "\n\nDetalles:\n" + ex.Message;
                return (elementsTable, false);
            }
            catch (Exception ex)
            {
                errorMessage = "Error al seleccionar registro. Detalles: " + ex.Message;
                return (elementsTable, false);
            }
        }
        public static bool EditarRegistro(string id, string identificacion, string nis, string nombres,string tipo_usuario)
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
                        command.Parameters.AddWithValue("@nis", nis);
                        command.Parameters.AddWithValue("@nom", nombres);
                        command.Parameters.AddWithValue("@tiu", tipo_usuario);
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_elements_sena.Controllers.Elementos
{
    public class Elementos
    {
        public static string errorMessage;
        public static (DataTable, bool) SeleccionarElementos(string all, string limit)
        {
            DataTable elementsTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarElementos", connection))
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
                errorMessage = "Error al seleccionar elementos. Detalles: " + ex.Message;
                return (elementsTable, false);
            }
        }

        public static (DataTable, bool) SeleccionarElemento(string parametro, string limit)
        {
            DataTable elementsTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("SeleccionarElemento", connection))
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
                errorMessage = "Error al seleccionar elementos. Detalles: " + ex.Message;
                return (elementsTable, false);
            }
        }
        public static bool EditarElemento(string id, string marca,string serie,string formato3)
        {

            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("EditarElemento", connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ide", id);
                        command.Parameters.AddWithValue("@mar", marca);
                        command.Parameters.AddWithValue("@ser", serie);
                        command.Parameters.AddWithValue("@fm3", formato3);

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
                errorMessage = "Error al editar elemento. Detalles: " + ex.Message;
                return false;
            }
        }
    }
}

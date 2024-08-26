using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_elements_sena.Controllers.Reportes
{
     public class Reportes
    {
        public static string errorMessage;
        public static (DataTable, bool) ElementosEntrantesMes()
        {
            DataTable elementsTable = new DataTable();
            try
            {
                using (SqlConnection connection = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("ElementosEntrantesMes", connection))
                    {
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
                errorMessage = "Error al seleccionar los datos de la gráfica. Detalles: " + ex.Message;
                return (elementsTable, false);
            }
        }
    }
}

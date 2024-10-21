using System.Data.SqlClient;
using System.IO;

namespace control_elements_sena.Controllers
{
    public class DatabaseConnect
    {
        public static SqlConnection GetConnection()
        {
        // DESKTOP-89DA07F\SQLEXPRESS
        // DESKTOP-4QK0D9A\\SQLEXPRESS

                 // Ruta del archivo con los datos de conexión
            string rutaArchivo = @"C:\Users\TASAMA\Documents\controlelements-conexion.txt";

            // Leer el contenido del archivo
            string connectionString = File.ReadAllText(rutaArchivo);
            return new SqlConnection(connectionString);
        }
    }
}

using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace control_elements_sena.Controllers
{
    public class DatabaseConnect
    {
        public static SqlConnection GetConnection()
        {
        // DESKTOP-89DA07F\SQLEXPRESS
        // DESKTOP-4QK0D9A\\SQLEXPRESS


            // Ruta a la carpeta de documentos del usuario
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Asegurarse de que la carpeta existe
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string rutaArchivo = Path.Combine(directoryPath, "controlelements-conexion.txt");
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El documento para conectar a la base de datos no existe, por favor lea el manual de instalación y siga los pasos correctamente", "Conexión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                // Leer el contenido del archivo
                string connectionString = File.ReadAllText(rutaArchivo);
            return new SqlConnection(connectionString);
        }
    }
}

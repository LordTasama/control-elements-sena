using System.Data.SqlClient;

namespace control_elements_sena.Controllers
{
    public class DatabaseConnect
    {
        public static SqlConnection GetConnection()
        {
            // DESKTOP-89DA07F\SQLEXPRESS
            // DESKTOP-4QK0D9A\\SQLEXPRESS
            return new SqlConnection("Server=DESKTOP-89DA07F\\SQLEXPRESS;Database=controlelementos;User Id=Adso2671333;Password=12345;");
        }
    }
}

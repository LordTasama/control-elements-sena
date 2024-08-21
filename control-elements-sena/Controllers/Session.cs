using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_elements_sena.Controllers
{
    public class Session
    {
        public static string errorMessage;
        public static bool SessionStart(string parametro, string password)
        {
            try
            {
                using(SqlConnection conn = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("ValidarLogin",conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@inf",parametro);
                        conn.Open();
                        using (SqlDataReader infoUser = cmd.ExecuteReader())
                        {
                            if(infoUser.HasRows)
                            {
                                string passwordDatabase = "";
                                byte estado = 0;
                                while (infoUser.Read()) {
                                    passwordDatabase = infoUser.GetString(0);
                                    estado = infoUser.GetByte(1);
                                }
                               if(estado == 0)
                                {
                                    errorMessage = "Su estado actual es inactivo, contacta con un administrador para activar tu cuenta";
                                    return false;
                                }
                               if(BCrypt.Net.BCrypt.Verify(password, passwordDatabase))
                                {
                                    return true;
                                }
                                else
                                {
                                    errorMessage = "Contraseña incorrecta";
                                    return false;
                                }
                                
                            }
                            else
                            {
                                errorMessage = "Identificación o correo no existe";
                                return false;
                            }
                       
                        }
                        
                        
                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                errorMessage = $"Algo ocurrió con la base de datos. Código de error: {e.Number} \n\nDetalles:\n{e.Message}";
                return false;
            }
            catch (Exception e) {
                errorMessage = $"Algo ocurrió al tratar de iniciar sesión. \n\nDetalles:\n{e.Message}";
                return false;
            }
        }
    }
}

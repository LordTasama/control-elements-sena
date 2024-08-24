using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;

namespace control_elements_sena.Controllers
{
    public class Session
    {
        private static string secretKey = "Adso2671333#CTA-20240821/Tasama.954310";
        private static readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        public static long idUserGlobal { get; set; }
        public string errorMessage;
        public bool validToken = false;
        public async Task<bool> SessionStart(string parametro, string password)
        {
            string passwordDatabase = "";
            byte estado = 0;
            long userId = 0;
            string nombres = "";
            byte rol = 2;
            string correo = "";
            long identificacion = 0;
            string token = "";
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
                                while (infoUser.Read()) {
                                    passwordDatabase = infoUser.GetString(0);
                                    estado = infoUser.GetByte(1);
                                    userId = infoUser.GetInt64(2);
                                    nombres = infoUser.GetString(3);
                                    rol = infoUser.GetByte(4);
                                    correo = infoUser.GetString(5);
                                    identificacion = infoUser.GetInt64(6);
                                }
                               if(estado == 0)
                                {
                                    errorMessage = "Su estado actual es inactivo, contacta con un administrador para activar tu cuenta";
                                    return false;
                                }

                             
                                
                            }
                            else
                            {
                                errorMessage = "Identificación o correo no existe";
                                return false;
                            }
                       
                        }
                        if (BCrypt.Net.BCrypt.Verify(password, passwordDatabase))
                        {
                            idUserGlobal = userId;
                            await DescifrarTokenAsync();
                            if (validToken) {
                                return true;
                            }
                            token = GenerarToken(userId.ToString(),identificacion.ToString(), rol.ToString(), nombres, correo);
                            using (SqlCommand command1 = new SqlCommand("RegistrarSession", conn))
                            {
                                command1.CommandType = System.Data.CommandType.StoredProcedure;
                                command1.Parameters.AddWithValue("@idr", userId);
                                command1.Parameters.AddWithValue("@hos", DateTime.Now);
                                command1.Parameters.AddWithValue("@tok", token);
                                command1.ExecuteNonQuery();
                            }
                            
                            return true;
                        }
                        else
                        {
                            errorMessage = "Contraseña incorrecta";
                            return false;
                        }
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
        private string GenerarToken(string userid,string identificacion,string rol, string nombres, string correo)
        {
            var claims = new[]
        {
            new Claim("UserId", userid),
            new Claim("UserIdentificacion",identificacion),
            new Claim(ClaimTypes.Name,nombres),
            new Claim(ClaimTypes.Role,rol ),
            new Claim(ClaimTypes.Email,correo),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddHours(6),
            SigningCredentials = new SigningCredentials(_signingKey, SecurityAlgorithms.HmacSha256Signature),
            Issuer = "CTA-TASAMA",
            Audience = "CTA"
        };

        var tokenHandler = new JsonWebTokenHandler();
        string token = tokenHandler.CreateToken(tokenDescriptor);
            idUserGlobal = Convert.ToInt64(userid);
            return token;
        }

        public async Task<string[]> DescifrarTokenAsync()
        {
            var tokenHandler = new JsonWebTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "CTA-TASAMA",
                ValidAudience = "CTA",
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };

            try
            {
                // Validar el token
                string token = await TraerToken();
                var principal = await tokenHandler.ValidateTokenAsync(token, validationParameters);

                if(!principal.IsValid)
                {
                    validToken = false;
                    return new string[] { "", "", "", "","" };
                }
                // Obtener los reclamos
                var claims = principal.ClaimsIdentity.Claims;


                string userId = claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
                string name = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
                string role = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
                string email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
                string identificacion = claims.FirstOrDefault(c => c.Type == "UserIdentificacion")?.Value;
                // Devolver los datos como un arreglo
                validToken = true;
                return new string[] { userId,identificacion,name,role,email };
            }
            catch (Exception ex)
            {
                validToken = false;
                return  new string[] { "", "", "", "",""}; // Valores por defecto en caso de error
            }
        }


        async private Task<string> TraerToken()
        {
            string token = "";
       
            try
            {
                using (SqlConnection conn = DatabaseConnect.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("TraerToken",conn))
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idr",idUserGlobal);
                        using (SqlDataReader dr = await cmd.ExecuteReaderAsync()) {

                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    token = dr.GetString(0);
                                }
                                return token;
                            }
                            else
                            {
                                return "";
                            }
                        }
                      
                    }
                }
            }
            catch (SqlException e)
            {
                errorMessage = $"Algo ocurrió con la base de datos. Código de error: {e.Number} \n\nDetalles:\n{e.Message}";
                return "";
            }
            catch (Exception e)
            {
                errorMessage = $"Algo ocurrió al tratar de traer el token. \n\nDetalles:\n{e.Message}";
                return "";
            }
        }
    }
}

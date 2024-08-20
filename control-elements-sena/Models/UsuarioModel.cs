namespace control_elements_sena
{
    public class UsuarioModel
    {
        public string id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
        public bool PasswordRequired { get; set; }
    }

}

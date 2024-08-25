using control_elements_sena.Controllers.Usuarios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena.Forms.Create
{
    public partial class CrearUsuario : Form
    {
        private Point lastLocation;
        private bool mouseDown;
        public CrearUsuario()
        {
            InitializeComponent();
        }

        // Controles de la ventana
        private void pControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Mueve el formulario a la nueva posición del ratón
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update(); // Actualiza la posición del formulario
            }
        }

        private void pControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                btnShowPassword.Visible = false;
            }
            else
            {
                btnShowPassword.Visible = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Validar datos
            var user = new UsuarioModel
            {
                Identificacion = txtIdentificacion.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Correo = txtCorreo.Text,
                Password = txtPassword.Text,
                PasswordRequired = true
            };

            var validator = new ValidacionesUsuario();
            var result = validator.Validate(user);

            if (!result.IsValid)
            {
                string errores = "";
                bool emptyFields = false;
                foreach (var error in result.Errors)
                {
                    errores += error.ErrorMessage + "\n";
                    if (!emptyFields)
                    {
                        emptyFields = error.ErrorCode == "empty" ? true : false;
                    }

                }
                if (emptyFields)
                {
                    MessageBox.Show("Verifica si hay campos vacíos", "Error de verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(errores, "Error de verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            // Enviar datos
            else
            {
                bool response = Usuarios.CrearUsuario(txtNombres.Text, txtApellidos.Text, txtIdentificacion.Text, txtCorreo.Text, txtPassword.Text);

                if (response)
                {
                    MessageBox.Show("Usuario creado exitosamente", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Usuarios.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}

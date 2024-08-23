using control_elements_sena.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena
{
    public partial class Login : Form
    {
        private bool MouseDown;
        private Point lastLocation;
        public Login()
        {
            InitializeComponent();
        }

        private void pControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            lastLocation = e.Location;
        }

        private void pControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                // Mueve el formulario a la nueva posición del ratón
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update(); // Actualiza la posición del formulario
            }
        }

        private void pControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        private void btnMinimizeWindow_Click(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseWindow_Click(object sender, MouseEventArgs e)
        {
            this.Close();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mensaje = "No deberías estar viendo este mensaje, creo que algo no muy bueno pasó... si lo ves contáctame :D +57 3234407488";
            MessageBoxIcon icono = MessageBoxIcon.Question;
            Session session = new Session();
            if (txtUser.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                var data = session.SessionStart(txtUser.Text, txtPassword.Text);
                if (data.Item1)
                {
                    mensaje = "Autenticación completada";
                    icono = MessageBoxIcon.Information;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    mensaje = session.errorMessage;
                    icono = MessageBoxIcon.Error;
                }
                

            }
            else
            {
                mensaje = "Verifica si hay campos vacíos";
                icono = MessageBoxIcon.Error;
            }
            MessageBox.Show(mensaje,"Inicio de sesión",MessageBoxButtons.OK,icono);

        }


    }
}

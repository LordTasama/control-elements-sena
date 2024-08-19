using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
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
            else {
                txtPassword.PasswordChar = '*';
            }
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

       
    }
}

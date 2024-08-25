using control_elements_sena.Controllers.Usuarios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena.Forms.Create
{
    public partial class EstadoUsuario : Form
    {
        private Point lastLocation;
        private bool mouseDown;
        private string [] _data = new string[7];
        public EstadoUsuario(string [] data)
        {
            InitializeComponent();
            _data = data;
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

        private void btnSend_Click(object sender, EventArgs e)
        {
          
            // Enviar datos

                bool response = Usuarios.CambiarEstadoUsuario(Convert.ToInt64(_data[0]), _data[6] == "Activo" ? 0 : 1);

                if (response)
                {
                    MessageBox.Show("El estado del usuario ha sido cambiado exitosamente", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
                }
                else
                {
                    MessageBox.Show(Usuarios.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            


        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            txtNameUser.Text = _data[2] + " " + _data[3];
        }

        
    }
}

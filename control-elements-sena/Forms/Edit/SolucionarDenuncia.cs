using control_elements_sena.Controllers.Usuarios;
using control_elements_sena.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena.Forms.Create
{
    public partial class SolucionarDenuncia : Form
    {
        private Point lastLocation;
        private bool mouseDown;
        private string _idDenuncia;
        public SolucionarDenuncia(string idDenuncia)
        {
            InitializeComponent();
            _idDenuncia = idDenuncia;
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
            if (txtSolve.Text == "") {
                MessageBox.Show("Verifica si hay campos vacíos", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Enviar datos
            else
            {
                bool response = Controllers.Denuncias.Denuncias.SolucionarDenuncia(_idDenuncia,txtSolve.Text);

                if (response)
                {
                    MessageBox.Show("Denuncia solucionada exitosamente", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Controllers.Denuncias.Denuncias.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
   
    }
}

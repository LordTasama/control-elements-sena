using control_elements_sena.Controllers.Usuarios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena.Forms.Create
{
    public partial class CrearEntrada : Form
    {
        private Point lastLocation;
        private bool mouseDown;
        public CrearEntrada()
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Validar datos
            var entrada = new EntradasModel
            {
                Id_Propietario = txtIdPropietario.Text,
                Nombres_Propietario = txtNombres.Text,
                Marca = cmbMarca.Text,
                Serie = txtSerie.Text,
                registroValidate = true,
                elementValidate = true,
            };

            var validator = new ValidacionesEntrada();
            var result = validator.Validate(entrada);

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
                bool response = Controllers.Entradas.Entradas.CrearEntrada(txtIdPropietario.Text,txtNombres.Text,cmbMarca.Text,txtSerie.Text);

                if (response)
                {
                    MessageBox.Show("Entrada registrada exitosamente", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Controllers.Entradas.Entradas.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

    }
}

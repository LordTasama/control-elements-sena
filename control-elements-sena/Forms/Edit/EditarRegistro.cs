using control_elements_sena.Controllers.Usuarios;
using FluentValidation;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena.Forms.Create
{
    public partial class EditarRegistro : Form
    {
        private Point lastLocation;
        private bool mouseDown;
        private string [] _data = new string[7];
        public EditarRegistro(string [] data)
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
            // Validar datos
           
            var record = new EntradasModel
            {
                Id_Propietario = txtIdentificacion.Text,
                Nombres_Propietario = txtNombres.Text,
                registroValidate = true,
                elementValidate = false
            };

            var validator = new ValidacionesEntrada();
            var result = validator.Validate(record);

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
                bool response = Controllers.Registros.Registros.EditarRegistro(_data[0], txtIdentificacion.Text, txtNombres.Text);

                if (response)
                {
                    MessageBox.Show("Registro editado exitosamente", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show(Controllers.Registros.Registros.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            txtIdentificacion.Text = _data[2];
            txtNombres.Text = _data[1];
        }
    }
}

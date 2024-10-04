using control_elements_sena.Controllers.Usuarios;
using FluentValidation;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena.Forms.Create
{
    public partial class EditarElemento : Form
    {
        private Point lastLocation;
        private bool mouseDown;
        private string [] _data = new string[7];
        public EditarElemento(string [] data)
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
           
            var element = new EntradasModel
            {
                Marca = txtMarca.Text,
                Serie = txtSerie.Text,
                registroValidate = false,
                elementValidate = true
            };

            var validator = new ValidacionesEntrada();
            var result = validator.Validate(element);

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
                bool response = Controllers.Elementos.Elementos.EditarElemento(_data[0], txtMarca.Text, txtSerie.Text,chxFormato3.Checked ? "SI" : "NO");

                if (response)
                {
                    MessageBox.Show("Elemento editado exitosamente", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show(Controllers.Elementos.Elementos.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

     

        private void EditarElemento_Load(object sender, EventArgs e)
        {
            txtMarca.Text = _data[4];
            txtSerie.Text = _data[5];
            chxFormato3.Checked = _data[6] == "SI";
        }
    }
}

using control_elements_sena.Controllers.Usuarios;
using control_elements_sena.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
            this.DialogResult = DialogResult.Cancel;
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

                string checkedFM3 = chxFormato3.Checked ? "SI" : "NO";
                string nombres = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNombres.Text.ToLower());
                string marca = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cmbMarca.Text.ToLower());
                bool response = Controllers.Entradas.Entradas.CrearEntrada(txtIdPropietario.Text,nombres,marca,txtSerie.Text,txtObservaciones.Text,checkedFM3);

                if (response)
                {
                    MessageBox.Show("Entrada registrada exitosamente", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show(Controllers.Entradas.Entradas.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }



        private void txtIdPropietario_TextChanged(object sender, EventArgs e)
        {
            // Guarda la posición actual del cursor
            int cursorPosition = txtIdPropietario.SelectionStart;

            // Verifica que el texto no esté vacío y que el cursor no esté en la primera posición
            if (!string.IsNullOrEmpty(txtIdPropietario.Text) && cursorPosition > 0)
            {
                // Verifica si el carácter en la posición anterior no es un dígito
                if (!char.IsDigit(txtIdPropietario.Text[cursorPosition - 1]))
                {
                    // Elimina el carácter no válido en la posición anterior del cursor
                    txtIdPropietario.Text = txtIdPropietario.Text.Remove(cursorPosition - 1, 1);

                    // Restablece la posición del cursor
                    txtIdPropietario.SelectionStart = cursorPosition - 1;

                    // Muestra un mensaje si lo deseas (opcional)
         
                }
                else
                {
                    CargarDatosRegistro();
                }
            }
        }


        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedItem is Elemento elemento) {
                txtSerie.Text = elemento.Serie;
                Controllers.Entradas.Entradas.idRegistro = elemento.Id_Registro;
                Controllers.Entradas.Entradas.idElemento = elemento.Id_Elemento;
            }
        }

        private void CrearEntrada_Load(object sender, EventArgs e)
        {
            Controllers.Entradas.Entradas.idRegistro = null;
            Controllers.Entradas.Entradas.idElemento = null;
            SetPlaceholder(txtObservaciones, "SIN OBSERVACIONES");
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {

            bool condition = false;
            string idElement = null;
            foreach (var item in cmbMarca.Items)
            {
                 if (item is Elemento elemento)
                {
                    if (elemento.Serie == txtSerie.Text)
                    {
                        condition = true;
                        idElement = elemento.Id_Elemento;
                    }
                }
            }
            if (!condition)
            {
                Controllers.Entradas.Entradas.idElemento = null;
            }
            else
            {
                Controllers.Entradas.Entradas.idElemento = idElement;
            }
        }

        private void cmbMarca_TextChanged(object sender, EventArgs e)
        {
            
            bool condition = false;
            string idElement = null;
            foreach(var item in cmbMarca.Items)
            {
                if (item is Elemento elemento)
                {
                    if (elemento.Marca == cmbMarca.Text)
                    {
                        condition = true;
                        idElement = elemento.Id_Elemento;
                    }
                }
            }
            if (!condition)
            {
                Controllers.Entradas.Entradas.idElemento = null;
            }
            else
            {
                Controllers.Entradas.Entradas.idElemento = idElement;
            }
            
        }


        // Funciones personalizadas
        private void CargarDatosRegistro()
        {
            var data = Controllers.Entradas.Entradas.SeleccionarDatosRegistro(txtIdPropietario.Text);

            string nombres = null;
            string firstSerie = null;
            bool formato3 = false;
            List<Elemento> datosElementos = new List<Elemento>();
            if (data.Item2)
            {
                foreach (DataRow row in data.Item1.Rows)
                {
                    nombres = nombres ?? row["nombres"].ToString();
                    firstSerie = firstSerie ?? row["serie"].ToString();
                    datosElementos.Add(new Elemento { Id_Registro = row["id_registro"].ToString(), Id_Elemento = row["id_elemento"].ToString(), Marca = row["marca"].ToString(), Serie = row["serie"].ToString() });
                    formato3 = row["formato3"].ToString() == "SI";
                }
                cmbMarca.Text = "";
                cmbMarca.DataSource = datosElementos;
                cmbMarca.DisplayMember = "Marca";
                cmbMarca.ValueMember = "Serie";
                txtNombres.Text = nombres;
                txtSerie.Text = firstSerie;
                chxFormato3.Checked = formato3;

            }
            else
            {
                MessageBox.Show("Error al traer los datos", "Datos registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (data.Item1.Rows.Count == 0)
            {
                Controllers.Entradas.Entradas.idRegistro = null;
                Controllers.Entradas.Entradas.idElemento = null;
            }
            else
            {
                Controllers.Entradas.Entradas.idRegistro = data.Item1.Rows[0]["id_registro"].ToString();
                Controllers.Entradas.Entradas.idElemento = data.Item1.Rows[0]["id_elemento"].ToString();
            }
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            // Si el TextBox está vacío, muestra el placeholder en color gris
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }

            // Evento Enter para eliminar el placeholder cuando el usuario hace clic
            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            // Evento Leave para volver a mostrar el placeholder si el usuario no escribe nada
            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }


    }
}

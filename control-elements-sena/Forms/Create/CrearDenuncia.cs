using control_elements_sena.Controllers.Usuarios;
using control_elements_sena.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena.Forms.Create
{
    public partial class CrearDenuncia : Form
    {
        private Point lastLocation;
        private bool mouseDown;
        public CrearDenuncia()
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
                registroValidate = true,
                elementValidate = false,
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
                bool response = Controllers.Denuncias.Denuncias.CrearDenuncia(txtDescription.Text, Controllers.Entradas.Entradas.idElemento,txtIdPropietario.Text);

                if (response)
                {
                    MessageBox.Show("Denuncia registrada exitosamente", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Controllers.Denuncias.Denuncias.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void txtIdPropietario_TextChanged(object sender, EventArgs e)
        {
            
            var data = Controllers.Entradas.Entradas.SeleccionarDatosRegistro(txtIdPropietario.Text);
        
            string nombres = null;
            string firstSerie = null;
            List<Elemento> datosElementos = new List<Elemento>();
            if (data.Item2)
            {
                foreach (DataRow row in data.Item1.Rows)
                {
                    nombres = nombres ?? row["nombres"].ToString();
                    firstSerie = firstSerie ?? row["serie"].ToString();
                    datosElementos.Add(new Elemento { Id_Elemento = row["id_elemento"].ToString() , Marca =row["marca"].ToString()});

                }
                cmbMarca.Text = "";
                cmbMarca.DataSource = datosElementos;
                cmbMarca.DisplayMember = "Marca";
                cmbMarca.ValueMember = "Serie";
                txtNombres.Text = nombres;

            } 
            else
            {
                MessageBox.Show("Error al traer los datos", "Datos denuncia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           if(data.Item1.Rows.Count == 0)
            {
                Controllers.Entradas.Entradas.idElemento = null;
            }
            else
            {
                Controllers.Entradas.Entradas.idElemento = data.Item1.Rows[0]["id_elemento"].ToString();
            }

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedItem is Elemento elemento) {
                Controllers.Entradas.Entradas.idElemento = elemento.Id_Elemento;
            }
        }

        private void cmbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Controllers.Entradas.Entradas.idElemento = null;
        }
    }
}

﻿using control_elements_sena.Controllers.Usuarios;
using control_elements_sena.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
                bool response = Controllers.Entradas.Entradas.CrearEntrada(txtIdPropietario.Text,txtNombres.Text,cmbMarca.Text,txtSerie.Text);

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
            CargarDatosRegistro();
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
            List<Elemento> datosElementos = new List<Elemento>();
            if (data.Item2)
            {
                foreach (DataRow row in data.Item1.Rows)
                {
                    nombres = nombres ?? row["nombres"].ToString();
                    firstSerie = firstSerie ?? row["serie"].ToString();
                    datosElementos.Add(new Elemento { Id_Registro = row["id_registro"].ToString(), Id_Elemento = row["id_elemento"].ToString(), Marca = row["marca"].ToString(), Serie = row["serie"].ToString() });

                }
                cmbMarca.Text = "";
                cmbMarca.DataSource = datosElementos;
                cmbMarca.DisplayMember = "Marca";
                cmbMarca.ValueMember = "Serie";
                txtNombres.Text = nombres;
                txtSerie.Text = firstSerie;

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
    }
}

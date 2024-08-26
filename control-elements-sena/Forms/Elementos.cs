using control_elements_sena.Forms.Create;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena
{
    public partial class Elementos : Form
    {
        private bool selectedCellRow;
        public Elementos()
        {
            InitializeComponent();
        }

        private void Elementos_Load(object sender, EventArgs e)
        {
            CargarData("0","10");
            SetPlaceholder(txtSearch,"Buscar por Identificación, Marca o Serie");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedCellRow)
            {
                int currentRow = dgvDatos.CurrentCell.RowIndex;
                string[] data = new string[6];
                foreach (DataGridViewCell cell in dgvDatos.Rows[currentRow].Cells)
                {
                    data[cell.ColumnIndex] = cell.Value.ToString();
                }
                if (new EditarElemento(data).ShowDialog() == DialogResult.OK)
                {
                    CargarData("0",cmbValue.Text != "" ? cmbValue.Text :"5");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un elemento", "Elementos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void btnOptions_Click(object sender, EventArgs e)
        {
            if (pButtonsContainer.Visible)
            {
                pButtonsContainer.Visible = false;
            }
            else
            {
                pButtonsContainer.Visible = true;
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.Rows[0].Cells["Marca"].Value.ToString() == "SIN DATOS PARA MOSTRAR")
            {
                dgvDatos.ClearSelection();
                selectedCellRow = false;
            }
            else
            {
                selectedCellRow = true;
            }
        }
        private void cmbValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control (como Backspace), cancelar el evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                CargarData("0", cmbValue.Text);
            }
        }
        
        private void btnListAll_Click(object sender, EventArgs e)
        {
            CargarData("1","0");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarParametro();
        
        }

        private void cmbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarData("0", cmbValue.Text);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscarParametro();
            }
        }

        // Funciones personalizadas
        private void CargarData(string all, string limit)
        {
            pButtonsContainer.Visible = false;
            var response = Controllers.Elementos.Elementos.SeleccionarElementos(all, limit);
            DataTable elementData = response.Item1;
            dgvDatos.Rows.Clear();
            if (!response.Item2)
            {
                MessageBox.Show("Error al traer los datos de los elementos", "Tabla elementos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow data in elementData.Rows)
            {

                dgvDatos.Rows.Add(new object[] { data[0], data[1], data[2], data[3], data[4], data[5] });


            }
            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "", "", "", "", "SIN DATOS PARA MOSTRAR", "" });


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

       private void BuscarParametro()
        {
            if (txtSearch.Text.Length == 0 || txtSearch.Text == "Buscar por Identificación, Marca o Serie")
            {
                MessageBox.Show("Digita por lo menos un parámetro de búsqueda", "Buscar elemento", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                pButtonsContainer.Visible = false;
                var response = Controllers.Elementos.Elementos.SeleccionarElemento(txtSearch.Text, cmbValue.Text != "" ? cmbValue.Text : "5");
                DataTable elementData = response.Item1;
                dgvDatos.Rows.Clear();
                if (!response.Item2)
                {
                    MessageBox.Show("Error al traer los datos de busqueda", "Tabla elementos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (DataRow data in elementData.Rows)
                {

                    dgvDatos.Rows.Add(new object[] { data[0], data[1], data[2], data[3], data[4], data[5] });


                }
                if (dgvDatos.Rows.Count == 0)
                {
                    dgvDatos.Rows.Add(new object[] { "", "", "", "", "NO SE ENCONTRÓ NINGÚN DATO", "" });


                }
            }
        }
    }
}

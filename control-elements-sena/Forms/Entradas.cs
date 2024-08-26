using control_elements_sena.Controllers.Usuarios;
using control_elements_sena.Forms.Create;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena
{
    public partial class Entradas : Form
    {
        public Entradas()
        {
            InitializeComponent();
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

        private void Entradas_Load(object sender, EventArgs e)
        {
            CargarData("0");
            SetPlaceholder(txtSearch, "Buscar por Identificación, Nombres, Serie o Marca");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool shouldContinue = true;

            while (shouldContinue)
            {
                // Mostrar el diálogo
                using (CrearEntrada crearEntradaForm = new CrearEntrada())
                {
                    DialogResult result = crearEntradaForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        CargarData("0");
                    }
                    else
                    {
                        shouldContinue = false;
                    }
                }
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow data = dgvDatos.Rows[dgvDatos.CurrentCell.RowIndex];
            if (data.Cells["hora_salida"].Value.ToString() != "PENDIENTE")
            {
                MessageBox.Show("Seleccione una entrada con hora de salida 'PENDIENTE'", "Registrar salida",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Selecciona 'OK' o 'Aceptar' para confirmar la hora de salida de este elemento.\n\nInformación del elemento:\n- Propietario: {data.Cells["nombres_propietario"].Value}\n- Marca: {data.Cells["marca"].Value}\n- Serie: {data.Cells["serie"].Value}", "Registrar salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    if (Controllers.Entradas.Entradas.RegistrarSalida(data.Cells["id"].Value.ToString()))
                    {
                        MessageBox.Show("Operación exitosa", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarData("0");
                    }
                    else {
                        MessageBox.Show(Controllers.Entradas.Entradas.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarParametro();
        }
        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            pButtonsContainer.Visible = false;
            var response = Controllers.Entradas.Entradas.SeleccionarEntradasFecha(cmbValue.Text == "" ? "5" : cmbValue.Text, cmbType.Text, dtpInitialDate.Value.AddDays(1).ToString("yyyy/MM/dd"),dtpEndDate.Value.AddDays(1).ToString("yyyy/MM/dd"));
            DataTable entranceData = response.Item1;
            // Limpiar datos
            dgvDatos.Rows.Clear();
            if (!response.Item2)
            {
                MessageBox.Show("Error al traer los datos de las entradas", "Tabla entradas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow data in entranceData.Rows)
            {
                var horaSalida = data[9].ToString() == "" ? "PENDIENTE" : data[9];

                dgvDatos.Rows.Add(new object[] { data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], horaSalida });


            }
            foreach (DataGridViewRow data in dgvDatos.Rows)
            {
                if (data.Cells["hora_salida"].Value.ToString() == "PENDIENTE")
                {
                    data.Cells["hora_salida"].Style.BackColor = Color.FromArgb(57, 169, 0);
                    data.Cells["hora_salida"].ToolTipText = "Doble click para fijar hora de salida";
                }
            }
            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "", "", "", "", "", "", "SIN DATOS PARA MOSTRAR", "", "", "" });
            }
            dgvDatos.ClearSelection();
        }
        private void cmbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDataRango();
        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDataRango();
        }
        private void btnListAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estás seguro que quieres listar todo?\nEste proceso podría tardar unos minutos en completarse", "Listar todo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CargarData("1");
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
                CargarDataRango();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscarParametro();
            }
        }

 

        // Funciones personalizadas
        private void CargarData(string all)
        {
            pButtonsContainer.Visible = false;
            var response = Controllers.Entradas.Entradas.SeleccionarEntradas(all);
            DataTable entranceData = response.Item1;
            // Limpiar datos
            dgvDatos.Rows.Clear();
            if (!response.Item2)
            {
                MessageBox.Show("Error al traer los datos de las entradas", "Tabla entradas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow data in entranceData.Rows)
            {
                var horaSalida = data[9].ToString() == "" ? "PENDIENTE" : data[9];

                dgvDatos.Rows.Add(new object[] { data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], horaSalida });


            }
            foreach (DataGridViewRow data in dgvDatos.Rows)
            {
                if (data.Cells["hora_salida"].Value.ToString() == "PENDIENTE")
                {
                    data.Cells["hora_salida"].Style.BackColor = Color.FromArgb(57, 169, 0);
                    data.Cells["hora_salida"].ToolTipText = "Doble click para fijar hora de salida";
                }
            }
            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "", "", "", "", "", "", "SIN DATOS PARA MOSTRAR", "", "", "" });
            }
            dgvDatos.ClearSelection();
        }
        private void CargarDataRango()
        {
            pButtonsContainer.Visible = false;
            var response = Controllers.Entradas.Entradas.SeleccionarEntradasRango(cmbValue.Text == "" ? "5" : cmbValue.Text, cmbType.Text);
            DataTable entranceData = response.Item1;
            // Limpiar datos
            dgvDatos.Rows.Clear();
            if (!response.Item2)
            {
                MessageBox.Show("Error al traer los datos de las entradas", "Tabla entradas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow data in entranceData.Rows)
            {
                var horaSalida = data[9].ToString() == "" ? "PENDIENTE" : data[9];

                dgvDatos.Rows.Add(new object[] { data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], horaSalida });


            }
            foreach (DataGridViewRow data in dgvDatos.Rows)
            {
                if (data.Cells["hora_salida"].Value.ToString() == "PENDIENTE")
                {
                    data.Cells["hora_salida"].Style.BackColor = Color.FromArgb(57, 169, 0);
                    data.Cells["hora_salida"].ToolTipText = "Doble click para fijar hora de salida";
                }
            }
            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "", "", "", "", "", "", "SIN DATOS PARA MOSTRAR", "", "", "" });
            }
            dgvDatos.ClearSelection();
        }
        private void BuscarParametro()
        {
            if (txtSearch.Text.Length == 0 || txtSearch.Text == "Buscar por Identificación o Nombres")
            {
                MessageBox.Show("Digita por lo menos un parámetro de búsqueda", "Buscar registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                pButtonsContainer.Visible = false;
                var response = Controllers.Entradas.Entradas.SeleccionarEntradasParametro(cmbValue.Text == "" ? "5" : cmbValue.Text,cmbType.Text,txtSearch.Text);
                DataTable entranceData = response.Item1;
                // Limpiar datos
                dgvDatos.Rows.Clear();
                if (!response.Item2)
                {
                    MessageBox.Show("Error al traer los datos de las entradas", "Tabla entradas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                foreach (DataRow data in entranceData.Rows)
                {
                    var horaSalida = data[9].ToString() == "" ? "PENDIENTE" : data[9];

                    dgvDatos.Rows.Add(new object[] { data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], horaSalida });


                }
                foreach (DataGridViewRow data in dgvDatos.Rows)
                {
                    if (data.Cells["hora_salida"].Value.ToString() == "PENDIENTE")
                    {
                        data.Cells["hora_salida"].Style.BackColor = Color.FromArgb(57, 169, 0);
                        data.Cells["hora_salida"].ToolTipText = "Doble click para fijar hora de salida";
                    }
                }
                if (dgvDatos.Rows.Count == 0)
                {
                    dgvDatos.Rows.Add(new object[] { "", "", "", "", "", "", "SIN DATOS PARA MOSTRAR", "", "", "" });
                }
                dgvDatos.ClearSelection();
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

        private void cmbType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

      
    }
}

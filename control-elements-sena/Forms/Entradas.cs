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
        private Point initialPosition;
        public Entradas()
        {
            InitializeComponent();
        }



        private void btnCloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void Users_Load(object sender, EventArgs e)
        {
            pButtonsContainer.Visible = false;
            var response = Controllers.Entradas.Entradas.SeleccionarEntradas();
            DataTable entranceData = response.Item1;
            if (!response.Item2)
            {
                MessageBox.Show("Error al traer los datos de las entradas", "Tabla entradas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow data in entranceData.Rows)
            {
                var horaSalida = data[9].ToString() == "" ? "PENDIENTE" : data[9];
                
                dgvDatos.Rows.Add(new object[] { data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], horaSalida });
              

            }
            foreach(DataGridViewRow data in dgvDatos.Rows)
            {
                if (data.Cells["hora_salida"].Value.ToString() == "PENDIENTE")
                {
                    data.Cells["hora_salida"].Style.BackColor = Color.Red;
                    data.Cells["hora_salida"].ToolTipText = "Doble click para fijar hora de salida";
                }
            }
            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "", "", "", "", "", "", "SIN DATOS PARA MOSTRAR", "", "", "" });
            }
            dgvDatos.Rows[0].ReadOnly = true;
            dgvDatos.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new CrearEntrada().ShowDialog();
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
                    if (Controllers.Entradas.Entradas.RegistrarSalida())
                    {
                        MessageBox.Show("Operación exitosa", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show(Controllers.Entradas.Entradas.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

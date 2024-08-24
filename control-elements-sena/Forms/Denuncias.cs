using control_elements_sena.Forms.Create;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena
{
    public partial class Denuncias : Form
    {
        private Point initialPosition;
        public Denuncias()
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

        private void Denuncias_Load(object sender, EventArgs e)
        {
            pButtonsContainer.Visible = false;
            var response = Controllers.Denuncias.Denuncias.SeleccionarDenuncias();
            DataTable reportData = response.Item1;
            if (!response.Item2)
            {
                MessageBox.Show("Error al traer los datos de las denuncias", "Tabla denuncias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow data in reportData.Rows)
            {
                dgvDatos.Rows.Add(new object[] { data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7].ToString() != "" ? data[7] : "SIN FECHA", data[8], Convert.ToByte(data[9]) == 1 ? "Activa":"Inactiva"});
            }
            foreach(DataGridViewRow data in dgvDatos.Rows)
            {
                if (data.Cells[9].Value.ToString() == "Activa")
                {
                    data.Cells[9].Style.BackColor = Color.FromArgb(57, 169, 0);
                }
            }
            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "", "", "", "", "", "", "SIN DATOS PARA MOSTRAR", "","","","" });


            }
            dgvDatos.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new CrearDenuncia().ShowDialog();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celdaSeleccionada = dgvDatos.CurrentCell.RowIndex;
            if (dgvDatos.Rows[celdaSeleccionada].Cells[9].Value.ToString() == "Inactiva")
            {
                MessageBox.Show("Selecciona una denuncia que aún no esté solucionada y activa", "Solucionar denuncia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new SolucionarDenuncia(dgvDatos.Rows[celdaSeleccionada].Cells[0].Value.ToString()).ShowDialog();
            }
            
        }
    }
}

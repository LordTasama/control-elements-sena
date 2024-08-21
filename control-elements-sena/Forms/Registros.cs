using control_elements_sena.Forms.Create;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena
{
    public partial class Registros : Form
    {
        private Point initialPosition;
        private bool selectedCellRow;
        public Registros()
        {
            InitializeComponent();
        }



        private void btnCloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            pButtonsContainer.Visible = false;
            var response = Controllers.Registros.Registros.SeleccionarRegistros();
            DataTable recordData = response.Item1;
            if (!response.Item2)
            {
                MessageBox.Show("Error al traer los datos de los registros", "Tabla registros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow data in recordData.Rows)
            {

                dgvDatos.Rows.Add(new object[] { data[0], data[2], data[1]});


            }
            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "", "", "SIN DATOS PARA MOSTRAR" });


            }

           
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (selectedCellRow)
            {
            int currentRow = dgvDatos.CurrentCell.RowIndex;
            string[] data = new string[3];
            foreach (DataGridViewCell cell in dgvDatos.Rows[currentRow].Cells)
            {
                data[cell.ColumnIndex] = cell.Value.ToString();
            }
            new EditarRegistro(data).ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un registro","Registros",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.Rows[0].Cells["Nombres"].Value.ToString() == "SIN DATOS PARA MOSTRAR")
            {
                dgvDatos.ClearSelection();
                selectedCellRow = false;
            }
            else
            {
                selectedCellRow = true;
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

       
    }
}

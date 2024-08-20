using control_elements_sena.Controllers.Usuarios;
using control_elements_sena.Forms.Create;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena
{
    public partial class Users : Form
    {
        private Point initialPosition;
        public Users()
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

            var response = Usuarios.SeleccionarUsuarios();
            DataTable userData = response.Item1;
            if (!response.Item2)
            {
                MessageBox.Show("Error al traer los datos de los usuarios", "Tabla usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow data in userData.Rows)
            {
                string rol = Convert.ToInt16(data[5]) == 1 ? "Administrador" : "Guardia";
                string status = Convert.ToInt16(data[6]) == 1 ? "Activo" : "Inactivo";
                dgvDatos.Rows.Add(new object[] { data[0], data[1], data[2], data[3], data[4], rol, status });
            }

            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "A", "", "", "", "SIN DATOS PARA MOSTRAR", "", "" });
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new CrearUsuario().ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int currentRow = dgvDatos.CurrentCell.RowIndex;
            string[] data = new string[7];
            foreach(DataGridViewCell cell in dgvDatos.Rows[currentRow].Cells)
            {
                data[cell.ColumnIndex] = cell.Value.ToString(); 
            }
            new EditarUsuario(data).ShowDialog();
          
            
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            int currentRow = dgvDatos.CurrentCell.RowIndex;
            string[] data = new string[7];
            foreach (DataGridViewCell cell in dgvDatos.Rows[currentRow].Cells)
            {
                data[cell.ColumnIndex] = cell.Value.ToString();
            }
            new EstadoUsuario(data).ShowDialog();
        }
    }
}

using control_elements_sena.Controllers;
using control_elements_sena.Controllers.Usuarios;
using control_elements_sena.Forms.Create;
using OfficeOpenXml.FormulaParsing.Ranges;
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
            CargarData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           if(new CrearUsuario().ShowDialog() == DialogResult.OK) {
                CargarData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int currentRow = dgvDatos.CurrentCell.RowIndex;
            string[] data = new string[8];
            foreach(DataGridViewCell cell in dgvDatos.Rows[currentRow].Cells)
            {
                data[cell.ColumnIndex] = cell.Value.ToString(); 
            }
            if (new EditarUsuario(data).ShowDialog() == DialogResult.OK)
            {
                CargarData();
            }


        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            int currentRow = dgvDatos.CurrentCell.RowIndex;
            string[] data = new string[8];
            foreach (DataGridViewCell cell in dgvDatos.Rows[currentRow].Cells)
            {
                data[cell.ColumnIndex] = cell.Value.ToString();
            }
            if (new EstadoUsuario(data).ShowDialog() == DialogResult.OK)
            {
                CargarData();
            }
        }

        async private void CargarData()
        {
            Session session = new Session();
            await session.DescifrarTokenAsync();
            if (!session.validToken)
            {
                MessageBox.Show("Su sesión expiró, inicie sesión nuevamente", "Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
            pButtonsContainer.Visible = false;

            var response = Usuarios.SeleccionarUsuarios();
            DataTable userData = response.Item1;
            if (!response.Item2)
            {
                MessageBox.Show("Error al traer los datos de los usuarios", "Tabla usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvDatos.Rows.Clear();
            foreach (DataRow data in userData.Rows)
            {
                string rol = data[6].ToString();
                string status = Convert.ToInt16(data[7]) == 1 ? "Activo" : "Inactivo";
                dgvDatos.Rows.Add(new object[] { data[0], data[1], data[2], data[3], data[4], Convert.ToByte(data[5]), rol, status });
                if (Convert.ToInt64(data[0]) == Session.idUserGlobal)
                {
                    foreach(DataGridViewCell cell in dgvDatos.Rows[dgvDatos.Rows.Count - 1].Cells)
                    {
                        cell.Style.BackColor = Color.Green;
                    }
                    
                }
            }

            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "", "", "", "", "", "SIN DATOS PARA MOSTRAR", "", "" });
            }
        }
    }
}

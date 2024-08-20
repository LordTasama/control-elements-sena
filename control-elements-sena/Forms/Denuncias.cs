using System;
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

        private void Users_Load(object sender, EventArgs e)
        {
            pButtonsContainer.Visible = false;

            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "", "", "", "", "", "SIN DATOS PARA MOSTRAR", "", "" });


            }
            dgvDatos.ClearSelection();
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena
{
    public partial class Elementos : Form
    {
        private Point initialPosition;
        public Elementos()
        {
            InitializeComponent();
        }



        private void btnCloseForm_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                dgvDatos.Rows.Add(new object[] { "", "", "", "", "SIN DATOS PARA MOSTRAR", "" });


            }
            dgvDatos.ClearSelection();
        }
    }
}

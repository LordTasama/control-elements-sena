using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_elements_sena
{
    public partial class Users : Form
    {
        private  Point initialPosition;
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
            if (pButtonsContainer.Visible) {
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
        }
    }
}

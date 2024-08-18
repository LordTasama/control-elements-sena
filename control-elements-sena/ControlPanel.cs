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
    public partial class ControlPanel : Form
    {
        private bool MouseDown;
        private Point lastLocation;
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void pControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            lastLocation = e.Location;
        }

        private void pControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                // Mueve el formulario a la nueva posición del ratón
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update(); // Actualiza la posición del formulario
            }
        }

        private void pControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }


        private void btnMaximizeWindow_Click(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimizeWindow_Click(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseWindow_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}

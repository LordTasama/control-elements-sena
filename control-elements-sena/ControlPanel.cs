using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private bool menuExpand = false;
        private bool sidebarExpand = true;
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

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                dropMenuContainer.Height += 10;
                if(dropMenuContainer.Height >= 121)
                {
                    dropMenuContainer.Height = 121;
                    menuExpand = true;
                    menuTransition.Stop();
                }
            }
            else
            {
                dropMenuContainer.Height -= 10;
                if (dropMenuContainer.Height <= 30)
                {
                    dropMenuContainer.Height = 30;
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btnElements_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            Padding currentMargin = btnSidebarControl.Margin;
            if (!sidebarExpand)
            {
                if (currentMargin.Left + 5 <= 60)
                {
                    btnSidebarControl.Margin = new Padding(currentMargin.Left + 5, 40, 0, 0);
                }
                else
                {
                    btnSidebarControl.Margin = new Padding(60, 40, 0, 0);
                    btnSidebarControl.Image = Properties.Resources.flecha_izq;
                    
                }
                pSidebar.Width += 10;
                if (pSidebar.Width >= 165)
                {
                    pSidebar.Width = 165;
                    lblTitle.Text = "       Panel de Control";
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                if (currentMargin.Left - 5 >= 0)
                {
                    btnSidebarControl.Margin = new Padding(currentMargin.Left - 5, 40, 0, 0);
                    
                }
                else
                {
                    btnSidebarControl.Margin = new Padding(0, 40, 0, 3);
                    btnSidebarControl.Image = Properties.Resources.flecha_der;
                    
                }

                pSidebar.Width -= 10;
                if (pSidebar.Width <= 38)
                {
                    pSidebar.Width = 38;
                    lblTitle.Text = "";
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnSidebarControl_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

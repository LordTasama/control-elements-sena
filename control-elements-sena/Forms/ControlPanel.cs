using System;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena
{
    public partial class ControlPanel : Form
    {
        private bool MouseDown;
        private Point lastLocation;
        private bool menuExpand = false;
        private bool sidebarExpand = true;
        private Form currentForm;
        public ControlPanel()
        {
            InitializeComponent();
        }

        // Controles de la ventana
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

        // Fin

        // Funcionalidad del dropmenu de las tablas
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
              
                dropMenuContainer.Height += 10;
                pSectionsContainer.Location = new Point(pSectionsContainer.Location.X,pSectionsContainer.Location.Y + 9);

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
                pSectionsContainer.Location = new Point(pSectionsContainer.Location.X, pSectionsContainer.Location.Y - 9);
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
        // Fin


        // Funcionalidad de la barra lateral
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            Point currentPosition = btnSidebarControl.Location;
            if (!sidebarExpand)
            {
                if (currentPosition.X + 5 <= 60)
                {
                    btnSidebarControl.Location = new Point(currentPosition.X + 5,currentPosition.Y);
                }
                else
                {
                    btnSidebarControl.Image = Properties.Resources.flecha_izq;
                    btnSidebarControl.Location = new Point(60, currentPosition.Y);
                }
                pSidebar.Width += 10;
                
                if (pSidebar.Width >= 165)
                {
                    pSidebar.Width = 165;
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    pContainer.Visible = true;
                }
            }
            else
            {
                if (currentPosition.X - 5 >= 0)
                {
                    btnSidebarControl.Location = new Point(currentPosition.X - 5, currentPosition.Y);

                }
                else
                {
                    btnSidebarControl.Image = Properties.Resources.flecha_der;
                    btnSidebarControl.Location = new Point(-2, currentPosition.Y);

                }

                pSidebar.Width -= 10;
                if (pSidebar.Width <= 38)
                {
                    pSidebar.Width = 38;
                    sidebarExpand = false;
                    lblCentro.Visible = false;
                    sidebarTransition.Stop();
                    pContainer.Visible = true;
                }
            }
        }

        private void btnSidebarControl_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
            lblCentro.Visible = true;
            pContainer.Visible = false;
        }

        // Fin

        // Funcionalidad general de la aplicación
        private void btnUsers_Click(object sender, EventArgs e)
        {
            var users = new Users();
            users.TopLevel = false; 
            users.Dock = DockStyle.Fill;
            pContainer.Controls.Add(users);
            pContainer.Tag = users;
            users.BringToFront();
            users.Show();
            currentForm = users;
            btnCloseForm.Visible = true;
            lblPage.Text = "Usuarios ";
            SidebarSelect();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Registros";
            SidebarSelect();
        }

        private void btnElements_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Elementos";
            SidebarSelect();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Reportes ";
            SidebarSelect();
        }

        private void btnInforms_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Denuncias";
            SidebarSelect();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Mi perfil";
            SidebarSelect();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseForm_Click_1(object sender, EventArgs e)
        {
            btnCloseForm.Visible = false;
            currentForm.Close();
            lblPage.Text = "";
            SidebarSelect();
        }

        private void SidebarSelect()
        {
            string condition = lblPage.Text;
            foreach (Control control in pSidebar.Controls)
            {
                if (control is FlowLayoutPanel)
                {
                    foreach (Control controlP in control.Controls)
                    {
                        if (controlP is Button)
                        {
                           
                            if (!controlP.Text.Contains(condition.Trim(' ')) || condition == "")
                            {
                                controlP.BackColor = Color.White;
                            }
                            else
                            {
                                btnTables.BackColor = Color.Gainsboro;
                                controlP.BackColor = Color.Gainsboro;
                            }
                        }

                    }

                }
                else if(control is Panel)
                {
                    foreach(Control controlP in control.Controls)
                    {
                        if (controlP is Button)
                        {
                            if (!controlP.Text.Contains(condition.Trim(' ')) || condition == "")
                            {
                                controlP.BackColor = Color.White;
                            }
                            else
                            {
                                controlP.BackColor = Color.Gainsboro;
                            }
                        }
                       
                    }
                }
            }
        }
        // Fin
    }
}

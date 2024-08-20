using System;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena
{
    public partial class ControlPanel : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private bool menuExpand = false;
        private bool sidebarExpand = true;
        private Form currentForm;
        private bool firstTickTime;
        public ControlPanel()
        {
            InitializeComponent();

        }

        // Controles de la ventana
        private void pControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Mueve el formulario a la nueva posición del ratón
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update(); // Actualiza la posición del formulario
            }
        }

        private void pControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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
                pSectionsContainer.Location = new Point(pSectionsContainer.Location.X, pSectionsContainer.Location.Y + 9);

                if (dropMenuContainer.Height >= 121)
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
                    btnSidebarControl.Location = new Point(currentPosition.X + 5, currentPosition.Y);
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
            lblPage.Text = "Usuarios ";
            this.Text = "Panel de Control - Usuarios";
            loadForm("Usuarios ");
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Registros";
            this.Text = "Panel de Control - Registros";
            loadForm("Registros");
        }

        private void btnElements_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Elementos";
            this.Text = "Panel de Control - Elementos";
            loadForm("Elementos");
        }
        private void btnEntrances_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Entradas";
            this.Text = "Panel de Control - Entradas";
            loadForm("Entradas"); 
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Reportes ";
            this.Text = "Panel de Control - Reportes";
            SidebarSelect();
        }

        private void btnInforms_Click(object sender, EventArgs e)
        {
            
            lblPage.Text = "Denuncias";
            this.Text = "Panel de Control - Denuncias";
            loadForm("Denuncias");
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
            currentForm.Close();
            btnCloseForm.Visible = false;
            SidebarSelect();
            lblPage.Text = "";
            this.Text = "Panel de Control";
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
                else if (control is Panel)
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
                                controlP.BackColor = Color.Gainsboro;
                            }
                        }

                    }
                }
            }
        }


        private void timeToday_Tick(object sender, EventArgs e)
        {
            var timeToday = DateTime.Now;
            string hour = timeToday.Hour.ToString();
            string minute = timeToday.Minute.ToString();
            string second = timeToday.Second.ToString();
            int month = Convert.ToInt32(timeToday.Month);
            string dayMonth = timeToday.Day.ToString();
            string year = timeToday.Year.ToString();
            int day = Convert.ToInt32(timeToday.DayOfWeek);

            hour = hour.Length == 1 ? $"0{hour}" : hour;
            minute = minute.Length == 1 ? $"0{minute}" : minute;
            second = second.Length == 1 ? $"0{second}" : second;

            string[] months = { "", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            string[] days = { "", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            lblDate.Text = $"{days[day]} {dayMonth} de {months[month]} {year}";
            lblTime.Text = $"{hour}:{minute}:{second}";
            // Adaptar el label a cualquier fecha - responsive
            if (!firstTickTime)
            {
                int lengthLblDate = (-lblDate.Text.Length + 1) * 9;
                int initialPixels = -51;
                lblDate.Location = new Point(lblDate.Location.X + (lengthLblDate + initialPixels - 10), lblDate.Location.Y);
                pictureDate.Location = new Point(pictureDate.Location.X + (lengthLblDate + initialPixels), pictureDate.Location.Y);
                firstTickTime = true;
            }
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            firstTickTime = false;
            timeToday.Start();
        }

        private void pictureReload_Click(object sender, EventArgs e)
        {
            currentForm.Close();
            loadForm(lblPage.Text);
        }
        private void loadForm(string condition)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            if (condition == "Usuarios ")
            {
                var users = new Users();
                users.TopLevel = false;
                users.Dock = DockStyle.Fill;
                pContainer.Controls.Add(users);
                pContainer.Tag = users;
                users.BringToFront();
                users.Show();
                currentForm = users;
            }
            else if (condition == "Registros")
            {
                var registros = new Registros();
                registros.TopLevel = false;
                registros.Dock = DockStyle.Fill;
                pContainer.Controls.Add(registros);
                pContainer.Tag = registros;
                registros.BringToFront();
                registros.Show();
                currentForm = registros;
            }
            else if (condition == "Elementos")
            {
                var elementos = new Elementos();
                elementos.TopLevel = false;
                elementos.Dock = DockStyle.Fill;
                pContainer.Controls.Add(elementos);
                pContainer.Tag = elementos;
                elementos.BringToFront();
                elementos.Show();
                currentForm = elementos;
            }
            else if (condition == "Entradas")
            {
                var entradas = new Entradas();
                entradas.TopLevel = false;
                entradas.Dock = DockStyle.Fill;
                pContainer.Controls.Add(entradas);
                pContainer.Tag = entradas;
                entradas.BringToFront();
                entradas.Show();
                currentForm = entradas;
            }
            else if (condition == "Reportes")
            {

            }
            else if(condition == "Denuncias")
            {
                var denuncias = new Denuncias();
                denuncias.TopLevel = false;
                denuncias.Dock = DockStyle.Fill;
                pContainer.Controls.Add(denuncias);
                pContainer.Tag = denuncias;
                denuncias.BringToFront();
                denuncias.Show();
                currentForm = denuncias;
            }
            else if(condition == "Mi perfil")
            {

            }
            btnCloseForm.Visible = true;
            pictureReload.Visible = true;
            SidebarSelect();
        }

        // Fin
    }
}

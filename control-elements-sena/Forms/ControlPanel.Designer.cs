namespace control_elements_sena
{
    partial class ControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.toolTipTables = new System.Windows.Forms.ToolTip(this.components);
            this.btnTables = new System.Windows.Forms.Button();
            this.toolTipUsers = new System.Windows.Forms.ToolTip(this.components);
            this.btnUsers = new System.Windows.Forms.Button();
            this.toolTipRecords = new System.Windows.Forms.ToolTip(this.components);
            this.btnRecords = new System.Windows.Forms.Button();
            this.toolTipElements = new System.Windows.Forms.ToolTip(this.components);
            this.btnElements = new System.Windows.Forms.Button();
            this.toolTipReports = new System.Windows.Forms.ToolTip(this.components);
            this.btnReports = new System.Windows.Forms.Button();
            this.toolTipInforms = new System.Windows.Forms.ToolTip(this.components);
            this.btnInforms = new System.Windows.Forms.Button();
            this.toolTipPerfil = new System.Windows.Forms.ToolTip(this.components);
            this.btnPerfil = new System.Windows.Forms.Button();
            this.toolTipLogOut = new System.Windows.Forms.ToolTip(this.components);
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dropMenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pSidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogoSena = new System.Windows.Forms.PictureBox();
            this.lblCentro = new System.Windows.Forms.Label();
            this.pSectionsContainer = new System.Windows.Forms.Panel();
            this.btnSidebarControl = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pDesktopContainer = new System.Windows.Forms.Panel();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pControlBox = new System.Windows.Forms.Panel();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMaximizeWindow = new System.Windows.Forms.Button();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.dropMenuContainer.SuspendLayout();
            this.pSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSena)).BeginInit();
            this.pSectionsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pDesktopContainer.SuspendLayout();
            this.pControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(810, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Panel de Control";
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // toolTipTables
            // 
            this.toolTipTables.AutomaticDelay = 0;
            this.toolTipTables.AutoPopDelay = 5000;
            this.toolTipTables.BackColor = System.Drawing.Color.Green;
            this.toolTipTables.ForeColor = System.Drawing.Color.White;
            this.toolTipTables.InitialDelay = 0;
            this.toolTipTables.IsBalloon = true;
            this.toolTipTables.ReshowDelay = 0;
            // 
            // btnTables
            // 
            this.btnTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTables.FlatAppearance.BorderSize = 0;
            this.btnTables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTables.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnTables.ForeColor = System.Drawing.Color.Black;
            this.btnTables.Image = global::control_elements_sena.Properties.Resources.tabla_de_base_de_datos;
            this.btnTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTables.Location = new System.Drawing.Point(0, 0);
            this.btnTables.Margin = new System.Windows.Forms.Padding(0);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(165, 30);
            this.btnTables.TabIndex = 3;
            this.btnTables.Text = "        Tablas";
            this.btnTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipTables.SetToolTip(this.btnTables, "Tablas");
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // toolTipUsers
            // 
            this.toolTipUsers.AutomaticDelay = 0;
            this.toolTipUsers.AutoPopDelay = 5000;
            this.toolTipUsers.BackColor = System.Drawing.Color.Green;
            this.toolTipUsers.ForeColor = System.Drawing.Color.White;
            this.toolTipUsers.InitialDelay = 0;
            this.toolTipUsers.IsBalloon = true;
            this.toolTipUsers.ReshowDelay = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Image = global::control_elements_sena.Properties.Resources.security_guard;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 30);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(165, 30);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "        Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipUsers.SetToolTip(this.btnUsers, "Usuarios");
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // toolTipRecords
            // 
            this.toolTipRecords.AutomaticDelay = 0;
            this.toolTipRecords.AutoPopDelay = 5000;
            this.toolTipRecords.BackColor = System.Drawing.Color.Green;
            this.toolTipRecords.ForeColor = System.Drawing.Color.White;
            this.toolTipRecords.InitialDelay = 0;
            this.toolTipRecords.IsBalloon = true;
            this.toolTipRecords.ReshowDelay = 0;
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRecords.ForeColor = System.Drawing.Color.Black;
            this.btnRecords.Image = global::control_elements_sena.Properties.Resources.trabajo_en_equipo;
            this.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.Location = new System.Drawing.Point(0, 60);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(165, 30);
            this.btnRecords.TabIndex = 4;
            this.btnRecords.Text = "        Registros";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipRecords.SetToolTip(this.btnRecords, "Registros");
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // toolTipElements
            // 
            this.toolTipElements.AutomaticDelay = 0;
            this.toolTipElements.AutoPopDelay = 5000;
            this.toolTipElements.BackColor = System.Drawing.Color.Green;
            this.toolTipElements.ForeColor = System.Drawing.Color.White;
            this.toolTipElements.InitialDelay = 0;
            this.toolTipElements.IsBalloon = true;
            this.toolTipElements.ReshowDelay = 0;
            // 
            // btnElements
            // 
            this.btnElements.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnElements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElements.FlatAppearance.BorderSize = 0;
            this.btnElements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElements.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnElements.ForeColor = System.Drawing.Color.Black;
            this.btnElements.Image = global::control_elements_sena.Properties.Resources.dispositivos;
            this.btnElements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElements.Location = new System.Drawing.Point(0, 90);
            this.btnElements.Margin = new System.Windows.Forms.Padding(0);
            this.btnElements.Name = "btnElements";
            this.btnElements.Size = new System.Drawing.Size(165, 30);
            this.btnElements.TabIndex = 8;
            this.btnElements.Text = "        Elementos";
            this.btnElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipElements.SetToolTip(this.btnElements, "Elementos");
            this.btnElements.UseVisualStyleBackColor = false;
            this.btnElements.Click += new System.EventHandler(this.btnElements_Click);
            // 
            // toolTipReports
            // 
            this.toolTipReports.AutomaticDelay = 0;
            this.toolTipReports.AutoPopDelay = 5000;
            this.toolTipReports.BackColor = System.Drawing.Color.Green;
            this.toolTipReports.ForeColor = System.Drawing.Color.White;
            this.toolTipReports.InitialDelay = 0;
            this.toolTipReports.IsBalloon = true;
            this.toolTipReports.ReshowDelay = 0;
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Image = global::control_elements_sena.Properties.Resources.reporte_de_negocios;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 17);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(162, 30);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "        Reportes";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipReports.SetToolTip(this.btnReports, "Reportes");
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // toolTipInforms
            // 
            this.toolTipInforms.AutomaticDelay = 0;
            this.toolTipInforms.AutoPopDelay = 5000;
            this.toolTipInforms.BackColor = System.Drawing.Color.Green;
            this.toolTipInforms.ForeColor = System.Drawing.Color.White;
            this.toolTipInforms.InitialDelay = 0;
            this.toolTipInforms.IsBalloon = true;
            this.toolTipInforms.ReshowDelay = 0;
            // 
            // btnInforms
            // 
            this.btnInforms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInforms.FlatAppearance.BorderSize = 0;
            this.btnInforms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnInforms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforms.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnInforms.ForeColor = System.Drawing.Color.Black;
            this.btnInforms.Image = global::control_elements_sena.Properties.Resources.alerta;
            this.btnInforms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInforms.Location = new System.Drawing.Point(3, 53);
            this.btnInforms.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnInforms.Name = "btnInforms";
            this.btnInforms.Size = new System.Drawing.Size(162, 30);
            this.btnInforms.TabIndex = 6;
            this.btnInforms.Tag = "";
            this.btnInforms.Text = "        Denuncias";
            this.btnInforms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipInforms.SetToolTip(this.btnInforms, "Denuncias");
            this.btnInforms.UseVisualStyleBackColor = true;
            this.btnInforms.Click += new System.EventHandler(this.btnInforms_Click);
            // 
            // toolTipPerfil
            // 
            this.toolTipPerfil.AutomaticDelay = 0;
            this.toolTipPerfil.AutoPopDelay = 5000;
            this.toolTipPerfil.BackColor = System.Drawing.Color.Green;
            this.toolTipPerfil.ForeColor = System.Drawing.Color.White;
            this.toolTipPerfil.InitialDelay = 0;
            this.toolTipPerfil.IsBalloon = true;
            this.toolTipPerfil.ReshowDelay = 0;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnPerfil.ForeColor = System.Drawing.Color.Black;
            this.btnPerfil.Image = global::control_elements_sena.Properties.Resources.configuraciones;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(3, 101);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(162, 30);
            this.btnPerfil.TabIndex = 10;
            this.btnPerfil.Tag = "";
            this.btnPerfil.Text = "        Mi perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipPerfil.SetToolTip(this.btnPerfil, "Mi perfil");
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // toolTipLogOut
            // 
            this.toolTipLogOut.AutomaticDelay = 0;
            this.toolTipLogOut.AutoPopDelay = 5000;
            this.toolTipLogOut.BackColor = System.Drawing.Color.Green;
            this.toolTipLogOut.ForeColor = System.Drawing.Color.White;
            this.toolTipLogOut.InitialDelay = 0;
            this.toolTipLogOut.IsBalloon = true;
            this.toolTipLogOut.ReshowDelay = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::control_elements_sena.Properties.Resources.cerrar_sesion;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(3, 137);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(162, 30);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Tag = "";
            this.btnLogOut.Text = "        Cerrar sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipLogOut.SetToolTip(this.btnLogOut, "Cerrar sesión");
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dropMenuContainer
            // 
            this.dropMenuContainer.Controls.Add(this.btnTables);
            this.dropMenuContainer.Controls.Add(this.btnUsers);
            this.dropMenuContainer.Controls.Add(this.btnRecords);
            this.dropMenuContainer.Controls.Add(this.btnElements);
            this.dropMenuContainer.Location = new System.Drawing.Point(0, 68);
            this.dropMenuContainer.Name = "dropMenuContainer";
            this.dropMenuContainer.Size = new System.Drawing.Size(165, 30);
            this.dropMenuContainer.TabIndex = 3;
            // 
            // pSidebar
            // 
            this.pSidebar.BackColor = System.Drawing.Color.White;
            this.pSidebar.Controls.Add(this.dropMenuContainer);
            this.pSidebar.Controls.Add(this.panel1);
            this.pSidebar.Controls.Add(this.picLogoSena);
            this.pSidebar.Controls.Add(this.lblCentro);
            this.pSidebar.Controls.Add(this.pSectionsContainer);
            this.pSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSidebar.Location = new System.Drawing.Point(0, 0);
            this.pSidebar.Name = "pSidebar";
            this.pSidebar.Size = new System.Drawing.Size(165, 650);
            this.pSidebar.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 68);
            this.panel1.TabIndex = 0;
            // 
            // picLogoSena
            // 
            this.picLogoSena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picLogoSena.BackColor = System.Drawing.Color.Transparent;
            this.picLogoSena.BackgroundImage = global::control_elements_sena.Properties.Resources.sena_logo;
            this.picLogoSena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogoSena.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.picLogoSena.Location = new System.Drawing.Point(50, 536);
            this.picLogoSena.Margin = new System.Windows.Forms.Padding(50, 10, 0, 15);
            this.picLogoSena.Name = "picLogoSena";
            this.picLogoSena.Size = new System.Drawing.Size(60, 60);
            this.picLogoSena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogoSena.TabIndex = 26;
            this.picLogoSena.TabStop = false;
            // 
            // lblCentro
            // 
            this.lblCentro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCentro.AutoSize = true;
            this.lblCentro.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblCentro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblCentro.Location = new System.Drawing.Point(20, 611);
            this.lblCentro.Margin = new System.Windows.Forms.Padding(0);
            this.lblCentro.Name = "lblCentro";
            this.lblCentro.Size = new System.Drawing.Size(123, 26);
            this.lblCentro.TabIndex = 15;
            this.lblCentro.Text = "Centro de Tecnologías \r\nAgroindustriales\r\n";
            this.lblCentro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pSectionsContainer
            // 
            this.pSectionsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pSectionsContainer.Controls.Add(this.btnReports);
            this.pSectionsContainer.Controls.Add(this.btnSidebarControl);
            this.pSectionsContainer.Controls.Add(this.pictureBox3);
            this.pSectionsContainer.Controls.Add(this.pictureBox2);
            this.pSectionsContainer.Controls.Add(this.btnInforms);
            this.pSectionsContainer.Controls.Add(this.btnLogOut);
            this.pSectionsContainer.Controls.Add(this.btnPerfil);
            this.pSectionsContainer.Location = new System.Drawing.Point(0, 102);
            this.pSectionsContainer.Name = "pSectionsContainer";
            this.pSectionsContainer.Size = new System.Drawing.Size(165, 273);
            this.pSectionsContainer.TabIndex = 0;
            // 
            // btnSidebarControl
            // 
            this.btnSidebarControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSidebarControl.FlatAppearance.BorderSize = 0;
            this.btnSidebarControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSidebarControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSidebarControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidebarControl.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSidebarControl.ForeColor = System.Drawing.Color.Black;
            this.btnSidebarControl.Image = global::control_elements_sena.Properties.Resources.flecha_izq;
            this.btnSidebarControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSidebarControl.Location = new System.Drawing.Point(60, 210);
            this.btnSidebarControl.Margin = new System.Windows.Forms.Padding(0);
            this.btnSidebarControl.Name = "btnSidebarControl";
            this.btnSidebarControl.Size = new System.Drawing.Size(42, 39);
            this.btnSidebarControl.TabIndex = 7;
            this.btnSidebarControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSidebarControl.UseVisualStyleBackColor = true;
            this.btnSidebarControl.Click += new System.EventHandler(this.btnSidebarControl_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::control_elements_sena.Properties.Resources.menos_linea_recta_horizontal;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(17, 83);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 18);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::control_elements_sena.Properties.Resources.menos_linea_recta_horizontal;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(17, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 18);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pDesktopContainer
            // 
            this.pDesktopContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.pDesktopContainer.Controls.Add(this.pContainer);
            this.pDesktopContainer.Controls.Add(this.pControlBox);
            this.pDesktopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDesktopContainer.Location = new System.Drawing.Point(165, 0);
            this.pDesktopContainer.Name = "pDesktopContainer";
            this.pDesktopContainer.Size = new System.Drawing.Size(1035, 650);
            this.pDesktopContainer.TabIndex = 22;
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 68);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1035, 582);
            this.pContainer.TabIndex = 22;
            // 
            // pControlBox
            // 
            this.pControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.pControlBox.Controls.Add(this.lblPage);
            this.pControlBox.Controls.Add(this.btnCloseForm);
            this.pControlBox.Controls.Add(this.lblTitle);
            this.pControlBox.Controls.Add(this.btnMaximizeWindow);
            this.pControlBox.Controls.Add(this.btnMinimizeWindow);
            this.pControlBox.Controls.Add(this.btnCloseWindow);
            this.pControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControlBox.Location = new System.Drawing.Point(0, 0);
            this.pControlBox.Name = "pControlBox";
            this.pControlBox.Size = new System.Drawing.Size(1035, 68);
            this.pControlBox.TabIndex = 0;
            this.pControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseDown);
            this.pControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseMove);
            this.pControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseUp);
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.Color.Transparent;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPage.ForeColor = System.Drawing.Color.White;
            this.lblPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPage.Location = new System.Drawing.Point(472, 20);
            this.lblPage.Margin = new System.Windows.Forms.Padding(0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(0, 25);
            this.lblPage.TabIndex = 28;
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.Location = new System.Drawing.Point(6, 12);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(40, 40);
            this.btnCloseForm.TabIndex = 27;
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Visible = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click_1);
            // 
            // btnMaximizeWindow
            // 
            this.btnMaximizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMaximizeWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnMaximizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnMaximizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeWindow.Image = global::control_elements_sena.Properties.Resources.maximize_white;
            this.btnMaximizeWindow.Location = new System.Drawing.Point(971, 1);
            this.btnMaximizeWindow.Name = "btnMaximizeWindow";
            this.btnMaximizeWindow.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizeWindow.TabIndex = 6;
            this.btnMaximizeWindow.UseVisualStyleBackColor = false;
            this.btnMaximizeWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMaximizeWindow_Click);
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnMinimizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeWindow.Image = global::control_elements_sena.Properties.Resources.minus_white;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(939, 1);
            this.btnMinimizeWindow.Name = "btnMinimizeWindow";
            this.btnMinimizeWindow.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizeWindow.TabIndex = 5;
            this.btnMinimizeWindow.UseVisualStyleBackColor = false;
            this.btnMinimizeWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMinimizeWindow_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Image = global::control_elements_sena.Properties.Resources.close_white;
            this.btnCloseWindow.Location = new System.Drawing.Point(1005, 1);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow.TabIndex = 4;
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCloseWindow_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.ControlBox = false;
            this.Controls.Add(this.pDesktopContainer);
            this.Controls.Add(this.pSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Control";
            this.dropMenuContainer.ResumeLayout(false);
            this.pSidebar.ResumeLayout(false);
            this.pSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoSena)).EndInit();
            this.pSectionsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pDesktopContainer.ResumeLayout(false);
            this.pControlBox.ResumeLayout(false);
            this.pControlBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.ToolTip toolTipTables;
        private System.Windows.Forms.ToolTip toolTipUsers;
        private System.Windows.Forms.ToolTip toolTipRecords;
        private System.Windows.Forms.ToolTip toolTipElements;
        private System.Windows.Forms.ToolTip toolTipReports;
        private System.Windows.Forms.ToolTip toolTipInforms;
        private System.Windows.Forms.ToolTip toolTipPerfil;
        private System.Windows.Forms.ToolTip toolTipLogOut;
        private System.Windows.Forms.PictureBox picLogoSena;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnInforms;
        private System.Windows.Forms.Button btnSidebarControl;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel dropMenuContainer;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnElements;
        private System.Windows.Forms.Panel pSidebar;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Panel pSectionsContainer;
        private System.Windows.Forms.Label lblCentro;
        private System.Windows.Forms.Panel pControlBox;
        private System.Windows.Forms.Button btnMaximizeWindow;
        private System.Windows.Forms.Button btnMinimizeWindow;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Panel pDesktopContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Panel pContainer;
    }
}
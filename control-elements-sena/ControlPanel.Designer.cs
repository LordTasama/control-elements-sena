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
            this.pControlBox = new System.Windows.Forms.Panel();
            this.btnMaximizeWindow = new System.Windows.Forms.Button();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.btnSidebarControl = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnInforms = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnElements = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.dropMenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pControlBox.SuspendLayout();
            this.dropMenuContainer.SuspendLayout();
            this.pSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pControlBox
            // 
            this.pControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.pControlBox.Controls.Add(this.btnMaximizeWindow);
            this.pControlBox.Controls.Add(this.btnMinimizeWindow);
            this.pControlBox.Controls.Add(this.btnCloseWindow);
            this.pControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControlBox.Location = new System.Drawing.Point(0, 0);
            this.pControlBox.Name = "pControlBox";
            this.pControlBox.Size = new System.Drawing.Size(1100, 32);
            this.pControlBox.TabIndex = 0;
            this.pControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseDown);
            this.pControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseMove);
            this.pControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseUp);
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
            this.btnMaximizeWindow.Location = new System.Drawing.Point(1036, 1);
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
            this.btnMinimizeWindow.Location = new System.Drawing.Point(1004, 1);
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
            this.btnCloseWindow.Location = new System.Drawing.Point(1070, 1);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow.TabIndex = 4;
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCloseWindow_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Image = global::control_elements_sena.Properties.Resources.control_panel;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(3, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "       Panel de Control";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
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
            this.btnSidebarControl.Location = new System.Drawing.Point(60, 270);
            this.btnSidebarControl.Margin = new System.Windows.Forms.Padding(60, 40, 0, 0);
            this.btnSidebarControl.Name = "btnSidebarControl";
            this.btnSidebarControl.Size = new System.Drawing.Size(42, 39);
            this.btnSidebarControl.TabIndex = 7;
            this.btnSidebarControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSidebarControl.UseVisualStyleBackColor = true;
            this.btnSidebarControl.Click += new System.EventHandler(this.btnSidebarControl_Click);
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
            this.btnReports.Location = new System.Drawing.Point(3, 89);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(165, 30);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "        Reportes";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
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
            this.btnInforms.Location = new System.Drawing.Point(3, 125);
            this.btnInforms.Name = "btnInforms";
            this.btnInforms.Size = new System.Drawing.Size(165, 30);
            this.btnInforms.TabIndex = 6;
            this.btnInforms.Tag = "";
            this.btnInforms.Text = "        Denuncias";
            this.btnInforms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInforms.UseVisualStyleBackColor = true;
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
            this.btnLogOut.Location = new System.Drawing.Point(3, 197);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(165, 30);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Tag = "";
            this.btnLogOut.Text = "        Cerrar sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
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
            this.btnPerfil.Location = new System.Drawing.Point(3, 161);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(165, 30);
            this.btnPerfil.TabIndex = 10;
            this.btnPerfil.Tag = "";
            this.btnPerfil.Text = "        Mi perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // btnElements
            // 
            this.btnElements.BackColor = System.Drawing.Color.Gainsboro;
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
            this.btnElements.Size = new System.Drawing.Size(168, 30);
            this.btnElements.TabIndex = 8;
            this.btnElements.Text = "        Elementos";
            this.btnElements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElements.UseVisualStyleBackColor = false;
            this.btnElements.Click += new System.EventHandler(this.btnElements_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.Gainsboro;
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
            this.btnRecords.Size = new System.Drawing.Size(168, 30);
            this.btnRecords.TabIndex = 4;
            this.btnRecords.Text = "        Registros";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Gainsboro;
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
            this.btnUsers.Size = new System.Drawing.Size(168, 30);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "        Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
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
            this.btnTables.Size = new System.Drawing.Size(167, 30);
            this.btnTables.TabIndex = 3;
            this.btnTables.Text = "        Tablas";
            this.btnTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // dropMenuContainer
            // 
            this.dropMenuContainer.Controls.Add(this.btnTables);
            this.dropMenuContainer.Controls.Add(this.btnUsers);
            this.dropMenuContainer.Controls.Add(this.btnRecords);
            this.dropMenuContainer.Controls.Add(this.btnElements);
            this.dropMenuContainer.Location = new System.Drawing.Point(3, 53);
            this.dropMenuContainer.Name = "dropMenuContainer";
            this.dropMenuContainer.Size = new System.Drawing.Size(167, 30);
            this.dropMenuContainer.TabIndex = 3;
            // 
            // pSidebar
            // 
            this.pSidebar.BackColor = System.Drawing.Color.White;
            this.pSidebar.Controls.Add(this.lblTitle);
            this.pSidebar.Controls.Add(this.dropMenuContainer);
            this.pSidebar.Controls.Add(this.btnReports);
            this.pSidebar.Controls.Add(this.btnInforms);
            this.pSidebar.Controls.Add(this.btnPerfil);
            this.pSidebar.Controls.Add(this.btnLogOut);
            this.pSidebar.Controls.Add(this.btnSidebarControl);
            this.pSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pSidebar.Location = new System.Drawing.Point(0, 32);
            this.pSidebar.Name = "pSidebar";
            this.pSidebar.Size = new System.Drawing.Size(165, 518);
            this.pSidebar.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::control_elements_sena.Properties.Resources.sena_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(1031, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(50, 10, 0, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ControlPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pSidebar);
            this.Controls.Add(this.pControlBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     Panel de Control";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.pControlBox.ResumeLayout(false);
            this.dropMenuContainer.ResumeLayout(false);
            this.pSidebar.ResumeLayout(false);
            this.pSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControlBox;
        private System.Windows.Forms.Button btnMaximizeWindow;
        private System.Windows.Forms.Button btnMinimizeWindow;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button btnSidebarControl;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnInforms;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnElements;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.FlowLayoutPanel dropMenuContainer;
        private System.Windows.Forms.FlowLayoutPanel pSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
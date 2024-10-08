namespace control_elements_sena.Forms.Create
{
    partial class CrearEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearEntrada));
            this.pControlBox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtIdPropietario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chxFormato3 = new System.Windows.Forms.CheckBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pControlBox
            // 
            this.pControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.pControlBox.Controls.Add(this.pictureBox1);
            this.pControlBox.Controls.Add(this.lblTitle);
            this.pControlBox.Controls.Add(this.btnCloseWindow);
            this.pControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControlBox.Location = new System.Drawing.Point(0, 0);
            this.pControlBox.Name = "pControlBox";
            this.pControlBox.Size = new System.Drawing.Size(222, 30);
            this.pControlBox.TabIndex = 11;
            this.pControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseDown);
            this.pControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseMove);
            this.pControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::control_elements_sena.Properties.Resources.open_enrollment;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(29, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registrar entrada";
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseWindow.Image")));
            this.btnCloseWindow.Location = new System.Drawing.Point(192, 0);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow.TabIndex = 1;
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.Black;
            this.lbUser.Location = new System.Drawing.Point(5, 39);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(181, 17);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Identificación del propietario";
            // 
            // txtIdPropietario
            // 
            this.txtIdPropietario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPropietario.Location = new System.Drawing.Point(8, 59);
            this.txtIdPropietario.MaxLength = 255;
            this.txtIdPropietario.Name = "txtIdPropietario";
            this.txtIdPropietario.Size = new System.Drawing.Size(206, 25);
            this.txtIdPropietario.TabIndex = 3;
            this.txtIdPropietario.TextChanged += new System.EventHandler(this.txtIdPropietario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres del propietario";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(8, 108);
            this.txtNombres.MaxLength = 255;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(206, 25);
            this.txtNombres.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Serie del elemento";
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(8, 206);
            this.txtSerie.MaxLength = 255;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(206, 25);
            this.txtSerie.TabIndex = 9;
            this.txtSerie.TextChanged += new System.EventHandler(this.txtSerie_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(66, 386);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 33);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Registrar";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbMarca
            // 
            this.cmbMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(8, 158);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(206, 25);
            this.cmbMarca.TabIndex = 7;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            this.cmbMarca.TextChanged += new System.EventHandler(this.cmbMarca_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca del elemento";
            // 
            // chxFormato3
            // 
            this.chxFormato3.AutoSize = true;
            this.chxFormato3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chxFormato3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.chxFormato3.Location = new System.Drawing.Point(10, 353);
            this.chxFormato3.Name = "chxFormato3";
            this.chxFormato3.Size = new System.Drawing.Size(90, 21);
            this.chxFormato3.TabIndex = 11;
            this.chxFormato3.Text = "Formato 3";
            this.chxFormato3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chxFormato3.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtObservaciones.Location = new System.Drawing.Point(8, 255);
            this.txtObservaciones.MaxLength = 255;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(206, 89);
            this.txtObservaciones.TabIndex = 13;
            this.txtObservaciones.Text = "SIN OBSERVACIONES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Observaciones";
            // 
            // CrearEntrada
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btnCloseWindow;
            this.ClientSize = new System.Drawing.Size(222, 433);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.chxFormato3);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtIdPropietario);
            this.Controls.Add(this.pControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar entrada";
            this.Load += new System.EventHandler(this.CrearEntrada_Load);
            this.pControlBox.ResumeLayout(false);
            this.pControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pControlBox;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtIdPropietario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chxFormato3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label1;
    }
}
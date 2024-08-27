namespace control_elements_sena.Forms.Create
{
    partial class ReportsDates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsDates));
            this.pControlBox = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.dtpInitialDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
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
            this.pControlBox.Size = new System.Drawing.Size(530, 30);
            this.pControlBox.TabIndex = 11;
            this.pControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseDown);
            this.pControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseMove);
            this.pControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::control_elements_sena.Properties.Resources.calendar;
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
            this.lblTitle.Size = new System.Drawing.Size(148, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Entradas por Fecha";
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
            this.btnCloseWindow.Location = new System.Drawing.Point(500, 0);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow.TabIndex = 1;
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // dtpInitialDate
            // 
            this.dtpInitialDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInitialDate.CustomFormat = "dddd dd/MM/yyyy";
            this.dtpInitialDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitialDate.Location = new System.Drawing.Point(55, 42);
            this.dtpInitialDate.Name = "dtpInitialDate";
            this.dtpInitialDate.Size = new System.Drawing.Size(155, 20);
            this.dtpInitialDate.TabIndex = 16;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CustomFormat = "dddd dd/MM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(268, 42);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(155, 20);
            this.dtpEndDate.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Desde";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(441, 39);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ReportsDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btnCloseWindow;
            this.ClientSize = new System.Drawing.Size(530, 74);
            this.ControlBox = false;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpInitialDate);
            this.Controls.Add(this.pControlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas por Fecha";
            this.pControlBox.ResumeLayout(false);
            this.pControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pControlBox;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpInitialDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
    }
}
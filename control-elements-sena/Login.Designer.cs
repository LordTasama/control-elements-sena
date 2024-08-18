﻿namespace control_elements_sena
{
    partial class Login
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.toolTShowPassword = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pControlBox
            // 
            this.pControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.pControlBox.Controls.Add(this.lblTitle);
            this.pControlBox.Controls.Add(this.btnMinimizeWindow);
            this.pControlBox.Controls.Add(this.btnCloseWindow);
            this.pControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControlBox.ForeColor = System.Drawing.SystemColors.Control;
            this.pControlBox.Location = new System.Drawing.Point(0, 0);
            this.pControlBox.Name = "pControlBox";
            this.pControlBox.Size = new System.Drawing.Size(300, 32);
            this.pControlBox.TabIndex = 0;
            this.pControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseDown);
            this.pControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseMove);
            this.pControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pControlBox_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Image = global::control_elements_sena.Properties.Resources.password;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(3, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "     Autenticación";
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
            this.btnMinimizeWindow.Location = new System.Drawing.Point(243, 1);
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
            this.btnCloseWindow.Location = new System.Drawing.Point(270, 1);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindow.TabIndex = 4;
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCloseWindow_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTitle.Location = new System.Drawing.Point(12, 6);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(121, 19);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Panel de Control";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(49, 151);
            this.txtUser.MaxLength = 255;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(206, 25);
            this.txtUser.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(49, 218);
            this.txtPassword.MaxLength = 600;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(206, 25);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(102, 255);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUser.Location = new System.Drawing.Point(52, 131);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(145, 17);
            this.lbUser.TabIndex = 11;
            this.lbUser.Text = "Identificación o Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contraseña";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.BackgroundImage = global::control_elements_sena.Properties.Resources.ojo;
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(259, 218);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(29, 23);
            this.btnShowPassword.TabIndex = 13;
            this.toolTShowPassword.SetToolTip(this.btnShowPassword, "Mostrar contraseña");
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Visible = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // toolTShowPassword
            // 
            this.toolTShowPassword.AutomaticDelay = 0;
            this.toolTShowPassword.AutoPopDelay = 5000;
            this.toolTShowPassword.InitialDelay = 0;
            this.toolTShowPassword.IsBalloon = true;
            this.toolTShowPassword.ReshowDelay = 100;
            this.toolTShowPassword.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTShowPassword.ToolTipTitle = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::control_elements_sena.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(20, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::control_elements_sena.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(20, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::control_elements_sena.Properties.Resources.background_network;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 373);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pControlBox);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Control";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pControlBox.ResumeLayout(false);
            this.pControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pControlBox;
        private System.Windows.Forms.Button btnMinimizeWindow;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.ToolTip toolTShowPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
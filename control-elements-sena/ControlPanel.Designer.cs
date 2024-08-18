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
            this.pControlBox = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMaximizeWindow = new System.Windows.Forms.Button();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.pControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pControlBox
            // 
            this.pControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.pControlBox.Controls.Add(this.lblTitle);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::control_elements_sena.Properties.Resources.sena_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1028, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Image = global::control_elements_sena.Properties.Resources.control_panel;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(3, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "        Panel de Control";
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
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pControlBox);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de Control";
            this.pControlBox.ResumeLayout(false);
            this.pControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControlBox;
        private System.Windows.Forms.Button btnMaximizeWindow;
        private System.Windows.Forms.Button btnMinimizeWindow;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace control_elements_sena
{
    partial class Entradas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pButtonsContainer = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTipNew = new System.Windows.Forms.ToolTip(this.components);
            this.hora_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_elemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres_propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacion_propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnOptions = new System.Windows.Forms.Button();
            this.toolTipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.balloonToolTip = new System.Windows.Forms.Timer(this.components);
            this.pButtonsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pButtonsContainer
            // 
            this.pButtonsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pButtonsContainer.AutoSize = true;
            this.pButtonsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.pButtonsContainer.Controls.Add(this.btnAdd);
            this.pButtonsContainer.Location = new System.Drawing.Point(726, 9);
            this.pButtonsContainer.Name = "pButtonsContainer";
            this.pButtonsContainer.Size = new System.Drawing.Size(44, 45);
            this.pButtonsContainer.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::control_elements_sena.Properties.Resources.personal_data;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 36);
            this.btnAdd.TabIndex = 0;
            this.toolTipNew.SetToolTip(this.btnAdd, "Registrar entrada");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolTipNew
            // 
            this.toolTipNew.AutomaticDelay = 0;
            this.toolTipNew.AutoPopDelay = 5000;
            this.toolTipNew.InitialDelay = 0;
            this.toolTipNew.IsBalloon = true;
            this.toolTipNew.ReshowDelay = 0;
            this.toolTipNew.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipNew.ToolTipTitle = "Entradas";
            // 
            // hora_salida
            // 
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hora_salida.DefaultCellStyle = dataGridViewCellStyle11;
            this.hora_salida.HeaderText = "Hora de salida";
            this.hora_salida.Name = "hora_salida";
            this.hora_salida.ReadOnly = true;
            // 
            // hora_entrada
            // 
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hora_entrada.DefaultCellStyle = dataGridViewCellStyle12;
            this.hora_entrada.HeaderText = "Hora de entrada";
            this.hora_entrada.Name = "hora_entrada";
            this.hora_entrada.ReadOnly = true;
            // 
            // serie
            // 
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serie.DefaultCellStyle = dataGridViewCellStyle13;
            this.serie.HeaderText = "Serie";
            this.serie.Name = "serie";
            this.serie.ReadOnly = true;
            // 
            // marca
            // 
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marca.DefaultCellStyle = dataGridViewCellStyle14;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // id_elemento
            // 
            this.id_elemento.HeaderText = "Id_elemento";
            this.id_elemento.Name = "id_elemento";
            this.id_elemento.ReadOnly = true;
            this.id_elemento.Visible = false;
            // 
            // nombres_propietario
            // 
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nombres_propietario.DefaultCellStyle = dataGridViewCellStyle15;
            this.nombres_propietario.HeaderText = "Nombres propietario";
            this.nombres_propietario.Name = "nombres_propietario";
            this.nombres_propietario.ReadOnly = true;
            // 
            // identificacion_propietario
            // 
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.identificacion_propietario.DefaultCellStyle = dataGridViewCellStyle16;
            this.identificacion_propietario.HeaderText = "Identificación propietario";
            this.identificacion_propietario.Name = "identificacion_propietario";
            this.identificacion_propietario.ReadOnly = true;
            // 
            // registrador
            // 
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registrador.DefaultCellStyle = dataGridViewCellStyle17;
            this.registrador.HeaderText = "Registrador";
            this.registrador.Name = "registrador";
            this.registrador.ReadOnly = true;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "Identificación registrador";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvDatos.ColumnHeadersHeight = 38;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_usuario,
            this.registrador,
            this.identificacion_propietario,
            this.nombres_propietario,
            this.id_elemento,
            this.marca,
            this.serie,
            this.hora_entrada,
            this.hora_salida});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.Location = new System.Drawing.Point(9, 9);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(782, 432);
            this.dgvDatos.TabIndex = 7;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Image = global::control_elements_sena.Properties.Resources.options;
            this.btnOptions.Location = new System.Drawing.Point(768, 12);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(23, 31);
            this.btnOptions.TabIndex = 3;
            this.toolTipHelper.SetToolTip(this.btnOptions, "Doble click en cualquier celda para registrar salida");
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // toolTipHelper
            // 
            this.toolTipHelper.AutomaticDelay = 0;
            this.toolTipHelper.AutoPopDelay = 2000;
            this.toolTipHelper.InitialDelay = 0;
            this.toolTipHelper.IsBalloon = true;
            this.toolTipHelper.ReshowDelay = 0;
            this.toolTipHelper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelper.ToolTipTitle = "Registrar salida";
            // 
            // balloonToolTip
            // 
            this.balloonToolTip.Interval = 1500;
            this.balloonToolTip.Tick += new System.EventHandler(this.balloonToolTip_Tick);
            // 
            // Entradas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.pButtonsContainer);
            this.Controls.Add(this.dgvDatos);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entradas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.pButtonsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pButtonsContainer;
        private System.Windows.Forms.ToolTip toolTipNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_elemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres_propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion_propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.ToolTip toolTipHelper;
        private System.Windows.Forms.Timer balloonToolTip;
    }
}
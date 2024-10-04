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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pButtonsContainer = new System.Windows.Forms.Panel();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTipNew = new System.Windows.Forms.ToolTip(this.components);
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.toolTipListAll = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHelper = new System.Windows.Forms.ToolTip(this.components);
            this.btnOptions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInitialDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbValue = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacion_propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres_propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_elemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargador_mouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formato3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pButtonsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pButtonsContainer
            // 
            this.pButtonsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pButtonsContainer.AutoSize = true;
            this.pButtonsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.pButtonsContainer.Controls.Add(this.btnListAll);
            this.pButtonsContainer.Controls.Add(this.btnAdd);
            this.pButtonsContainer.Location = new System.Drawing.Point(732, 98);
            this.pButtonsContainer.Name = "pButtonsContainer";
            this.pButtonsContainer.Size = new System.Drawing.Size(44, 83);
            this.pButtonsContainer.TabIndex = 8;
            // 
            // btnListAll
            // 
            this.btnListAll.BackColor = System.Drawing.Color.Transparent;
            this.btnListAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListAll.FlatAppearance.BorderSize = 0;
            this.btnListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAll.Image = global::control_elements_sena.Properties.Resources.check_list;
            this.btnListAll.Location = new System.Drawing.Point(3, 44);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(36, 36);
            this.btnListAll.TabIndex = 2;
            this.toolTipListAll.SetToolTip(this.btnListAll, "Listado completo de entradas");
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
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
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.cargador_mouse,
            this.formato3,
            this.hora_entrada,
            this.hora_salida});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDatos.EnableHeadersVisualStyles = false;
            this.dgvDatos.Location = new System.Drawing.Point(9, 98);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(782, 343);
            this.dgvDatos.TabIndex = 7;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // toolTipListAll
            // 
            this.toolTipListAll.AutomaticDelay = 0;
            this.toolTipListAll.AutoPopDelay = 5000;
            this.toolTipListAll.InitialDelay = 0;
            this.toolTipListAll.IsBalloon = true;
            this.toolTipListAll.ReshowDelay = 0;
            this.toolTipListAll.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipListAll.ToolTipTitle = "Mostrar todo";
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
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Image = global::control_elements_sena.Properties.Resources.options;
            this.btnOptions.Location = new System.Drawing.Point(775, 98);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(15, 38);
            this.btnOptions.TabIndex = 3;
            this.toolTipHelper.SetToolTip(this.btnOptions, "Doble click en cualquier celda para registrar salida");
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDateSearch);
            this.panel1.Controls.Add(this.dtpEndDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpInitialDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbValue);
            this.panel1.Location = new System.Drawing.Point(9, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 82);
            this.panel1.TabIndex = 12;
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnDateSearch.FlatAppearance.BorderSize = 0;
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateSearch.ForeColor = System.Drawing.Color.White;
            this.btnDateSearch.Location = new System.Drawing.Point(690, 47);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDateSearch.TabIndex = 18;
            this.btnDateSearch.Text = "Buscar";
            this.btnDateSearch.UseVisualStyleBackColor = false;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CustomFormat = "dddd dd/MM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(519, 49);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(155, 20);
            this.dtpEndDate.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(470, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hasta";
            // 
            // dtpInitialDate
            // 
            this.dtpInitialDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInitialDate.CustomFormat = "dddd dd/MM/yyyy";
            this.dtpInitialDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitialDate.Location = new System.Drawing.Point(309, 49);
            this.dtpInitialDate.Name = "dtpInitialDate";
            this.dtpInitialDate.Size = new System.Drawing.Size(155, 20);
            this.dtpInitialDate.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seleccionar entradas por rango de fecha desde:";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Activas",
            "Inactivas",
            "Todas"});
            this.cmbType.Location = new System.Drawing.Point(216, 12);
            this.cmbType.MaxLength = 3;
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(70, 21);
            this.cmbType.TabIndex = 13;
            this.cmbType.Text = "Activas";
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            this.cmbType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbType_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::control_elements_sena.Properties.Resources.loupe;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(743, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(22, 22);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(395, 10);
            this.txtSearch.MaxLength = 60;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(342, 25);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entradas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrar";
            // 
            // cmbValue
            // 
            this.cmbValue.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbValue.FormattingEnabled = true;
            this.cmbValue.Items.AddRange(new object[] {
            "5",
            "10",
            "25",
            "50",
            "100",
            "250",
            "500"});
            this.cmbValue.Location = new System.Drawing.Point(75, 12);
            this.cmbValue.MaxLength = 3;
            this.cmbValue.Name = "cmbValue";
            this.cmbValue.Size = new System.Drawing.Size(70, 21);
            this.cmbValue.TabIndex = 0;
            this.cmbValue.Text = "5";
            this.cmbValue.SelectedIndexChanged += new System.EventHandler(this.cmbValue_SelectedIndexChanged);
            this.cmbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbValue_KeyPress);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "Identificación registrador";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // registrador
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registrador.DefaultCellStyle = dataGridViewCellStyle3;
            this.registrador.HeaderText = "Registrador";
            this.registrador.Name = "registrador";
            this.registrador.ReadOnly = true;
            // 
            // identificacion_propietario
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.identificacion_propietario.DefaultCellStyle = dataGridViewCellStyle4;
            this.identificacion_propietario.HeaderText = "Identificación propietario";
            this.identificacion_propietario.Name = "identificacion_propietario";
            this.identificacion_propietario.ReadOnly = true;
            // 
            // nombres_propietario
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nombres_propietario.DefaultCellStyle = dataGridViewCellStyle5;
            this.nombres_propietario.HeaderText = "Nombres propietario";
            this.nombres_propietario.Name = "nombres_propietario";
            this.nombres_propietario.ReadOnly = true;
            // 
            // id_elemento
            // 
            this.id_elemento.HeaderText = "Id_elemento";
            this.id_elemento.Name = "id_elemento";
            this.id_elemento.ReadOnly = true;
            this.id_elemento.Visible = false;
            // 
            // marca
            // 
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marca.DefaultCellStyle = dataGridViewCellStyle6;
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // serie
            // 
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serie.DefaultCellStyle = dataGridViewCellStyle7;
            this.serie.HeaderText = "Serie";
            this.serie.Name = "serie";
            this.serie.ReadOnly = true;
            // 
            // cargador_mouse
            // 
            this.cargador_mouse.HeaderText = "Cargador y mouse";
            this.cargador_mouse.Name = "cargador_mouse";
            this.cargador_mouse.ReadOnly = true;
            // 
            // formato3
            // 
            this.formato3.HeaderText = "Formato 3";
            this.formato3.Name = "formato3";
            this.formato3.ReadOnly = true;
            // 
            // hora_entrada
            // 
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hora_entrada.DefaultCellStyle = dataGridViewCellStyle8;
            this.hora_entrada.HeaderText = "Hora de entrada";
            this.hora_entrada.Name = "hora_entrada";
            this.hora_entrada.ReadOnly = true;
            // 
            // hora_salida
            // 
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hora_salida.DefaultCellStyle = dataGridViewCellStyle9;
            this.hora_salida.HeaderText = "Hora de salida";
            this.hora_salida.Name = "hora_salida";
            this.hora_salida.ReadOnly = true;
            this.hora_salida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Entradas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
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
            this.Load += new System.EventHandler(this.Entradas_Load);
            this.pButtonsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pButtonsContainer;
        private System.Windows.Forms.ToolTip toolTipNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.ToolTip toolTipListAll;
        private System.Windows.Forms.ToolTip toolTipHelper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbValue;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DateTimePicker dtpInitialDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion_propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres_propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_elemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargador_mouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn formato3;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida;
    }
}
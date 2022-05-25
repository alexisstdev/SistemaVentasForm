namespace Sistema_de_Ventas
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIndex = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbxBuscar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.datosContainer = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudVenta = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCompra = new System.Windows.Forms.NumericUpDown();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.pct_Imagen = new System.Windows.Forms.PictureBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.ForeColor = System.Drawing.Color.Gray;
            this.lblIndex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIndex.Location = new System.Drawing.Point(270, 14);
            this.lblIndex.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(27, 22);
            this.lblIndex.TabIndex = 119;
            this.lblIndex.Text = "-1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Gray;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Gray;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar.IconSize = 30;
            this.btnBuscar.Location = new System.Drawing.Point(1061, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 30);
            this.btnBuscar.TabIndex = 117;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtBusqueda.Location = new System.Drawing.Point(820, 13);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(235, 24);
            this.txtBusqueda.TabIndex = 116;
            // 
            // cbxBuscar
            // 
            this.cbxBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.cbxBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxBuscar.FormattingEnabled = true;
            this.cbxBuscar.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Stock"});
            this.cbxBuscar.Location = new System.Drawing.Point(666, 10);
            this.cbxBuscar.Name = "cbxBuscar";
            this.cbxBuscar.Size = new System.Drawing.Size(148, 30);
            this.cbxBuscar.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(551, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 22);
            this.label9.TabIndex = 114;
            this.label9.Text = "Buscar por:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(343, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 22);
            this.label8.TabIndex = 113;
            this.label8.Text = "Lista de productos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(31, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 22);
            this.label7.TabIndex = 111;
            this.label7.Text = "Datos del producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEliminar.IconSize = 40;
            this.btnEliminar.Location = new System.Drawing.Point(39, 590);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(264, 49);
            this.btnEliminar.TabIndex = 110;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(251)))), ((int)(((byte)(227)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(189)))), ((int)(((byte)(129)))));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(189)))), ((int)(((byte)(129)))));
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLimpiar.IconSize = 40;
            this.btnLimpiar.Location = new System.Drawing.Point(39, 645);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(264, 49);
            this.btnLimpiar.TabIndex = 109;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGuardar.IconSize = 40;
            this.btnGuardar.Location = new System.Drawing.Point(39, 535);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(264, 49);
            this.btnGuardar.TabIndex = 108;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // datosContainer
            // 
            this.datosContainer.Controls.Add(this.label10);
            this.datosContainer.Controls.Add(this.nudStock);
            this.datosContainer.Controls.Add(this.label6);
            this.datosContainer.Controls.Add(this.nudVenta);
            this.datosContainer.Controls.Add(this.label5);
            this.datosContainer.Controls.Add(this.nudCompra);
            this.datosContainer.Controls.Add(this.txtID);
            this.datosContainer.Controls.Add(this.label4);
            this.datosContainer.Controls.Add(this.label1);
            this.datosContainer.Controls.Add(this.txtNombre);
            this.datosContainer.Location = new System.Drawing.Point(22, 47);
            this.datosContainer.Name = "datosContainer";
            this.datosContainer.Size = new System.Drawing.Size(294, 224);
            this.datosContainer.TabIndex = 118;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(13, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 84;
            this.label10.Text = "Stock";
            // 
            // nudStock
            // 
            this.nudStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.nudStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudStock.Location = new System.Drawing.Point(15, 190);
            this.nudStock.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(109, 26);
            this.nudStock.TabIndex = 83;
            this.nudStock.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(170, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 82;
            this.label6.Text = "Venta $";
            // 
            // nudVenta
            // 
            this.nudVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.nudVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudVenta.DecimalPlaces = 2;
            this.nudVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudVenta.Location = new System.Drawing.Point(174, 136);
            this.nudVenta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudVenta.Name = "nudVenta";
            this.nudVenta.Size = new System.Drawing.Size(107, 26);
            this.nudVenta.TabIndex = 81;
            this.nudVenta.Tag = "";
            this.nudVenta.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 80;
            this.label5.Text = "Compra $";
            // 
            // nudCompra
            // 
            this.nudCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.nudCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCompra.DecimalPlaces = 2;
            this.nudCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudCompra.Location = new System.Drawing.Point(16, 136);
            this.nudCompra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCompra.Name = "nudCompra";
            this.nudCompra.Size = new System.Drawing.Size(109, 26);
            this.nudCompra.TabIndex = 79;
            this.nudCompra.Tag = "";
            this.nudCompra.ThousandsSeparator = true;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtID.Location = new System.Drawing.Point(14, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(266, 23);
            this.txtID.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(11, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nombre del producto";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNombre.Location = new System.Drawing.Point(15, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(266, 23);
            this.txtNombre.TabIndex = 74;
            // 
            // lblImg
            // 
            this.lblImg.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblImg.ForeColor = System.Drawing.Color.Gray;
            this.lblImg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblImg.Location = new System.Drawing.Point(163, 497);
            this.lblImg.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(139, 20);
            this.lblImg.TabIndex = 123;
            this.lblImg.Text = "Imagen seleccionada";
            // 
            // pct_Imagen
            // 
            this.pct_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pct_Imagen.InitialImage = null;
            this.pct_Imagen.Location = new System.Drawing.Point(35, 277);
            this.pct_Imagen.Name = "pct_Imagen";
            this.pct_Imagen.Size = new System.Drawing.Size(267, 206);
            this.pct_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Imagen.TabIndex = 120;
            this.pct_Imagen.TabStop = false;
            this.pct_Imagen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSelectImg.Location = new System.Drawing.Point(39, 489);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(122, 32);
            this.btnSelectImg.TabIndex = 85;
            this.btnSelectImg.Text = "Subir imagen";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos JPEG (*.jpg)|*.jpg";
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            this.dtgProductos.AllowUserToDeleteRows = false;
            this.dtgProductos.AllowUserToResizeColumns = false;
            this.dtgProductos.AllowUserToResizeRows = false;
            this.dtgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgProductos.BackgroundColor = System.Drawing.Color.White;
            this.dtgProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 14F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 14F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductos.DefaultCellStyle = dataGridViewCellStyle26;
            this.dtgProductos.Location = new System.Drawing.Point(347, 55);
            this.dtgProductos.MultiSelect = false;
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 14F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(5);
            this.dtgProductos.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductos.ShowCellErrors = false;
            this.dtgProductos.ShowCellToolTips = false;
            this.dtgProductos.ShowEditingIcon = false;
            this.dtgProductos.ShowRowErrors = false;
            this.dtgProductos.Size = new System.Drawing.Size(765, 639);
            this.dtgProductos.TabIndex = 121;
            this.dtgProductos.SelectionChanged += new System.EventHandler(this.dtgProductos_SelectionChanged_1);
            // 
            // ID
            // 
            this.ID.FillWeight = 1.757324F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 35;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 10.38329F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.Width = 90;
            // 
            // Stock
            // 
            this.Stock.FillWeight = 9.07453F;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Stock.Width = 66;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.FillWeight = 7.346709F;
            this.PrecioCompra.HeaderText = "Precio de compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrecioCompra.Width = 162;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.FillWeight = 6.057422F;
            this.PrecioVenta.HeaderText = "Precio de venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrecioVenta.Width = 148;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 706);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pct_Imagen);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbxBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.datosContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.datosContainer.ResumeLayout(false);
            this.datosContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndex;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbxBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Panel datosContainer;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCompra;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pct_Imagen;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
    }
}
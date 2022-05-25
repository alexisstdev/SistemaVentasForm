namespace Sistema_de_Ventas
{
    partial class frmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrecioAPagar = new System.Windows.Forms.Label();
            this.txtIDCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgProductosCompra = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnFinalizarCompra = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.datosContainer = new System.Windows.Forms.Panel();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosCompra)).BeginInit();
            this.datosContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(489, 441);
            this.label6.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 22);
            this.label6.TabIndex = 142;
            this.label6.Text = "ID de compra";
            // 
            // lblPrecioAPagar
            // 
            this.lblPrecioAPagar.AutoSize = true;
            this.lblPrecioAPagar.ForeColor = System.Drawing.Color.Gray;
            this.lblPrecioAPagar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrecioAPagar.Location = new System.Drawing.Point(774, 428);
            this.lblPrecioAPagar.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.lblPrecioAPagar.Name = "lblPrecioAPagar";
            this.lblPrecioAPagar.Size = new System.Drawing.Size(152, 22);
            this.lblPrecioAPagar.TabIndex = 134;
            this.lblPrecioAPagar.Text = "Precio a pagar:";
            // 
            // txtIDCompra
            // 
            this.txtIDCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.txtIDCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCompra.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtIDCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtIDCompra.Location = new System.Drawing.Point(493, 466);
            this.txtIDCompra.Name = "txtIDCompra";
            this.txtIDCompra.Size = new System.Drawing.Size(266, 23);
            this.txtIDCompra.TabIndex = 143;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(341, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 22);
            this.label8.TabIndex = 140;
            this.label8.Text = "Lista de productos";
            // 
            // dtgProductosCompra
            // 
            this.dtgProductosCompra.AllowUserToAddRows = false;
            this.dtgProductosCompra.AllowUserToDeleteRows = false;
            this.dtgProductosCompra.AllowUserToResizeColumns = false;
            this.dtgProductosCompra.AllowUserToResizeRows = false;
            this.dtgProductosCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgProductosCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgProductosCompra.BackgroundColor = System.Drawing.Color.White;
            this.dtgProductosCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProductosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Proveedor,
            this.PrecioCompra,
            this.Cantidad,
            this.Subtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductosCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProductosCompra.Location = new System.Drawing.Point(346, 50);
            this.dtgProductosCompra.MultiSelect = false;
            this.dtgProductosCompra.Name = "dtgProductosCompra";
            this.dtgProductosCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.dtgProductosCompra.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProductosCompra.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dtgProductosCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductosCompra.ShowCellErrors = false;
            this.dtgProductosCompra.ShowCellToolTips = false;
            this.dtgProductosCompra.ShowEditingIcon = false;
            this.dtgProductosCompra.ShowRowErrors = false;
            this.dtgProductosCompra.Size = new System.Drawing.Size(698, 372);
            this.dtgProductosCompra.TabIndex = 139;
            this.dtgProductosCompra.SelectionChanged += new System.EventHandler(this.dtgProductosCompra_SelectionChanged);
            // 
            // ID
            // 
            this.ID.FillWeight = 1.757324F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 33;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 10.38329F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.Width = 79;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Proveedor.Width = 96;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.FillWeight = 7.346709F;
            this.PrecioCompra.HeaderText = "Precio de compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrecioCompra.Width = 139;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 9.07453F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 93;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Subtotal.Width = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(31, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 22);
            this.label7.TabIndex = 138;
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
            this.btnEliminar.Location = new System.Drawing.Point(35, 453);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(266, 48);
            this.btnEliminar.TabIndex = 137;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(251)))), ((int)(((byte)(227)))));
            this.btnFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCompra.FlatAppearance.BorderSize = 2;
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(189)))), ((int)(((byte)(129)))));
            this.btnFinalizarCompra.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnFinalizarCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(189)))), ((int)(((byte)(129)))));
            this.btnFinalizarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinalizarCompra.IconSize = 40;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(778, 453);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(266, 48);
            this.btnFinalizarCompra.TabIndex = 136;
            this.btnFinalizarCompra.Text = "Finalizar compra";
            this.btnFinalizarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAgregar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 40;
            this.btnAgregar.Location = new System.Drawing.Point(35, 399);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(266, 48);
            this.btnAgregar.TabIndex = 135;
            this.btnAgregar.Text = "Agregar producto";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // datosContainer
            // 
            this.datosContainer.Controls.Add(this.cbxID);
            this.datosContainer.Controls.Add(this.txtProveedor);
            this.datosContainer.Controls.Add(this.label3);
            this.datosContainer.Controls.Add(this.label2);
            this.datosContainer.Controls.Add(this.nudPrecioVenta);
            this.datosContainer.Controls.Add(this.label10);
            this.datosContainer.Controls.Add(this.nudCantidad);
            this.datosContainer.Controls.Add(this.label5);
            this.datosContainer.Controls.Add(this.nudPrecioCompra);
            this.datosContainer.Controls.Add(this.label4);
            this.datosContainer.Controls.Add(this.label1);
            this.datosContainer.Controls.Add(this.txtNombre);
            this.datosContainer.Location = new System.Drawing.Point(21, 50);
            this.datosContainer.Name = "datosContainer";
            this.datosContainer.Size = new System.Drawing.Size(294, 291);
            this.datosContainer.TabIndex = 141;
            // 
            // cbxID
            // 
            this.cbxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.cbxID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(15, 34);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(266, 30);
            this.cbxID.TabIndex = 131;
            this.cbxID.SelectedIndexChanged += new System.EventHandler(this.cbxID_SelectedIndexChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProveedor.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtProveedor.Location = new System.Drawing.Point(14, 143);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(266, 23);
            this.txtProveedor.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 87;
            this.label3.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 86;
            this.label2.Text = "Precio venta";
            // 
            // nudPrecioVenta
            // 
            this.nudPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.nudPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPrecioVenta.DecimalPlaces = 2;
            this.nudPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudPrecioVenta.Location = new System.Drawing.Point(14, 248);
            this.nudPrecioVenta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecioVenta.Name = "nudPrecioVenta";
            this.nudPrecioVenta.Size = new System.Drawing.Size(109, 26);
            this.nudPrecioVenta.TabIndex = 85;
            this.nudPrecioVenta.Tag = "";
            this.nudPrecioVenta.ThousandsSeparator = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(167, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 22);
            this.label10.TabIndex = 84;
            this.label10.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudCantidad.Location = new System.Drawing.Point(171, 194);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(109, 26);
            this.nudCantidad.TabIndex = 83;
            this.nudCantidad.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(10, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 22);
            this.label5.TabIndex = 80;
            this.label5.Text = "Precio compra";
            // 
            // nudPrecioCompra
            // 
            this.nudPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.nudPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPrecioCompra.DecimalPlaces = 2;
            this.nudPrecioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.nudPrecioCompra.Location = new System.Drawing.Point(14, 194);
            this.nudPrecioCompra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecioCompra.Name = "nudPrecioCompra";
            this.nudPrecioCompra.Size = new System.Drawing.Size(109, 26);
            this.nudPrecioCompra.TabIndex = 79;
            this.nudPrecioCompra.Tag = "";
            this.nudPrecioCompra.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = "ID de producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(10, 67);
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
            this.txtNombre.Location = new System.Drawing.Point(15, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(266, 23);
            this.txtNombre.TabIndex = 74;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 518);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPrecioAPagar);
            this.Controls.Add(this.txtIDCompra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgProductosCompra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.datosContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosCompra)).EndInit();
            this.datosContainer.ResumeLayout(false);
            this.datosContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrecioAPagar;
        private System.Windows.Forms.TextBox txtIDCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgProductosCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnFinalizarCompra;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Panel datosContainer;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrecioVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrecioCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
    }
}
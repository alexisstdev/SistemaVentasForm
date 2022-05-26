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
            this.label7 = new System.Windows.Forms.Label();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.datosContainer = new System.Windows.Forms.Panel();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgProductosCompra = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizarCompra = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.datosContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(525, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 142;
            this.label6.Text = "ID de compra";
            // 
            // lblPrecioAPagar
            // 
            this.lblPrecioAPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioAPagar.AutoSize = true;
            this.lblPrecioAPagar.ForeColor = System.Drawing.Color.Gray;
            this.lblPrecioAPagar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrecioAPagar.Location = new System.Drawing.Point(751, 383);
            this.lblPrecioAPagar.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.lblPrecioAPagar.Name = "lblPrecioAPagar";
            this.lblPrecioAPagar.Size = new System.Drawing.Size(112, 21);
            this.lblPrecioAPagar.TabIndex = 134;
            this.lblPrecioAPagar.Text = "Precio a pagar:";
            // 
            // txtIDCompra
            // 
            this.txtIDCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.txtIDCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCompra.ForeColor = System.Drawing.Color.DimGray;
            this.txtIDCompra.Location = new System.Drawing.Point(529, 421);
            this.txtIDCompra.Name = "txtIDCompra";
            this.txtIDCompra.Size = new System.Drawing.Size(218, 22);
            this.txtIDCompra.TabIndex = 143;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(19, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 21);
            this.label8.TabIndex = 140;
            this.label8.Text = "Productos agregados al carrito";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(22, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 21);
            this.label7.TabIndex = 138;
            this.label7.Text = "Datos del producto";
            // 
            // cbxID
            // 
            this.cbxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.cbxID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxID.ForeColor = System.Drawing.Color.DimGray;
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(25, 90);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(218, 29);
            this.cbxID.TabIndex = 131;
            this.cbxID.SelectedIndexChanged += new System.EventHandler(this.cbxID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(25, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 86;
            this.label2.Text = "Precio venta";
            // 
            // nudPrecioVenta
            // 
            this.nudPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.nudPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPrecioVenta.DecimalPlaces = 2;
            this.nudPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecioVenta.ForeColor = System.Drawing.Color.DimGray;
            this.nudPrecioVenta.Location = new System.Drawing.Point(25, 307);
            this.nudPrecioVenta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecioVenta.Name = "nudPrecioVenta";
            this.nudPrecioVenta.Size = new System.Drawing.Size(97, 25);
            this.nudPrecioVenta.TabIndex = 85;
            this.nudPrecioVenta.Tag = "";
            this.nudPrecioVenta.ThousandsSeparator = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(25, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 84;
            this.label10.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(25, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 80;
            this.label5.Text = "Precio compra";
            // 
            // nudPrecioCompra
            // 
            this.nudPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.nudPrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudPrecioCompra.DecimalPlaces = 2;
            this.nudPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecioCompra.ForeColor = System.Drawing.Color.DimGray;
            this.nudPrecioCompra.Location = new System.Drawing.Point(25, 199);
            this.nudPrecioCompra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecioCompra.Name = "nudPrecioCompra";
            this.nudPrecioCompra.Size = new System.Drawing.Size(89, 25);
            this.nudPrecioCompra.TabIndex = 79;
            this.nudPrecioCompra.Tag = "";
            this.nudPrecioCompra.ThousandsSeparator = true;
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.nudCantidad.Location = new System.Drawing.Point(25, 253);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(89, 25);
            this.nudCantidad.TabIndex = 83;
            this.nudCantidad.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(25, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 71;
            this.label4.Text = "ID de producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(25, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(19, 0, 19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nombre del producto";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(25, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 22);
            this.txtNombre.TabIndex = 74;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos JPEG (*.jpg)|*.jpg";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPrecioAPagar);
            this.panel3.Controls.Add(this.btnFinalizarCompra);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.txtIDCompra);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 474);
            this.panel3.TabIndex = 147;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(276, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 36);
            this.panel2.TabIndex = 128;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnEliminar);
            this.panel5.Controls.Add(this.btnGuardar);
            this.panel5.Controls.Add(this.datosContainer);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 474);
            this.panel5.TabIndex = 127;
            // 
            // datosContainer
            // 
            this.datosContainer.Controls.Add(this.btnLimpiar);
            this.datosContainer.Controls.Add(this.label7);
            this.datosContainer.Controls.Add(this.cbxID);
            this.datosContainer.Controls.Add(this.nudPrecioVenta);
            this.datosContainer.Controls.Add(this.label2);
            this.datosContainer.Controls.Add(this.txtNombre);
            this.datosContainer.Controls.Add(this.label1);
            this.datosContainer.Controls.Add(this.label10);
            this.datosContainer.Controls.Add(this.label4);
            this.datosContainer.Controls.Add(this.label5);
            this.datosContainer.Controls.Add(this.nudCantidad);
            this.datosContainer.Controls.Add(this.nudPrecioCompra);
            this.datosContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.datosContainer.Location = new System.Drawing.Point(0, 0);
            this.datosContainer.Name = "datosContainer";
            this.datosContainer.Size = new System.Drawing.Size(276, 355);
            this.datosContainer.TabIndex = 133;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEliminar.IconSize = 20;
            this.btnEliminar.Location = new System.Drawing.Point(26, 407);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 36);
            this.btnEliminar.TabIndex = 149;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(170)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.Location = new System.Drawing.Point(137, 407);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 36);
            this.btnGuardar.TabIndex = 148;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgProductosCompra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(276, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 309);
            this.panel1.TabIndex = 144;
            // 
            // dtgProductosCompra
            // 
            this.dtgProductosCompra.AllowUserToAddRows = false;
            this.dtgProductosCompra.AllowUserToDeleteRows = false;
            this.dtgProductosCompra.AllowUserToResizeColumns = false;
            this.dtgProductosCompra.AllowUserToResizeRows = false;
            this.dtgProductosCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProductosCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductosCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgProductosCompra.BackgroundColor = System.Drawing.Color.White;
            this.dtgProductosCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProductosCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtgProductosCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProductosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Correo,
            this.Cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductosCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProductosCompra.EnableHeadersVisualStyles = false;
            this.dtgProductosCompra.GridColor = System.Drawing.Color.White;
            this.dtgProductosCompra.Location = new System.Drawing.Point(0, 0);
            this.dtgProductosCompra.Margin = new System.Windows.Forms.Padding(30);
            this.dtgProductosCompra.MultiSelect = false;
            this.dtgProductosCompra.Name = "dtgProductosCompra";
            this.dtgProductosCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProductosCompra.RowHeadersVisible = false;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.dtgProductosCompra.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProductosCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductosCompra.ShowCellErrors = false;
            this.dtgProductosCompra.ShowCellToolTips = false;
            this.dtgProductosCompra.ShowEditingIcon = false;
            this.dtgProductosCompra.ShowRowErrors = false;
            this.dtgProductosCompra.Size = new System.Drawing.Size(657, 309);
            this.dtgProductosCompra.TabIndex = 132;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Precio de compra";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Subtotal";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(189)))), ((int)(((byte)(129)))));
            this.btnFinalizarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarCompra.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnFinalizarCompra.IconColor = System.Drawing.Color.White;
            this.btnFinalizarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinalizarCompra.IconSize = 20;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(755, 407);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(178, 36);
            this.btnFinalizarCompra.TabIndex = 150;
            this.btnFinalizarCompra.Text = "Finalizar compra";
            this.btnFinalizarCompra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(189)))), ((int)(((byte)(129)))));
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(87)))), ((int)(((byte)(170)))));
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLimpiar.IconSize = 25;
            this.btnLimpiar.Location = new System.Drawing.Point(203, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(40, 32);
            this.btnLimpiar.TabIndex = 139;
            this.btnLimpiar.Text = "  dsa";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 474);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.datosContainer.ResumeLayout(false);
            this.datosContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrecioAPagar;
        private System.Windows.Forms.TextBox txtIDCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPrecioVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrecioCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel datosContainer;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnFinalizarCompra;
        private System.Windows.Forms.DataGridView dtgProductosCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}
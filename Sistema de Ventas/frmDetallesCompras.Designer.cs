namespace Sistema_de_Ventas
{
    partial class frmDetallesCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnDescargarPDF = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgProductosComprados = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosComprados)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxID
            // 
            this.cbxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.cbxID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxID.FormattingEnabled = true;
            this.cbxID.ItemHeight = 21;
            this.cbxID.Location = new System.Drawing.Point(155, 15);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(242, 29);
            this.cbxID.TabIndex = 143;
            this.cbxID.SelectedIndexChanged += new System.EventHandler(this.cbxID_SelectedIndexChanged);
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblMontoTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblMontoTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMontoTotal.Location = new System.Drawing.Point(673, 402);
            this.lblMontoTotal.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(126, 42);
            this.lblMontoTotal.TabIndex = 142;
            this.lblMontoTotal.Text = "Total pagado :\r\n$2000";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Gray;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Gray;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.Location = new System.Drawing.Point(414, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 29);
            this.btnBuscar.TabIndex = 141;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(17, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 140;
            this.label9.Text = "ID de compra:";
            // 
            // lblDatos
            // 
            this.lblDatos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDatos.ForeColor = System.Drawing.Color.Gray;
            this.lblDatos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDatos.Location = new System.Drawing.Point(17, 82);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(265, 74);
            this.lblDatos.TabIndex = 139;
            this.lblDatos.Text = "Datos de la compra\r\n\r\n\r\n";
            // 
            // btnDescargarPDF
            // 
            this.btnDescargarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnDescargarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargarPDF.FlatAppearance.BorderSize = 2;
            this.btnDescargarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargarPDF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDescargarPDF.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnDescargarPDF.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDescargarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargarPDF.IconSize = 40;
            this.btnDescargarPDF.Location = new System.Drawing.Point(676, 472);
            this.btnDescargarPDF.Name = "btnDescargarPDF";
            this.btnDescargarPDF.Size = new System.Drawing.Size(242, 46);
            this.btnDescargarPDF.TabIndex = 138;
            this.btnDescargarPDF.Text = "Descargar PDF";
            this.btnDescargarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDescargarPDF.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(21, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 21);
            this.label8.TabIndex = 137;
            this.label8.Text = "Lista de productos comprados";
            // 
            // dtgProductosComprados
            // 
            this.dtgProductosComprados.AllowUserToAddRows = false;
            this.dtgProductosComprados.AllowUserToDeleteRows = false;
            this.dtgProductosComprados.AllowUserToResizeColumns = false;
            this.dtgProductosComprados.AllowUserToResizeRows = false;
            this.dtgProductosComprados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgProductosComprados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgProductosComprados.BackgroundColor = System.Drawing.Color.White;
            this.dtgProductosComprados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosComprados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProductosComprados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosComprados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Nombre,
            this.PrecioCompra,
            this.Cantidad,
            this.Subtotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProductosComprados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgProductosComprados.Location = new System.Drawing.Point(25, 212);
            this.dtgProductosComprados.MultiSelect = false;
            this.dtgProductosComprados.Name = "dtgProductosComprados";
            this.dtgProductosComprados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductosComprados.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.dtgProductosComprados.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgProductosComprados.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dtgProductosComprados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductosComprados.ShowCellErrors = false;
            this.dtgProductosComprados.ShowCellToolTips = false;
            this.dtgProductosComprados.ShowEditingIcon = false;
            this.dtgProductosComprados.ShowRowErrors = false;
            this.dtgProductosComprados.Size = new System.Drawing.Size(625, 305);
            this.dtgProductosComprados.TabIndex = 136;
            // 
            // Producto
            // 
            this.Producto.FillWeight = 1.757324F;
            this.Producto.HeaderText = "ID";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Producto.Width = 33;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre.Width = 79;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.FillWeight = 10.38329F;
            this.PrecioCompra.HeaderText = "Precio de compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrecioCompra.Width = 139;
            // 
            // Cantidad
            // 
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
            // frmDetallesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 544);
            this.Controls.Add(this.cbxID);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnDescargarPDF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgProductosComprados);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmDetallesCompras";
            this.Text = "DetallesCompras";
            this.Load += new System.EventHandler(this.frmDetallesCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosComprados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.Label lblMontoTotal;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDatos;
        private FontAwesome.Sharp.IconButton btnDescargarPDF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgProductosComprados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}
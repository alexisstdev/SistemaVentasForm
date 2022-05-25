namespace Sistema_de_Ventas
{
    partial class Inicio
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
            this.Titulo = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.container = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = false;
            this.Titulo.BackColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(218, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Titulo.Size = new System.Drawing.Size(1126, 57);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "menuStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVentas,
            this.menuClientes,
            this.menuCompras,
            this.menuUsuarios,
            this.menuProductos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(218, 711);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuVentas
            // 
            this.menuVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.menuVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Size = new System.Drawing.Size(211, 52);
            this.menuVentas.Text = "Ventas";
            this.menuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuVentas.Click += new System.EventHandler(this.menuVentas_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.menuClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(211, 52);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.menuCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.menuCompras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(211, 52);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuCompras.Click += new System.EventHandler(this.menuCompras_Click);
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.menuUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.menuUsuarios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(211, 52);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click_1);
            // 
            // menuProductos
            // 
            this.menuProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.menuProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuProductos.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.menuProductos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.menuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(211, 52);
            this.menuProductos.Text = "Productos";
            this.menuProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuProductos.Click += new System.EventHandler(this.menuProductos_Click);
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUser.ForeColor = System.Drawing.Color.Gray;
            this.lblUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUser.Location = new System.Drawing.Point(7, 568);
            this.lblUser.Margin = new System.Windows.Forms.Padding(23, 0, 23, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(211, 67);
            this.lblUser.TabIndex = 69;
            this.lblUser.Text = "Admin";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(131)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 60;
            this.iconPictureBox1.Location = new System.Drawing.Point(86, 505);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(60, 60);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 70;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // container
            // 
            this.container.AutoSize = true;
            this.container.Location = new System.Drawing.Point(221, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1290, 711);
            this.container.TabIndex = 71;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 711);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.container);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuProductos;
        private System.Windows.Forms.Label lblUser;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel container;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
    }
}


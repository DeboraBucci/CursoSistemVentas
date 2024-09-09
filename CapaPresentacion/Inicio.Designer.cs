namespace CapaPresentacion
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.iMenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.iMenuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.iMenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.iMenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.iMenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.iMenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.iMenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.iMenuAcerca = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iMenuUsuarios,
            this.iMenuMantenedor,
            this.iMenuVentas,
            this.iMenuCompras,
            this.iMenuClientes,
            this.iMenuProveedores,
            this.iMenuReportes,
            this.iMenuAcerca});
            this.menu.Location = new System.Drawing.Point(0, 48);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1100, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // iMenuUsuarios
            // 
            this.iMenuUsuarios.AutoSize = false;
            this.iMenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.iMenuUsuarios.IconColor = System.Drawing.Color.Black;
            this.iMenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iMenuUsuarios.IconSize = 50;
            this.iMenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iMenuUsuarios.Name = "iMenuUsuarios";
            this.iMenuUsuarios.Size = new System.Drawing.Size(122, 69);
            this.iMenuUsuarios.Text = "Usuarios";
            this.iMenuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iMenuMantenedor
            // 
            this.iMenuMantenedor.AutoSize = false;
            this.iMenuMantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.iMenuMantenedor.IconColor = System.Drawing.Color.Black;
            this.iMenuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iMenuMantenedor.IconSize = 50;
            this.iMenuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iMenuMantenedor.Name = "iMenuMantenedor";
            this.iMenuMantenedor.Size = new System.Drawing.Size(122, 69);
            this.iMenuMantenedor.Text = "Mantenedor";
            this.iMenuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iMenuVentas
            // 
            this.iMenuVentas.AutoSize = false;
            this.iMenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iMenuVentas.IconColor = System.Drawing.Color.Black;
            this.iMenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iMenuVentas.IconSize = 50;
            this.iMenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iMenuVentas.Name = "iMenuVentas";
            this.iMenuVentas.Size = new System.Drawing.Size(122, 69);
            this.iMenuVentas.Text = "Ventas";
            this.iMenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iMenuCompras
            // 
            this.iMenuCompras.AutoSize = false;
            this.iMenuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.iMenuCompras.IconColor = System.Drawing.Color.Black;
            this.iMenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iMenuCompras.IconSize = 50;
            this.iMenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iMenuCompras.Name = "iMenuCompras";
            this.iMenuCompras.Size = new System.Drawing.Size(122, 69);
            this.iMenuCompras.Text = "Compras";
            this.iMenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iMenuCompras.Click += new System.EventHandler(this.iconMenuItem5_Click);
            // 
            // iMenuClientes
            // 
            this.iMenuClientes.AutoSize = false;
            this.iMenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.iMenuClientes.IconColor = System.Drawing.Color.Black;
            this.iMenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iMenuClientes.IconSize = 50;
            this.iMenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iMenuClientes.Name = "iMenuClientes";
            this.iMenuClientes.Size = new System.Drawing.Size(122, 69);
            this.iMenuClientes.Text = "Clientes";
            this.iMenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iMenuProveedores
            // 
            this.iMenuProveedores.AutoSize = false;
            this.iMenuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iMenuProveedores.IconColor = System.Drawing.Color.Black;
            this.iMenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iMenuProveedores.IconSize = 50;
            this.iMenuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iMenuProveedores.Name = "iMenuProveedores";
            this.iMenuProveedores.Size = new System.Drawing.Size(122, 69);
            this.iMenuProveedores.Text = "Proveedores";
            this.iMenuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iMenuReportes
            // 
            this.iMenuReportes.AutoSize = false;
            this.iMenuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iMenuReportes.IconColor = System.Drawing.Color.Black;
            this.iMenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iMenuReportes.IconSize = 50;
            this.iMenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iMenuReportes.Name = "iMenuReportes";
            this.iMenuReportes.Size = new System.Drawing.Size(122, 69);
            this.iMenuReportes.Text = "Reportes";
            this.iMenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iMenuAcerca
            // 
            this.iMenuAcerca.AutoSize = false;
            this.iMenuAcerca.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iMenuAcerca.IconColor = System.Drawing.Color.Black;
            this.iMenuAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iMenuAcerca.IconSize = 50;
            this.iMenuAcerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iMenuAcerca.Name = "iMenuAcerca";
            this.iMenuAcerca.Size = new System.Drawing.Size(122, 69);
            this.iMenuAcerca.Text = "Acerca de";
            this.iMenuAcerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1100, 48);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 121);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1100, 329);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem iMenuAcerca;
        private FontAwesome.Sharp.IconMenuItem iMenuUsuarios;
        private FontAwesome.Sharp.IconMenuItem iMenuMantenedor;
        private FontAwesome.Sharp.IconMenuItem iMenuVentas;
        private FontAwesome.Sharp.IconMenuItem iMenuCompras;
        private FontAwesome.Sharp.IconMenuItem iMenuProveedores;
        private FontAwesome.Sharp.IconMenuItem iMenuClientes;
        private FontAwesome.Sharp.IconMenuItem iMenuReportes;
        private System.Windows.Forms.Panel contenedor;
    }
}


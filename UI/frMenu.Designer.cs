namespace UI
{
    partial class frMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMenu));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripVendedor = new System.Windows.Forms.ToolStripDropDownButton();
            this.tomarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarOrdenDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónDeNegocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProduccion = new System.Windows.Forms.ToolStripDropDownButton();
            this.supervisarOrdenesDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cumplirOrdenDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarOrdenDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDespachos = new System.Windows.Forms.ToolStripDropDownButton();
            this.cumplirOrdenDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gestorDePermisosDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripArchivo,
            this.toolStripVendedor,
            this.toolStripProduccion,
            this.toolStripDespachos,
            this.toolStripSplitButton1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripMenu.Size = new System.Drawing.Size(800, 44);
            this.toolStripMenu.TabIndex = 1;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripArchivo
            // 
            this.toolStripArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripArchivo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripArchivo.Image")));
            this.toolStripArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripArchivo.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripArchivo.Name = "toolStripArchivo";
            this.toolStripArchivo.Size = new System.Drawing.Size(73, 24);
            this.toolStripArchivo.Text = "Archivo";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripVendedor
            // 
            this.toolStripVendedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tomarPedidoToolStripMenuItem,
            this.generarFacturaToolStripMenuItem,
            this.verOrdenesToolStripMenuItem,
            this.generarOrdenDeEntregaToolStripMenuItem,
            this.informaciónDeNegocioToolStripMenuItem,
            this.gestionarClientesToolStripMenuItem});
            this.toolStripVendedor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripVendedor.Image")));
            this.toolStripVendedor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripVendedor.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripVendedor.Name = "toolStripVendedor";
            this.toolStripVendedor.Size = new System.Drawing.Size(86, 24);
            this.toolStripVendedor.Text = "Ventas";
            // 
            // tomarPedidoToolStripMenuItem
            // 
            this.tomarPedidoToolStripMenuItem.Name = "tomarPedidoToolStripMenuItem";
            this.tomarPedidoToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.tomarPedidoToolStripMenuItem.Text = "Gestionar Orden";
            this.tomarPedidoToolStripMenuItem.Click += new System.EventHandler(this.tomarPedidoToolStripMenuItem_Click);
            // 
            // generarFacturaToolStripMenuItem
            // 
            this.generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            this.generarFacturaToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.generarFacturaToolStripMenuItem.Text = "Generar factura";
            this.generarFacturaToolStripMenuItem.Click += new System.EventHandler(this.generarFacturaToolStripMenuItem_Click);
            // 
            // verOrdenesToolStripMenuItem
            // 
            this.verOrdenesToolStripMenuItem.Name = "verOrdenesToolStripMenuItem";
            this.verOrdenesToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.verOrdenesToolStripMenuItem.Text = "Ver Ordenes";
            this.verOrdenesToolStripMenuItem.Click += new System.EventHandler(this.verOrdenesToolStripMenuItem_Click);
            // 
            // generarOrdenDeEntregaToolStripMenuItem
            // 
            this.generarOrdenDeEntregaToolStripMenuItem.Name = "generarOrdenDeEntregaToolStripMenuItem";
            this.generarOrdenDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.generarOrdenDeEntregaToolStripMenuItem.Text = "Generar orden de entrega";
            this.generarOrdenDeEntregaToolStripMenuItem.Click += new System.EventHandler(this.generarOrdenDeEntregaToolStripMenuItem_Click);
            // 
            // informaciónDeNegocioToolStripMenuItem
            // 
            this.informaciónDeNegocioToolStripMenuItem.Name = "informaciónDeNegocioToolStripMenuItem";
            this.informaciónDeNegocioToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.informaciónDeNegocioToolStripMenuItem.Text = "Dashboard";
            this.informaciónDeNegocioToolStripMenuItem.Click += new System.EventHandler(this.informaciónDeNegocioToolStripMenuItem_Click);
            // 
            // gestionarClientesToolStripMenuItem
            // 
            this.gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            this.gestionarClientesToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.gestionarClientesToolStripMenuItem.Text = "Registrar clientes";
            this.gestionarClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionarClientesToolStripMenuItem_Click);
            // 
            // toolStripProduccion
            // 
            this.toolStripProduccion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supervisarOrdenesDeProduccionToolStripMenuItem,
            this.cumplirOrdenDeProduccionToolStripMenuItem,
            this.generarOrdenDeProduccionToolStripMenuItem});
            this.toolStripProduccion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripProduccion.Image")));
            this.toolStripProduccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripProduccion.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripProduccion.Name = "toolStripProduccion";
            this.toolStripProduccion.Size = new System.Drawing.Size(117, 24);
            this.toolStripProduccion.Text = "Produccion";
            // 
            // supervisarOrdenesDeProduccionToolStripMenuItem
            // 
            this.supervisarOrdenesDeProduccionToolStripMenuItem.Name = "supervisarOrdenesDeProduccionToolStripMenuItem";
            this.supervisarOrdenesDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.supervisarOrdenesDeProduccionToolStripMenuItem.Text = "Supervisar ordenes de produccion";
            this.supervisarOrdenesDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.supervisarOrdenesDeProduccionToolStripMenuItem_Click);
            // 
            // cumplirOrdenDeProduccionToolStripMenuItem
            // 
            this.cumplirOrdenDeProduccionToolStripMenuItem.Name = "cumplirOrdenDeProduccionToolStripMenuItem";
            this.cumplirOrdenDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.cumplirOrdenDeProduccionToolStripMenuItem.Text = "Realizar orden de produccion";
            this.cumplirOrdenDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.cumplirOrdenDeProduccionToolStripMenuItem_Click);
            // 
            // generarOrdenDeProduccionToolStripMenuItem
            // 
            this.generarOrdenDeProduccionToolStripMenuItem.Name = "generarOrdenDeProduccionToolStripMenuItem";
            this.generarOrdenDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(317, 26);
            this.generarOrdenDeProduccionToolStripMenuItem.Text = "Generar orden de produccion";
            this.generarOrdenDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.generarOrdenDeProduccionToolStripMenuItem_Click);
            // 
            // toolStripDespachos
            // 
            this.toolStripDespachos.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.toolStripDespachos.AutoToolTip = false;
            this.toolStripDespachos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cumplirOrdenDeEntregaToolStripMenuItem});
            this.toolStripDespachos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDespachos.Image")));
            this.toolStripDespachos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDespachos.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripDespachos.Name = "toolStripDespachos";
            this.toolStripDespachos.Size = new System.Drawing.Size(100, 24);
            this.toolStripDespachos.Text = "Entregas";
            // 
            // cumplirOrdenDeEntregaToolStripMenuItem
            // 
            this.cumplirOrdenDeEntregaToolStripMenuItem.Name = "cumplirOrdenDeEntregaToolStripMenuItem";
            this.cumplirOrdenDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.cumplirOrdenDeEntregaToolStripMenuItem.Text = "Gestionar orden de entrega";
            this.cumplirOrdenDeEntregaToolStripMenuItem.Click += new System.EventHandler(this.cumplirOrdenDeEntregaToolStripMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestorDePermisosDeUsuarioToolStripMenuItem,
            this.gestorDeUsuariosToolStripMenuItem,
            this.backupToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(131, 24);
            this.toolStripSplitButton1.Text = "Admistracion";
            // 
            // gestorDePermisosDeUsuarioToolStripMenuItem
            // 
            this.gestorDePermisosDeUsuarioToolStripMenuItem.Name = "gestorDePermisosDeUsuarioToolStripMenuItem";
            this.gestorDePermisosDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.gestorDePermisosDeUsuarioToolStripMenuItem.Text = "Gestor de permisos de usuario";
            this.gestorDePermisosDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.gestorDePermisosDeUsuarioToolStripMenuItem_Click);
            // 
            // gestorDeUsuariosToolStripMenuItem
            // 
            this.gestorDeUsuariosToolStripMenuItem.Name = "gestorDeUsuariosToolStripMenuItem";
            this.gestorDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.gestorDeUsuariosToolStripMenuItem.Text = "Gestor de usuarios";
            this.gestorDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestorDeUsuariosToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // frMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripMenu);
            this.IsMdiContainer = true;
            this.Name = "frMenu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frMenu_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton toolStripArchivo;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripVendedor;
        private System.Windows.Forms.ToolStripMenuItem tomarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verOrdenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarOrdenDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripProduccion;
        private System.Windows.Forms.ToolStripMenuItem supervisarOrdenesDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumplirOrdenDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarOrdenDeProduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDespachos;
        private System.Windows.Forms.ToolStripMenuItem cumplirOrdenDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem gestorDePermisosDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónDeNegocioToolStripMenuItem;
    }
}


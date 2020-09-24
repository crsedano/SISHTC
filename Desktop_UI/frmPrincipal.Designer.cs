namespace Desktop_UI
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.subMenuAdministracion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnPrivilegios = new FontAwesome.Sharp.IconButton();
            this.btnFacturacion = new FontAwesome.Sharp.IconButton();
            this.btnCorrelativos = new FontAwesome.Sharp.IconButton();
            this.btnSucursales = new FontAwesome.Sharp.IconButton();
            this.btnListaPrecios = new FontAwesome.Sharp.IconButton();
            this.btnAlmacen = new FontAwesome.Sharp.IconButton();
            this.btnAdministracion = new FontAwesome.Sharp.IconButton();
            this.subMenuInformes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReporteVentas = new FontAwesome.Sharp.IconButton();
            this.btnPromasVendidos = new FontAwesome.Sharp.IconButton();
            this.btnKardex = new FontAwesome.Sharp.IconButton();
            this.btnLibVentas = new FontAwesome.Sharp.IconButton();
            this.btnLibCompras = new FontAwesome.Sharp.IconButton();
            this.btnInformes = new FontAwesome.Sharp.IconButton();
            this.subMenuLogistica = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCatalogoProductos = new FontAwesome.Sharp.IconButton();
            this.btnOC = new FontAwesome.Sharp.IconButton();
            this.btnDevOC = new FontAwesome.Sharp.IconButton();
            this.btnTraspaso = new FontAwesome.Sharp.IconButton();
            this.btnLogistica = new FontAwesome.Sharp.IconButton();
            this.subMenuDash = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnCotizacion = new FontAwesome.Sharp.IconButton();
            this.btnAnulacion = new FontAwesome.Sharp.IconButton();
            this.btnNC = new FontAwesome.Sharp.IconButton();
            this.btnReimpresion = new FontAwesome.Sharp.IconButton();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.btnOperacion = new FontAwesome.Sharp.IconButton();
            this.btnDashBoard = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tolFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contenedor = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2.SuspendLayout();
            this.Menu.SuspendLayout();
            this.subMenuAdministracion.SuspendLayout();
            this.subMenuInformes.SuspendLayout();
            this.subMenuLogistica.SuspendLayout();
            this.subMenuDash.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 640);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.Menu);
            this.panel2.Controls.Add(this.pLogo);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 716);
            this.panel2.TabIndex = 8;
            // 
            // Menu
            // 
            this.Menu.AutoScroll = true;
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.Menu.Controls.Add(this.subMenuAdministracion);
            this.Menu.Controls.Add(this.btnAdministracion);
            this.Menu.Controls.Add(this.subMenuInformes);
            this.Menu.Controls.Add(this.btnInformes);
            this.Menu.Controls.Add(this.subMenuLogistica);
            this.Menu.Controls.Add(this.btnLogistica);
            this.Menu.Controls.Add(this.subMenuDash);
            this.Menu.Controls.Add(this.btnOperacion);
            this.Menu.Controls.Add(this.btnDashBoard);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(0, 100);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(220, 616);
            this.Menu.TabIndex = 9;
            // 
            // subMenuAdministracion
            // 
            this.subMenuAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.subMenuAdministracion.Controls.Add(this.btnConfiguracion);
            this.subMenuAdministracion.Controls.Add(this.btnUsuarios);
            this.subMenuAdministracion.Controls.Add(this.btnPrivilegios);
            this.subMenuAdministracion.Controls.Add(this.btnFacturacion);
            this.subMenuAdministracion.Controls.Add(this.btnCorrelativos);
            this.subMenuAdministracion.Controls.Add(this.btnSucursales);
            this.subMenuAdministracion.Controls.Add(this.btnListaPrecios);
            this.subMenuAdministracion.Controls.Add(this.btnAlmacen);
            this.subMenuAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuAdministracion.Location = new System.Drawing.Point(0, 800);
            this.subMenuAdministracion.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuAdministracion.Name = "subMenuAdministracion";
            this.subMenuAdministracion.Size = new System.Drawing.Size(203, 327);
            this.subMenuAdministracion.TabIndex = 22;
            this.subMenuAdministracion.Visible = false;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnConfiguracion.IconColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconSize = 25;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnConfiguracion.Rotation = 0D;
            this.btnConfiguracion.Size = new System.Drawing.Size(220, 40);
            this.btnConfiguracion.TabIndex = 3;
            this.btnConfiguracion.Text = "  Configuracion";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconSize = 25;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 40);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUsuarios.Rotation = 0D;
            this.btnUsuarios.Size = new System.Drawing.Size(220, 40);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "  Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnPrivilegios
            // 
            this.btnPrivilegios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnPrivilegios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrivilegios.FlatAppearance.BorderSize = 0;
            this.btnPrivilegios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnPrivilegios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnPrivilegios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrivilegios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrivilegios.ForeColor = System.Drawing.Color.White;
            this.btnPrivilegios.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btnPrivilegios.IconColor = System.Drawing.Color.White;
            this.btnPrivilegios.IconSize = 25;
            this.btnPrivilegios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrivilegios.Location = new System.Drawing.Point(0, 80);
            this.btnPrivilegios.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrivilegios.Name = "btnPrivilegios";
            this.btnPrivilegios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPrivilegios.Rotation = 0D;
            this.btnPrivilegios.Size = new System.Drawing.Size(220, 40);
            this.btnPrivilegios.TabIndex = 5;
            this.btnPrivilegios.Text = "  Privilegios";
            this.btnPrivilegios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrivilegios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrivilegios.UseVisualStyleBackColor = false;
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnFacturacion.IconColor = System.Drawing.Color.White;
            this.btnFacturacion.IconSize = 25;
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(0, 120);
            this.btnFacturacion.Margin = new System.Windows.Forms.Padding(0);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFacturacion.Rotation = 0D;
            this.btnFacturacion.Size = new System.Drawing.Size(220, 40);
            this.btnFacturacion.TabIndex = 6;
            this.btnFacturacion.Text = "  Facturacion";
            this.btnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturacion.UseVisualStyleBackColor = false;
            // 
            // btnCorrelativos
            // 
            this.btnCorrelativos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnCorrelativos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCorrelativos.FlatAppearance.BorderSize = 0;
            this.btnCorrelativos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnCorrelativos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnCorrelativos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrelativos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCorrelativos.ForeColor = System.Drawing.Color.White;
            this.btnCorrelativos.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.btnCorrelativos.IconColor = System.Drawing.Color.White;
            this.btnCorrelativos.IconSize = 25;
            this.btnCorrelativos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrelativos.Location = new System.Drawing.Point(0, 160);
            this.btnCorrelativos.Margin = new System.Windows.Forms.Padding(0);
            this.btnCorrelativos.Name = "btnCorrelativos";
            this.btnCorrelativos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCorrelativos.Rotation = 0D;
            this.btnCorrelativos.Size = new System.Drawing.Size(220, 40);
            this.btnCorrelativos.TabIndex = 7;
            this.btnCorrelativos.Text = "  Correlativos";
            this.btnCorrelativos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCorrelativos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCorrelativos.UseVisualStyleBackColor = false;
            // 
            // btnSucursales
            // 
            this.btnSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnSucursales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSucursales.FlatAppearance.BorderSize = 0;
            this.btnSucursales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnSucursales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursales.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSucursales.ForeColor = System.Drawing.Color.White;
            this.btnSucursales.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.btnSucursales.IconColor = System.Drawing.Color.White;
            this.btnSucursales.IconSize = 25;
            this.btnSucursales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSucursales.Location = new System.Drawing.Point(0, 200);
            this.btnSucursales.Margin = new System.Windows.Forms.Padding(0);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSucursales.Rotation = 0D;
            this.btnSucursales.Size = new System.Drawing.Size(220, 40);
            this.btnSucursales.TabIndex = 8;
            this.btnSucursales.Text = "  Sucursales";
            this.btnSucursales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSucursales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSucursales.UseVisualStyleBackColor = false;
            // 
            // btnListaPrecios
            // 
            this.btnListaPrecios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnListaPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaPrecios.FlatAppearance.BorderSize = 0;
            this.btnListaPrecios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnListaPrecios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnListaPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaPrecios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnListaPrecios.ForeColor = System.Drawing.Color.White;
            this.btnListaPrecios.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnListaPrecios.IconColor = System.Drawing.Color.White;
            this.btnListaPrecios.IconSize = 25;
            this.btnListaPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaPrecios.Location = new System.Drawing.Point(0, 240);
            this.btnListaPrecios.Margin = new System.Windows.Forms.Padding(0);
            this.btnListaPrecios.Name = "btnListaPrecios";
            this.btnListaPrecios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnListaPrecios.Rotation = 0D;
            this.btnListaPrecios.Size = new System.Drawing.Size(220, 40);
            this.btnListaPrecios.TabIndex = 9;
            this.btnListaPrecios.Text = "  Lista de precios";
            this.btnListaPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaPrecios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaPrecios.UseVisualStyleBackColor = false;
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnAlmacen.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnAlmacen.IconColor = System.Drawing.Color.White;
            this.btnAlmacen.IconSize = 25;
            this.btnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.Location = new System.Drawing.Point(0, 280);
            this.btnAlmacen.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAlmacen.Rotation = 0D;
            this.btnAlmacen.Size = new System.Drawing.Size(220, 40);
            this.btnAlmacen.TabIndex = 10;
            this.btnAlmacen.Text = "  Almacen";
            this.btnAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlmacen.UseVisualStyleBackColor = false;
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnAdministracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdministracion.ForeColor = System.Drawing.Color.White;
            this.btnAdministracion.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnAdministracion.IconColor = System.Drawing.Color.White;
            this.btnAdministracion.IconSize = 25;
            this.btnAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.Location = new System.Drawing.Point(0, 760);
            this.btnAdministracion.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdministracion.Rotation = 0D;
            this.btnAdministracion.Size = new System.Drawing.Size(203, 40);
            this.btnAdministracion.TabIndex = 20;
            this.btnAdministracion.Text = "  Administracion";
            this.btnAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // subMenuInformes
            // 
            this.subMenuInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.subMenuInformes.Controls.Add(this.btnReporteVentas);
            this.subMenuInformes.Controls.Add(this.btnPromasVendidos);
            this.subMenuInformes.Controls.Add(this.btnKardex);
            this.subMenuInformes.Controls.Add(this.btnLibVentas);
            this.subMenuInformes.Controls.Add(this.btnLibCompras);
            this.subMenuInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuInformes.Location = new System.Drawing.Point(0, 560);
            this.subMenuInformes.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuInformes.Name = "subMenuInformes";
            this.subMenuInformes.Size = new System.Drawing.Size(203, 200);
            this.subMenuInformes.TabIndex = 19;
            this.subMenuInformes.Visible = false;
            // 
            // btnReporteVentas
            // 
            this.btnReporteVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnReporteVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteVentas.FlatAppearance.BorderSize = 0;
            this.btnReporteVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnReporteVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReporteVentas.ForeColor = System.Drawing.Color.White;
            this.btnReporteVentas.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnReporteVentas.IconColor = System.Drawing.Color.White;
            this.btnReporteVentas.IconSize = 25;
            this.btnReporteVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteVentas.Location = new System.Drawing.Point(0, 0);
            this.btnReporteVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnReporteVentas.Name = "btnReporteVentas";
            this.btnReporteVentas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReporteVentas.Rotation = 0D;
            this.btnReporteVentas.Size = new System.Drawing.Size(220, 40);
            this.btnReporteVentas.TabIndex = 3;
            this.btnReporteVentas.Text = "  Reporte de Ventas";
            this.btnReporteVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteVentas.UseVisualStyleBackColor = false;
            // 
            // btnPromasVendidos
            // 
            this.btnPromasVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnPromasVendidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromasVendidos.FlatAppearance.BorderSize = 0;
            this.btnPromasVendidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnPromasVendidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnPromasVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromasVendidos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPromasVendidos.ForeColor = System.Drawing.Color.White;
            this.btnPromasVendidos.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnPromasVendidos.IconColor = System.Drawing.Color.White;
            this.btnPromasVendidos.IconSize = 25;
            this.btnPromasVendidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromasVendidos.Location = new System.Drawing.Point(0, 40);
            this.btnPromasVendidos.Margin = new System.Windows.Forms.Padding(0);
            this.btnPromasVendidos.Name = "btnPromasVendidos";
            this.btnPromasVendidos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPromasVendidos.Rotation = 0D;
            this.btnPromasVendidos.Size = new System.Drawing.Size(220, 40);
            this.btnPromasVendidos.TabIndex = 4;
            this.btnPromasVendidos.Text = "  Productos mas vendidos";
            this.btnPromasVendidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromasVendidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPromasVendidos.UseVisualStyleBackColor = false;
            // 
            // btnKardex
            // 
            this.btnKardex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnKardex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKardex.FlatAppearance.BorderSize = 0;
            this.btnKardex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnKardex.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnKardex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKardex.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnKardex.ForeColor = System.Drawing.Color.White;
            this.btnKardex.IconChar = FontAwesome.Sharp.IconChar.CompressAlt;
            this.btnKardex.IconColor = System.Drawing.Color.White;
            this.btnKardex.IconSize = 25;
            this.btnKardex.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKardex.Location = new System.Drawing.Point(0, 80);
            this.btnKardex.Margin = new System.Windows.Forms.Padding(0);
            this.btnKardex.Name = "btnKardex";
            this.btnKardex.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnKardex.Rotation = 0D;
            this.btnKardex.Size = new System.Drawing.Size(220, 40);
            this.btnKardex.TabIndex = 5;
            this.btnKardex.Text = "  Kardex";
            this.btnKardex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKardex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKardex.UseVisualStyleBackColor = false;
            // 
            // btnLibVentas
            // 
            this.btnLibVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnLibVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibVentas.FlatAppearance.BorderSize = 0;
            this.btnLibVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnLibVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnLibVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLibVentas.ForeColor = System.Drawing.Color.White;
            this.btnLibVentas.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnLibVentas.IconColor = System.Drawing.Color.White;
            this.btnLibVentas.IconSize = 25;
            this.btnLibVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibVentas.Location = new System.Drawing.Point(0, 120);
            this.btnLibVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnLibVentas.Name = "btnLibVentas";
            this.btnLibVentas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLibVentas.Rotation = 0D;
            this.btnLibVentas.Size = new System.Drawing.Size(220, 40);
            this.btnLibVentas.TabIndex = 6;
            this.btnLibVentas.Text = "  Libro de Ventas";
            this.btnLibVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibVentas.UseVisualStyleBackColor = false;
            // 
            // btnLibCompras
            // 
            this.btnLibCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnLibCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibCompras.FlatAppearance.BorderSize = 0;
            this.btnLibCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnLibCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnLibCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibCompras.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLibCompras.ForeColor = System.Drawing.Color.White;
            this.btnLibCompras.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnLibCompras.IconColor = System.Drawing.Color.White;
            this.btnLibCompras.IconSize = 25;
            this.btnLibCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibCompras.Location = new System.Drawing.Point(0, 160);
            this.btnLibCompras.Margin = new System.Windows.Forms.Padding(0);
            this.btnLibCompras.Name = "btnLibCompras";
            this.btnLibCompras.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLibCompras.Rotation = 0D;
            this.btnLibCompras.Size = new System.Drawing.Size(220, 40);
            this.btnLibCompras.TabIndex = 7;
            this.btnLibCompras.Text = "  Libro de Compras";
            this.btnLibCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibCompras.UseVisualStyleBackColor = false;
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnInformes.IconColor = System.Drawing.Color.White;
            this.btnInformes.IconSize = 25;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 520);
            this.btnInformes.Margin = new System.Windows.Forms.Padding(0);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInformes.Rotation = 0D;
            this.btnInformes.Size = new System.Drawing.Size(203, 40);
            this.btnInformes.TabIndex = 18;
            this.btnInformes.Text = "  Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // subMenuLogistica
            // 
            this.subMenuLogistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.subMenuLogistica.Controls.Add(this.btnCatalogoProductos);
            this.subMenuLogistica.Controls.Add(this.btnOC);
            this.subMenuLogistica.Controls.Add(this.btnDevOC);
            this.subMenuLogistica.Controls.Add(this.btnTraspaso);
            this.subMenuLogistica.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuLogistica.Location = new System.Drawing.Point(0, 360);
            this.subMenuLogistica.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuLogistica.Name = "subMenuLogistica";
            this.subMenuLogistica.Size = new System.Drawing.Size(203, 160);
            this.subMenuLogistica.TabIndex = 17;
            this.subMenuLogistica.Visible = false;
            // 
            // btnCatalogoProductos
            // 
            this.btnCatalogoProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnCatalogoProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalogoProductos.FlatAppearance.BorderSize = 0;
            this.btnCatalogoProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnCatalogoProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnCatalogoProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogoProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCatalogoProductos.ForeColor = System.Drawing.Color.White;
            this.btnCatalogoProductos.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnCatalogoProductos.IconColor = System.Drawing.Color.White;
            this.btnCatalogoProductos.IconSize = 25;
            this.btnCatalogoProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogoProductos.Location = new System.Drawing.Point(0, 0);
            this.btnCatalogoProductos.Margin = new System.Windows.Forms.Padding(0);
            this.btnCatalogoProductos.Name = "btnCatalogoProductos";
            this.btnCatalogoProductos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCatalogoProductos.Rotation = 0D;
            this.btnCatalogoProductos.Size = new System.Drawing.Size(220, 40);
            this.btnCatalogoProductos.TabIndex = 3;
            this.btnCatalogoProductos.Text = "  Catalogo de productos";
            this.btnCatalogoProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogoProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCatalogoProductos.UseVisualStyleBackColor = false;
            // 
            // btnOC
            // 
            this.btnOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnOC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOC.FlatAppearance.BorderSize = 0;
            this.btnOC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnOC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOC.ForeColor = System.Drawing.Color.White;
            this.btnOC.IconChar = FontAwesome.Sharp.IconChar.SortAmountUpAlt;
            this.btnOC.IconColor = System.Drawing.Color.White;
            this.btnOC.IconSize = 25;
            this.btnOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOC.Location = new System.Drawing.Point(0, 40);
            this.btnOC.Margin = new System.Windows.Forms.Padding(0);
            this.btnOC.Name = "btnOC";
            this.btnOC.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnOC.Rotation = 0D;
            this.btnOC.Size = new System.Drawing.Size(220, 40);
            this.btnOC.TabIndex = 4;
            this.btnOC.Text = "  Ingreso OC";
            this.btnOC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOC.UseVisualStyleBackColor = false;
            // 
            // btnDevOC
            // 
            this.btnDevOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnDevOC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevOC.FlatAppearance.BorderSize = 0;
            this.btnDevOC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnDevOC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnDevOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevOC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDevOC.ForeColor = System.Drawing.Color.White;
            this.btnDevOC.IconChar = FontAwesome.Sharp.IconChar.SortAmountDownAlt;
            this.btnDevOC.IconColor = System.Drawing.Color.White;
            this.btnDevOC.IconSize = 25;
            this.btnDevOC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevOC.Location = new System.Drawing.Point(0, 80);
            this.btnDevOC.Margin = new System.Windows.Forms.Padding(0);
            this.btnDevOC.Name = "btnDevOC";
            this.btnDevOC.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDevOC.Rotation = 0D;
            this.btnDevOC.Size = new System.Drawing.Size(220, 40);
            this.btnDevOC.TabIndex = 5;
            this.btnDevOC.Text = "  Devolucion OC";
            this.btnDevOC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevOC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevOC.UseVisualStyleBackColor = false;
            // 
            // btnTraspaso
            // 
            this.btnTraspaso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnTraspaso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraspaso.FlatAppearance.BorderSize = 0;
            this.btnTraspaso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnTraspaso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnTraspaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraspaso.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTraspaso.ForeColor = System.Drawing.Color.White;
            this.btnTraspaso.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.btnTraspaso.IconColor = System.Drawing.Color.White;
            this.btnTraspaso.IconSize = 25;
            this.btnTraspaso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraspaso.Location = new System.Drawing.Point(0, 120);
            this.btnTraspaso.Margin = new System.Windows.Forms.Padding(0);
            this.btnTraspaso.Name = "btnTraspaso";
            this.btnTraspaso.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTraspaso.Rotation = 0D;
            this.btnTraspaso.Size = new System.Drawing.Size(220, 40);
            this.btnTraspaso.TabIndex = 6;
            this.btnTraspaso.Text = "  Traspaso entre bodegas";
            this.btnTraspaso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraspaso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraspaso.UseVisualStyleBackColor = false;
            // 
            // btnLogistica
            // 
            this.btnLogistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnLogistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogistica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogistica.FlatAppearance.BorderSize = 0;
            this.btnLogistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnLogistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnLogistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogistica.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogistica.ForeColor = System.Drawing.Color.White;
            this.btnLogistica.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnLogistica.IconColor = System.Drawing.Color.White;
            this.btnLogistica.IconSize = 25;
            this.btnLogistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogistica.Location = new System.Drawing.Point(0, 320);
            this.btnLogistica.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogistica.Name = "btnLogistica";
            this.btnLogistica.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogistica.Rotation = 0D;
            this.btnLogistica.Size = new System.Drawing.Size(203, 40);
            this.btnLogistica.TabIndex = 10;
            this.btnLogistica.Text = "  Existencia";
            this.btnLogistica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogistica.UseVisualStyleBackColor = false;
            this.btnLogistica.Click += new System.EventHandler(this.btnLogistica_Click);
            // 
            // subMenuDash
            // 
            this.subMenuDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.subMenuDash.Controls.Add(this.btnVentas);
            this.subMenuDash.Controls.Add(this.btnCotizacion);
            this.subMenuDash.Controls.Add(this.btnAnulacion);
            this.subMenuDash.Controls.Add(this.btnNC);
            this.subMenuDash.Controls.Add(this.btnReimpresion);
            this.subMenuDash.Controls.Add(this.btnClientes);
            this.subMenuDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuDash.Location = new System.Drawing.Point(0, 80);
            this.subMenuDash.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuDash.Name = "subMenuDash";
            this.subMenuDash.Size = new System.Drawing.Size(203, 240);
            this.subMenuDash.TabIndex = 11;
            this.subMenuDash.Visible = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconSize = 25;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 0);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnVentas.Rotation = 0D;
            this.btnVentas.Size = new System.Drawing.Size(220, 40);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "  Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click_1);
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotizacion.FlatAppearance.BorderSize = 0;
            this.btnCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnCotizacion.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.btnCotizacion.IconColor = System.Drawing.Color.White;
            this.btnCotizacion.IconSize = 25;
            this.btnCotizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotizacion.Location = new System.Drawing.Point(0, 40);
            this.btnCotizacion.Margin = new System.Windows.Forms.Padding(0);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCotizacion.Rotation = 0D;
            this.btnCotizacion.Size = new System.Drawing.Size(220, 40);
            this.btnCotizacion.TabIndex = 4;
            this.btnCotizacion.Text = "  Cotizaciones";
            this.btnCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCotizacion.UseVisualStyleBackColor = false;
            // 
            // btnAnulacion
            // 
            this.btnAnulacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnAnulacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnulacion.FlatAppearance.BorderSize = 0;
            this.btnAnulacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnAnulacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnAnulacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnulacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAnulacion.ForeColor = System.Drawing.Color.White;
            this.btnAnulacion.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnAnulacion.IconColor = System.Drawing.Color.White;
            this.btnAnulacion.IconSize = 25;
            this.btnAnulacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnulacion.Location = new System.Drawing.Point(0, 80);
            this.btnAnulacion.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnulacion.Name = "btnAnulacion";
            this.btnAnulacion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAnulacion.Rotation = 0D;
            this.btnAnulacion.Size = new System.Drawing.Size(220, 40);
            this.btnAnulacion.TabIndex = 5;
            this.btnAnulacion.Text = "  Anular Documento";
            this.btnAnulacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnulacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnulacion.UseVisualStyleBackColor = false;
            // 
            // btnNC
            // 
            this.btnNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnNC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNC.FlatAppearance.BorderSize = 0;
            this.btnNC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnNC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNC.ForeColor = System.Drawing.Color.White;
            this.btnNC.IconChar = FontAwesome.Sharp.IconChar.CommentDollar;
            this.btnNC.IconColor = System.Drawing.Color.White;
            this.btnNC.IconSize = 25;
            this.btnNC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNC.Location = new System.Drawing.Point(0, 120);
            this.btnNC.Margin = new System.Windows.Forms.Padding(0);
            this.btnNC.Name = "btnNC";
            this.btnNC.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNC.Rotation = 0D;
            this.btnNC.Size = new System.Drawing.Size(220, 40);
            this.btnNC.TabIndex = 6;
            this.btnNC.Text = "  Nota de Credito";
            this.btnNC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNC.UseVisualStyleBackColor = false;
            // 
            // btnReimpresion
            // 
            this.btnReimpresion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnReimpresion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReimpresion.FlatAppearance.BorderSize = 0;
            this.btnReimpresion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnReimpresion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnReimpresion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReimpresion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReimpresion.ForeColor = System.Drawing.Color.White;
            this.btnReimpresion.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnReimpresion.IconColor = System.Drawing.Color.White;
            this.btnReimpresion.IconSize = 25;
            this.btnReimpresion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReimpresion.Location = new System.Drawing.Point(0, 160);
            this.btnReimpresion.Margin = new System.Windows.Forms.Padding(0);
            this.btnReimpresion.Name = "btnReimpresion";
            this.btnReimpresion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReimpresion.Rotation = 0D;
            this.btnReimpresion.Size = new System.Drawing.Size(220, 40);
            this.btnReimpresion.TabIndex = 7;
            this.btnReimpresion.Text = "  Reimpresion";
            this.btnReimpresion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReimpresion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReimpresion.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconSize = 25;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 200);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnClientes.Rotation = 0D;
            this.btnClientes.Size = new System.Drawing.Size(220, 40);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = " Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnOperacion
            // 
            this.btnOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnOperacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOperacion.FlatAppearance.BorderSize = 0;
            this.btnOperacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnOperacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOperacion.ForeColor = System.Drawing.Color.White;
            this.btnOperacion.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btnOperacion.IconColor = System.Drawing.Color.White;
            this.btnOperacion.IconSize = 25;
            this.btnOperacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperacion.Location = new System.Drawing.Point(0, 40);
            this.btnOperacion.Margin = new System.Windows.Forms.Padding(0);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOperacion.Rotation = 0D;
            this.btnOperacion.Size = new System.Drawing.Size(203, 40);
            this.btnOperacion.TabIndex = 15;
            this.btnOperacion.Text = "  Operaciones";
            this.btnOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOperacion.UseVisualStyleBackColor = false;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnDashBoard.IconColor = System.Drawing.Color.White;
            this.btnDashBoard.IconSize = 25;
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashBoard.Rotation = 0D;
            this.btnDashBoard.Size = new System.Drawing.Size(203, 40);
            this.btnDashBoard.TabIndex = 16;
            this.btnDashBoard.Text = "  Dashboard";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // pLogo
            // 
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(220, 100);
            this.pLogo.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tolFecha,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7});
            this.statusStrip1.Location = new System.Drawing.Point(225, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(295, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Fecha:";
            // 
            // tolFecha
            // 
            this.tolFecha.Name = "tolFecha";
            this.tolFecha.Size = new System.Drawing.Size(36, 17);
            this.tolFecha.Text = "10/10";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel3.Text = "Servidor:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel4.Text = "¿?";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel5.Text = "|";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel6.Text = "Tipo de Cambio:";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel7.Text = "¿?";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contenedor
            // 
            this.contenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contenedor.Location = new System.Drawing.Point(235, 42);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1027, 650);
            this.contenedor.TabIndex = 11;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.contenedor;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel2.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.subMenuAdministracion.ResumeLayout(false);
            this.subMenuInformes.ResumeLayout(false);
            this.subMenuLogistica.ResumeLayout(false);
            this.subMenuDash.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Menu;
        private FontAwesome.Sharp.IconButton btnLogistica;
        private System.Windows.Forms.FlowLayoutPanel subMenuDash;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnCotizacion;
        private FontAwesome.Sharp.IconButton btnAnulacion;
        private FontAwesome.Sharp.IconButton btnNC;
        private FontAwesome.Sharp.IconButton btnReimpresion;
        private FontAwesome.Sharp.IconButton btnOperacion;
        private FontAwesome.Sharp.IconButton btnDashBoard;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.FlowLayoutPanel subMenuLogistica;
        private FontAwesome.Sharp.IconButton btnCatalogoProductos;
        private FontAwesome.Sharp.IconButton btnOC;
        private FontAwesome.Sharp.IconButton btnDevOC;
        private System.Windows.Forms.FlowLayoutPanel subMenuInformes;
        private FontAwesome.Sharp.IconButton btnReporteVentas;
        private FontAwesome.Sharp.IconButton btnPromasVendidos;
        private FontAwesome.Sharp.IconButton btnKardex;
        private FontAwesome.Sharp.IconButton btnInformes;
        private System.Windows.Forms.FlowLayoutPanel subMenuAdministracion;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnPrivilegios;
        private FontAwesome.Sharp.IconButton btnFacturacion;
        private FontAwesome.Sharp.IconButton btnAdministracion;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnCorrelativos;
        private FontAwesome.Sharp.IconButton btnSucursales;
        private FontAwesome.Sharp.IconButton btnListaPrecios;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tolFecha;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private FontAwesome.Sharp.IconButton btnLibVentas;
        private FontAwesome.Sharp.IconButton btnLibCompras;
        private FontAwesome.Sharp.IconButton btnAlmacen;
        private FontAwesome.Sharp.IconButton btnTraspaso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel contenedor;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}


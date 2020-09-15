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
            this.Barra = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOperaciones = new FontAwesome.Sharp.IconButton();
            this.subMenuDash = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnCotizacion = new FontAwesome.Sharp.IconButton();
            this.btnAnulacion = new FontAwesome.Sharp.IconButton();
            this.Menu.SuspendLayout();
            this.subMenuDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barra
            // 
            this.Barra.BackColor = System.Drawing.Color.White;
            this.Barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra.Location = new System.Drawing.Point(0, 0);
            this.Barra.Margin = new System.Windows.Forms.Padding(0);
            this.Barra.Name = "Barra";
            this.Barra.Size = new System.Drawing.Size(1280, 50);
            this.Barra.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Barra;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconSize = 25;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 30);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Rotation = 0D;
            this.btnHome.Size = new System.Drawing.Size(200, 40);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "  Dashboard";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.Leave += new System.EventHandler(this.btnHome_Leave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // Menu
            // 
            this.Menu.AutoScroll = true;
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.Menu.Controls.Add(this.btnHome);
            this.Menu.Controls.Add(this.btnOperaciones);
            this.Menu.Controls.Add(this.subMenuDash);
            this.Menu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.Menu.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(0, 50);
            this.Menu.Margin = new System.Windows.Forms.Padding(0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Menu.Size = new System.Drawing.Size(200, 670);
            this.Menu.TabIndex = 3;
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.btnOperaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOperaciones.FlatAppearance.BorderSize = 0;
            this.btnOperaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnOperaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(162)))), ((int)(((byte)(182)))));
            this.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperaciones.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOperaciones.ForeColor = System.Drawing.Color.White;
            this.btnOperaciones.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnOperaciones.IconColor = System.Drawing.Color.White;
            this.btnOperaciones.IconSize = 25;
            this.btnOperaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperaciones.Location = new System.Drawing.Point(0, 70);
            this.btnOperaciones.Margin = new System.Windows.Forms.Padding(0);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOperaciones.Rotation = 0D;
            this.btnOperaciones.Size = new System.Drawing.Size(200, 40);
            this.btnOperaciones.TabIndex = 5;
            this.btnOperaciones.Text = "  Operaciones";
            this.btnOperaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOperaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOperaciones.UseVisualStyleBackColor = false;
            // 
            // subMenuDash
            // 
            this.subMenuDash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subMenuDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(59)))), ((int)(((byte)(65)))));
            this.subMenuDash.Controls.Add(this.btnVentas);
            this.subMenuDash.Controls.Add(this.btnCotizacion);
            this.subMenuDash.Controls.Add(this.btnAnulacion);
            this.subMenuDash.Location = new System.Drawing.Point(0, 110);
            this.subMenuDash.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuDash.Name = "subMenuDash";
            this.subMenuDash.Size = new System.Drawing.Size(200, 132);
            this.subMenuDash.TabIndex = 4;
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
            this.btnVentas.Size = new System.Drawing.Size(200, 40);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.Text = "  Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
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
            this.btnCotizacion.Size = new System.Drawing.Size(200, 40);
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
            this.btnAnulacion.Size = new System.Drawing.Size(200, 40);
            this.btnAnulacion.TabIndex = 5;
            this.btnAnulacion.Text = "  Anular Documento";
            this.btnAnulacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnulacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnulacion.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Menu.ResumeLayout(false);
            this.subMenuDash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Barra;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.FlowLayoutPanel Menu;
        private System.Windows.Forms.FlowLayoutPanel subMenuDash;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnCotizacion;
        private FontAwesome.Sharp.IconButton btnOperaciones;
        private FontAwesome.Sharp.IconButton btnAnulacion;
    }
}


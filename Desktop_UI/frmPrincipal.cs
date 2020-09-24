using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MetroFramework;
using MetroFramework.Forms;

namespace Desktop_UI
{
    public partial class frmPrincipal : MetroForm
    {
        private IconButton currentBtn;
        private Form activeForm = null;

        #region probando

        #endregion
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else { currentBtn.BackColor = Color.FromArgb(26, 34, 38); subMenu.Visible = false; }
               
            
        }
        void activarBoton(Object senderBtn, FlowLayoutPanel panel) {
            
            if (senderBtn != null)
            {             
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(22, 162, 182);
                currentBtn.ForeColor = Color.White;         
                currentBtn.IconColor = Color.White;
                showSubMenu(panel);                     
            }
        }
     
        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnLogistica.ForeColor = Color.White;
            btnLogistica.IconColor = Color.White;
        }
        private void btnHome_Leave(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }
        
        private void abrirForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contenedor.Controls.Add(childForm);
            contenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            MDIClientSupport.SetBevel(this,false);
         //   subMenuDash.Size = new Size(120,0);
            MdiClient oMDI;
            //recorremos todos los controles hijos del formulario
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Intentamos castear el objeto MdiClient
                    oMDI = (MdiClient)ctl;

                    // Cuando sea casteado con éxito, podremos cambiar el color así
                    oMDI.BackColor = Color.White;
                  
                }
                catch (InvalidCastException exc)
                {
                    // No hacemos nada cuando el control no sea tupo MdiClient
                }
            }

            abrirForm(new frmDashBoard());
          
        }

       
     
        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }
       
        private void btnOperacion_Click(object sender, EventArgs e)
        {            
            activarBoton(btnOperacion, subMenuDash);
        }

        private void btnLogistica_Click(object sender, EventArgs e)
        {
            activarBoton(btnLogistica, subMenuLogistica); 
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {   
            activarBoton(btnInformes, subMenuInformes);
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            activarBoton(btnAdministracion, subMenuAdministracion);
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            abrirForm(new frmNotaPedido());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tolFecha.Text = DateTime.Now.ToString();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            frmDashBoard f1 = new frmDashBoard();
            abrirForm(f1);
        }
    }
}

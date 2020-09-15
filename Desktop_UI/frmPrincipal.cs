using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Desktop_UI
{
    public partial class frmPrincipal : Form
    {
        private IconButton currentBtn;
        private FlowLayoutPanel currentPanel;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        void activarBoton(Object senderBtn)
        {
            if (senderBtn != null)
            {
                desactivar();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(22, 162, 182);
                currentBtn.ForeColor = Color.White;
                // currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                //   currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;        
            }

        }

        void activarBoton(Object senderBtn, FlowLayoutPanel panel, int tamaño) {
           
            if (senderBtn != null)
            {
                desactivar();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(22, 162, 182);
                currentBtn.ForeColor = Color.White;
             // currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                panel.Size = new Size(120,tamaño);
                panel.Location = new Point(0,110);
             //   currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;        
            }

        }
        private void desactivar() {
            if (currentBtn != null)
            {
                subMenuDash.Size = new Size(120, 0);
                currentBtn.BackColor = Color.FromArgb(44, 59, 65);   
            }
        }
        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.White;
            btnHome.IconColor = Color.White;
        }
        private void btnHome_Leave(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activarBoton(btnHome,subMenuDash,120);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {            
            activarBoton(btnVentas);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            subMenuDash.Size = new Size(120,0);
        }
    }
}

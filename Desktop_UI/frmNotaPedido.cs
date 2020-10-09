using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Desktop_UI
{
   
    public partial class frmNotaPedido : Form
    {
        private IntPtr hWndNotepad = IntPtr.Zero;
        public frmNotaPedido()
        {
            InitializeComponent();
        }
        Process pro;
        private void frmNotaPedido_Load(object sender, EventArgs e)
        {
           
        }
    }
}

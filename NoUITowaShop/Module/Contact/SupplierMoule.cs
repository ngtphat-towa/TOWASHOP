using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoUITowaShop.Module.Contact
{
    public partial class SupplierMoule : Form
    {
        public SupplierMoule()
        {
            InitializeComponent();
        }

        private static Form instance;
        public static Form GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SupplierMoule();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {

                    instance.WindowState = parentContainer.WindowState;
                }
                    
                instance.BringToFront();
            }
            return instance;
        }
    }
}

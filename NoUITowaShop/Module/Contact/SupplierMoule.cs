using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Repositories.Contacts.Suppliers;

namespace NoUITowaShop.Module.Contact
{
    public partial class SupplierMoule : Form
    {
        public SupplierMoule()
        {
            InitializeComponent();
            this.Load += delegate
            {
                ISupplierRepository repository = new SupplierRepository();
                BindingSource source = new BindingSource();
                source.DataSource = repository.GetAll();
                dataGridView.DataSource = source ;
            };
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

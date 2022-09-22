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
using TOWALibrary.Views.ModuleViews.Contacts;
namespace NoUITowaShop.Module.Contact
{
    public partial class SupplierMoule : Form, ISupplierModuleView
    {
        public SupplierMoule()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabSuppliers.TabPages.Remove(tabDefine);
        }

        #region EvenntHandler and Views Event

        private void AssociateAndRaiseViewEvents()
        {
            //Search Event 
            this.txtSearch.KeyDown += (s,e) =>
            {
                if (e.KeyCode == Keys.Enter) 
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            // Add new supplier
            this.btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabSuppliers.TabPages.Remove(tabSupplierList);
                tabSuppliers.TabPages.Add(tabDefine);

            };
            // Edit supplier
            this.btnEdit.Click += delegate
             {
                 EditEvent?.Invoke(this, EventArgs.Empty);
                 tabSuppliers.TabPages.Remove(tabSupplierList);
                 tabSuppliers.TabPages.Add(tabDefine);
             };
            // Delete supplier 
            this.btnDelete.Click += delegate
             {
                 DialogResult result = MessageBox.Show("Are you sure you want to delete this selected supplier?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                 if (result == DialogResult.Yes)
                 {
                     DeleteEvent?.Invoke(this, EventArgs.Empty);
                     MessageBox.Show(Message);
                 }
             };
            // Cancel Event
            this.btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabSuppliers.TabPages.Remove(tabDefine);
                tabSuppliers.TabPages.Add(tabSupplierList);
            };
            // Save Event
            btnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabSuppliers.TabPages.Remove(tabDefine);
                    tabSuppliers.TabPages.Add(tabSupplierList);
                }
                MessageBox.Show(Message);
            };

        }
        public void SetSuplierListBindingSource(BindingSource supplierList)
        {
            dataGridView.DataSource = supplierList;
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        #endregion

        #region Feilds
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        #endregion

        #region Propeties
        public string SLID {
            get => txtSLID.Text;
            set => txtSLID.Text = value;
        }
        public string SupplierName
        {
            get => this.txtSupplierName.Text;
            set => this.txtSupplierName.Text = value;
        }
        public string ContactName
        {
            get => this.txtContactName.Text;
            set => this.txtContactName.Text = value;
        }

        public string ContactPhone
        {
            get => txtContactPhone.Text;
            set => txtContactPhone.Text = value;
        }
    
        public string Address 
        {
            get => txtAddress.Text;
            set => txtAddress.Text = value;
        }
        public string City 
        {
            get => txtCity.Text;
            set => txtCity.Text = value;
        }
        public string Country {
            get => txtCountry.Text;
            set => txtCountry.Text = value;
        }
        public bool IsEdit {
            get => isEdit;
            set => isEdit = value;
        }
        public bool IsSuccessful {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string Message
        {
            get => message;
            set => message = value;
        }
       public string SearchValue
        {
            get => txtSearch.Text;
            set => txtSearch.Text = value;
        }
        public string Content { get => txtContent.Text; set => txtContent.Text= value; }
        #endregion

        #region Singleton
        private static SupplierMoule instance;
        public static SupplierMoule GetInstance(Form parentContainer)
        {
            if (instance == null || ((Form)instance).IsDisposed)
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
        #endregion
      
    }
}

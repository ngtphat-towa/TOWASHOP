using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Presenters.Modules.Contacts;
using TOWALibrary.Views.ModuleViews.Contacts;

namespace NoUITowaShop.Module.Contact
{
    public partial class CustomerModule : Form, ICustomerModuleView
    {
        private CustomerModulePresenter presenter;
        public CustomerModule()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            presenter = new CustomerModulePresenter(this);
            tabCustomers.TabPages.Remove(tabDefine);

        }
        #region EvenntHandler and Views Event
        private void AssociateAndRaiseViewEvents()
        {
            //Search Event 
            this.txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            // Add new customer
            this.btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabCustomers.TabPages.Remove(tabCustomerList);
                tabCustomers.TabPages.Add(tabDefine);

            };
            // Edit customer
            this.btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabCustomers.TabPages.Remove(tabCustomerList);
                tabCustomers.TabPages.Add(tabDefine);
            };
            // Delete customer 
            this.btnDelete.Click += delegate
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this selected customer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                tabCustomers.TabPages.Remove(tabDefine);
                tabCustomers.TabPages.Add(tabCustomerList);
            };
            // Save Event
            btnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabCustomers.TabPages.Remove(tabDefine);
                    tabCustomers.TabPages.Add(tabCustomerList);
                }
                MessageBox.Show(Message);
            };

        }
        public void SetListViewBindingSource(BindingSource bindingSource)
        {
            dataGridView.DataSource = bindingSource;
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        #endregion

        #region Propeties
        public string CTID { get => this.txtCTID.Text; set => this.txtCTID.Text=value; }
        public string CID { get => this.txtCID.Text; set => txtCID.Text= value; }
        public string FirstName { get => this.txtFirstName.Text; set => this.txtFirstName.Text = value; }
        public string LastName { get => this.txtLastName.Text ; set => this.txtLastName.Text=value; }
        public string ContactPhone { get => this.txtContactPhone.Text; set => this.txtContactPhone.Text=value; }
        public string Address { get => this.txtAddress.Text; set => this.txtAddress.Text= value; }
        public string City { get => this.txtCity.Text; set => this.txtCity.Text=value; }
        public string Country { get => this.txtCountry.Text; set =>this.txtCountry.Text=value; }
        public string Content { get => this.txtContent.Text; set => this.txtContent.Text=value; }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get ; set ; }
        public string Message { get ; set ; }
        public string SearchValue { get => txtSearch.Text; set => this.txtSearch.Text=value; }
        #endregion


        #region Singleton
        private static CustomerModule instance;
        public static CustomerModule GetInstance(Form parentContainer)
        {
            if (instance == null || ((Form)instance).IsDisposed)
            {
                instance = new CustomerModule();
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

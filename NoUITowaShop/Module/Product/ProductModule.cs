using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Models.Inventory.Categoires;
using TOWALibrary.Views.ModuleViews.Inventory;

namespace NoUITowaShop.Module.Product
{
    public partial class ProductModule : Form, IProductModuleView
    {
        #region Contructor
        public ProductModule()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabProducts.TabPages.Remove(tabDefine);

        }
        #endregion

        #region Populate lists into controls 
        public void SetListViewBindingSource(BindingSource list)
        {
            dataGridView.DataSource = list;
        }
        public void SetSupplierList(ICollection<SupplierModel> suppliers)
        {

            cbSupplierList.DataSource = suppliers;
            cbSupplierList.DisplayMember = "SupplierName";
            cbSupplierList.ValueMember = "SLID";
            // None for initial

        }
        public void SetCategoryList(ICollection<CategoryModel> categories)
        {
            cbCategoryList.DataSource = categories;
            cbCategoryList.DisplayMember = "CategoryName";
            cbCategoryList.ValueMember = "CATEID";
        }
        #endregion

        #region EvenntHandler and Views Event

        private void AssociateAndRaiseViewEvents()
        {
            //Search Event 
            this.txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            // Add new product
            this.btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabProducts.TabPages.Remove(tabProductList);
                tabProducts.TabPages.Add(tabDefine);

            };
            // Edit product
            this.btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabProducts.TabPages.Remove(tabProductList);
                tabProducts.TabPages.Add(tabDefine);
            };
            // Delete product 
            this.btnDelete.Click += delegate
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this selected product?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                tabProducts.TabPages.Remove(tabDefine);
                tabProducts.TabPages.Add(tabProductList);
            };
            // Save Event
            btnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabProducts.TabPages.Remove(tabDefine);
                    tabProducts.TabPages.Add(tabProductList);
                }
                MessageBox.Show(Message);
            };

        }

        #endregion


        #region Feilds
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        #endregion

        #region Properties
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public string PID { get => txtPID.Text; set => txtPID.Text = value; }
        public new string ProductName { get => txtProductName.Text; set => txtProductName.Text = value; }
        public string Barcode { get => txtBarcode.Text; set => txtBarcode.Text = value; }
        public string QuantityPerUnit { get => txtQuantityPerUnit.Text; set => txtQuantityPerUnit.Text = value; }
        public decimal UnitPrice { get => txtUnitPrice.Value; set => txtUnitPrice.Value = value; }
        public decimal SalesPrice { get => txtSalePrice.Value; set => txtSalePrice.Value = value; }
        public int UnitOnStock { get => Convert.ToInt32(txtUnitOnStock.Value); set => txtUnitOnStock.Value = value; }
        public int UnitOnOrder { get => Convert.ToInt32(txtUnitOnOrder.Value); set => txtUnitOnOrder.Value = value; }
        public decimal VAT { get => txtVAT.Value; set => txtVAT.Value = value; }
        public string Status { get => cbStatus.SelectedItem.ToString(); set => cbStatus.Text = value; }
        public string Content { get => txtContent.Text; set => txtContent.Text = value; }
        public string Message { get => message; set => message = value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string SelectedSLID { get => cbSupplierList.SelectedValue.ToString(); set => cbSupplierList.SelectedValue = value; }
        public int SelectedCID { get => Convert.ToInt32(cbCategoryList.SelectedValue); set => cbCategoryList.SelectedValue= value; }
        
        #endregion

        #region Singleton 
        private static ProductModule instance;
        public static ProductModule GetInstance(Form parentContainer)
        {
            if (instance == null || ((Form)instance).IsDisposed)
            {
                instance = new ProductModule
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
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

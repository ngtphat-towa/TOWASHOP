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
using TOWALibrary.Presenters.ModelListVew;
using TOWALibrary.Repositories;
using TOWALibrary.Services.CategoryServices;
using TOWALibrary.Services.ModelServices.ProductServices;
using TOWALibrary.Services.ModelServices.SupplierServices;
using TOWALibrary.Views.ModelListVew;
using TOWALibrary.Views.ModelListViewRequester;

namespace NoUITowaShop.ModelListForm
{
    public partial class ProductListForm : Form, IProductListView
    {
        private IProductListViewRequestor _callingForm;
        private readonly ProductListFormPresenter _presenter;
        public ProductListForm(IProductListViewRequestor requester)
        {
            InitializeComponent();


            _presenter = new ProductListFormPresenter(this,
                                                      new ProductModelServices(),
                                                      new SupplierModelServices(),
                                                      new CategoryModelServices());
            _callingForm = requester;

            this.btnAddProduct.Click += delegate
            {
                if (dgvProductList.RowCount != 0)
                {
                    AddProductEvent?.Invoke(this, EventArgs.Empty);
                    if (!IsSuccessful)
                        MessageBox.Show(Message, "Warming", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            this.btnCancel.Click += delegate
            {
                CancelAddEvent?.Invoke(this, EventArgs.Empty);
            };
            this.txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    IsValueSearch = true;
                    SearchFilterChangedEvent?.Invoke(s, EventArgs.Empty);
                }
            };
            this.cbCategoryList.SelectedIndexChanged += delegate
             {
                 SearchFilterChangedEvent?.Invoke(this.cbCategoryList, EventArgs.Empty);
             };
            this.cbSupplierNameList.SelectedIndexChanged += delegate
            {
                SearchFilterChangedEvent?.Invoke(this.cbSupplierNameList, EventArgs.Empty);
            };
            this.dgvProductList.SelectionChanged += delegate
            {
                this.CurrentProductChangedEvent?.Invoke(this.dgvProductList, EventArgs.Empty);

            };


        }

        public string SearchValue { get => this.txtSearch.Text; set => this.txtSearch.Text=value; }
        public string SLID { get => this.cbSupplierNameList.SelectedValue.ToString(); set => this.cbSupplierNameList.SelectedValue = value; }
        public int CTID { get => (int)this.cbCategoryList.SelectedValue; set => this.cbCategoryList.SelectedValue = value; }
        public double Discount { get => Convert.ToDouble(this.txtDiscountValue.Value); set => this.txtDiscountValue.Value = Convert.ToDecimal(value); }
        public int Quantity { get => Convert.ToInt32(this.txtQuanityValue.Value); set => this.txtQuanityValue.Value =Convert.ToDecimal(value); }

        public IProductListViewRequestor CallingForm => this._callingForm;

        public string PID
        {
            get=> this.lbProductID.Text;set=> this.lbProductID.Text =value;
        }
        public bool IsValueSearch { get => isValueSearch; set=> isValueSearch=value; }
        public bool IsMultipleAdded { get => this.checkboxIsMutiAdded.Checked; set => this.checkboxIsMutiAdded.Checked =value; }
        public bool IsSuccessful { get=> isSuccessful; set=> isSuccessful= value; }
        public string Message { get =>message; set =>message =value; }

        private bool isValueSearch;
        private bool isSuccessful;
        private string message;

        public event EventHandler AddProductEvent;
        public event EventHandler CancelAddEvent;
        public event EventHandler SearchFilterChangedEvent;
        public event EventHandler CurrentProductChangedEvent;


        public void SetCategoryListBindlingSource(BindingSource bindingSource)
        {
            this.cbCategoryList.DataSource = bindingSource;
            this.cbCategoryList.DisplayMember = "Name";
            this.cbCategoryList.ValueMember = "ID";
            this.cbCategoryList.SelectedValue = 0;
        }

        public void SetSupplierNameListBindingSource(BindingSource bindingSource)
        {
            this.cbSupplierNameList.DataSource = bindingSource;

            this.cbSupplierNameList.ValueMember = "ID";
            this.cbSupplierNameList.DisplayMember = "Name";
          
;
            this.cbSupplierNameList.SelectedValue = "SL0";
        }
        private static ProductListForm instance;

        public static ProductListForm GetIntance (IProductListViewRequestor requester)
        {
            if (instance == null || ((Form)instance).IsDisposed)
                instance = new ProductListForm(requester);
            
              //  instance.TopMost = true;
                 instance.StartPosition = FormStartPosition.CenterScreen;
                 instance.BringToFront();
                return instance;
            
        }

        public void SetProductListBindingSource(BindingSource bindingSource)
        {
            this.dgvProductList.DataSource = bindingSource;

            this.lbProductID.DataBindings.Add("Text", bindingSource, "PID");
        }

        
    }
}

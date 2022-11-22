using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Presenters.Modules.Inventory.Categories;
using TOWALibrary.Views.ModuleViews.Inventory;

namespace NoUITowaShop.Module.Inventory
{
    public partial class CategoryModule : Form, ICategoryModuleView
    {
        #region Contructor
        private  CategoryModulePresenter presenter;
        public CategoryModule()
        {
            InitializeComponent();

            AssociateAndRaiseViewEvents();
            this.presenter = new CategoryModulePresenter(this);
            tabCategories.TabPages.Remove(tabDefine);
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
            // Add new supplier
            this.btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabCategories.TabPages.Remove(tabCategoryList);
                tabCategories.TabPages.Add(tabDefine);

            };
            // Edit supplier
            this.btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabCategories.TabPages.Remove(tabCategoryList);
                tabCategories.TabPages.Add(tabDefine);
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
                tabCategories.TabPages.Remove(tabDefine);
                tabCategories.TabPages.Add(tabCategoryList);
            };
            // Save Event
            btnSave.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabCategories.TabPages.Remove(tabDefine);
                    tabCategories.TabPages.Add(tabCategoryList);
                }
                MessageBox.Show(Message);
            };

        }
        public void SetSuplierListBindingSource(BindingSource supplierList)
        {
            dataGridView.DataSource = supplierList;
        }
        #endregion

        #region Populate lists into controls 

        public void SetListViewBindingSource(BindingSource categoryList)
        {
            dataGridView.DataSource = categoryList;
        }
        #endregion
        #region Feilds
        private string message;
        private bool isSuccessful;
        private bool isEdit;
        #endregion
        #region Property
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public int CATEID { get => Convert.ToInt32(txtCTID.Text); set => txtCTID.Text = value.ToString(); }
        public string CategoryName { get => txtCategoryName.Text; set => txtCategoryName.Text = value; }
        public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
        public string Content { get => txtContent.Text; set => txtContent.Text= value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful= value; }
        public string Message { get => message; set => message= value; }
        public string SearchValue { get => txtSearch.Text; set => txtSearch.Text= value; }
        public bool IsEdit { get => isEdit; set => isEdit= value; }


        #endregion


        #region Singleton
        private static CategoryModule instance;

        public static CategoryModule GetInstance(Form parentContainer)
        {
            if (instance == null || ((Form)instance).IsDisposed)
            {
                instance = new CategoryModule();
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

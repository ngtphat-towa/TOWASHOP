using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Views.ModuleViews.Contacts;

namespace TOWALibrary.Presenters.Modules.Contacts
{
    public class SupplierModulePresenter
    {
        private readonly ISupplierModuleView view;
        private readonly ISupplierRepository repository;
        private readonly BindingSource suppliersBindingSource;
        private ICollection<SupplierModel> supplierList;

        public SupplierModulePresenter(ISupplierModuleView view, ISupplierRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.suppliersBindingSource = new BindingSource();
            //Wire up event handler methods to view events
            this.view.SearchEvent += SearchSupplier;
            this.view.AddNewEvent += AddNewSupplier;
            this.view.EditEvent += LoadSelectedSuplierToEdit;
            this.view.DeleteEvent += DeleteSelectedSupplier;
            this.view.SaveEvent += SaveSupplier;
            this.view.CancelEvent += CancelAction;
            //Set binding source
            this.view.SetListViewBindingSource(suppliersBindingSource);
            LoadAllSupplierList();
            //Show view
            this.view.Show();
        }

        private void LoadAllSupplierList()
        {
            supplierList = repository.GetAll();
            suppliersBindingSource.DataSource = supplierList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFeilds();
        }

        private void SaveSupplier(object sender, EventArgs e)
        {

            try
            {
                var model = new SupplierModel
                {
                    SLID = view.SLID,
                    SupplierName = view.SupplierName,
                    ContactName = view.ContactName,
                    ContactPhone = view.ContactPhone,
                    Address = view.Address,
                    City = view.City,
                    Country = view.Country,
                    Content = view.Content
                };
                // TODO - Vailidate the model 
                if (view.IsEdit == true)
                {
                    repository.Update(model);
                    view.Message = "Supplier updated successfully!";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Supplier added successfully!";
                }
                view.IsSuccessful = true;
                LoadAllSupplierList();
                CleanViewFeilds();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedSupplier(object sender, EventArgs e)
        {
            try
            {
                var model = (SupplierModel)suppliersBindingSource.Current;
                repository.Delete(model.SLID);
                view.IsSuccessful = true;
                view.Message = "Supplier deleted successfully";
                LoadAllSupplierList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete this supplier";
            }
        }

        private void LoadSelectedSuplierToEdit(object sender, EventArgs e)
        {
            SupplierModel model =(SupplierModel) suppliersBindingSource.Current;
            this.view.SLID = model.SLID;
            this.view.SupplierName = model.SupplierName;
            this.view.ContactName = model.ContactName;
            this.view.ContactPhone = model.ContactPhone;
            this.view.Address = model.Address;
            this.view.City = model.City;
            this.view.Country = model.Country;
            this.view.Content = model.Content;
            view.IsEdit = true;
        }

        private void AddNewSupplier(object sender, EventArgs e)
        {
            this.view.IsEdit = false;
        }

        private void SearchSupplier(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);
                supplierList = repository.GetByValue(this.view.SearchValue);
            suppliersBindingSource.DataSource = supplierList;
        }
        private void CleanViewFeilds()
        {
            this.view.SLID = "SL000000";
            this.view.SupplierName = "";
            this.view.ContactName = "";
            this.view.ContactPhone = "";
            this.view.Address = "";
            this.view.City = "";
            this.view.Country = "";
            this.view.Content = "";
        }
    }
}

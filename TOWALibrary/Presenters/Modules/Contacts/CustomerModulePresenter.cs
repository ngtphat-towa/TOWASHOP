using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Contact.Customers;
using TOWALibrary.Services.CommonServices;
using TOWALibrary.Services.ModelServices.CustomerServices;
using TOWALibrary.Views.ModuleViews.Contacts;

namespace TOWALibrary.Presenters.Modules.Contacts
{
   public class CustomerModulePresenter
    {
        private readonly ICustomerModuleView _view;
        private readonly ICustomerModelServices _customerModelServices = ServicesManager.CustomerModelServices;
        private BindingSource _customersBindingSource;
        private ICollection<CustomerModel> _customerList;
        public CustomerModulePresenter(ICustomerModuleView view)
        {
          
            _view = view;
            this._customersBindingSource = new BindingSource();
            //Wire up event handler methods to view events
            _view.SearchEvent += SearchCustomer;
            _view.AddNewEvent += AddNewCustomer;
            _view.EditEvent += LoadSelectedCustomerToEdit;
            _view.DeleteEvent += DeleteSelectedCustomer;
            _view.SaveEvent += SaveCustomer;
            _view.CancelEvent += CancelAction;
            //Set binding source
            _view.SetListViewBindingSource(_customersBindingSource);
            LoadAllCustomerList();
        }
        private void LoadAllCustomerList()
        {
            _customerList = _customerModelServices.GetAll();
            _customersBindingSource.DataSource = _customerList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFeilds();
        }

        private void SaveCustomer(object sender, EventArgs e)
        {

            try
            {
                var model = new CustomerModel
                {
                    CTID = _view.CTID,
                    CID = _view.CID,
                    FirstName = _view.FirstName,
                    LastName = _view.LastName,
                    ContactPhone = _view.ContactPhone,
                    Address = _view.Address,
                    City = _view.City,
                    Country = _view.Country,
                    Content = _view.Content
                };
                _customerModelServices.ValidateModel(model);
                if (_view.IsEdit == true)
                {
                    _customerModelServices.Update(model);
                    _view.Message = "Customer updated successfully!";
                }
                else
                {
                    _customerModelServices.Add(model);
                    _view.Message = "Customer added successfully!";
                }
                _view.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFeilds();

            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void DeleteSelectedCustomer(object sender, EventArgs e)
        {
            try
            {
                var model = (CustomerModel)_customersBindingSource.Current;
                _customerModelServices.Delete(model.CTID);
                _view.IsSuccessful = true;
                _view.Message = "Customer deleted successfully";
                LoadAllCustomerList();
            }
            catch (Exception)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error occurred, could not delete this customer";
            }
        }

        private void LoadSelectedCustomerToEdit(object sender, EventArgs e)
        {
            CustomerModel model = (CustomerModel)_customersBindingSource.Current;
           _view.CTID= model.CTID;
            _view.CID = model.CID;
           _view.FirstName = model.FirstName;
           _view.LastName= model.LastName;
           _view.ContactPhone = model.ContactPhone;
           _view.Address = model.Address;
           _view.City = model.City;
           _view.Country = model.Country;
           _view.Content = model.Content;
            _view.IsEdit = true;
        }

        private void AddNewCustomer(object sender, EventArgs e)
        {
           _view.IsEdit = false;
        }

        private void SearchCustomer(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this._view.SearchValue);
            _customerList = _customerModelServices.GetByValue(this._view.SearchValue);
            _customersBindingSource.DataSource = _customerList;
        }
        private void CleanViewFeilds()
        {
           _view.CTID = "CT000000";
           _view.CID = "";
           _view.FirstName = "";
            _view.LastName = "";
           _view.ContactPhone = "";
           _view.Address = "";
           _view.City = "";
           _view.Country = "";
           _view.Content = "";
        }
    }
}

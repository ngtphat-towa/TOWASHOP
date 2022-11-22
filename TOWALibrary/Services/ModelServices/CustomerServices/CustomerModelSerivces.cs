using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Customers;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Contacts.Customers;

namespace TOWALibrary.Services.ModelServices.CustomerServices
{
    public class CustomerModelServices : ICustomerModelServices
    {
        ICustomerRepository _customerRepository = DBManager.CustomerRepository;
        public void Add(CustomerModel model)
        {
            _customerRepository.Add(model);
        }

        public void Delete(string SLID)
        {
            _customerRepository.Delete(SLID);
        }

        public ICollection<CustomerModel> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public ICollection<CustomerModel> GetByValue(string value)
        {
            return _customerRepository.GetByValue(value);
        }

        public void Update(CustomerModel model)
        {
            _customerRepository.Update(model);
        }

        public void ValidateModel(CustomerModel model)
        {
            CommonServices.ModelDataValidationCheck.Validate(model);
        }
    }
}

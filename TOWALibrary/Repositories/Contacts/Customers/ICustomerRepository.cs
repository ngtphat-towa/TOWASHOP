using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Customers;

namespace TOWALibrary.Repositories.Contacts.Customers
{
    public interface ICustomerRepository
    {
        void Add(CustomerModel model);
        void Update(CustomerModel model);
        void Delete(string SLID);
        ICollection<CustomerModel> GetAll();
        ICollection<CustomerModel> GetByValue(string value);
        
    }
}

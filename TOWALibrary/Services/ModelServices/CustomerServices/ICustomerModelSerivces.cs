using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Customers;
using TOWALibrary.Repositories.Contacts.Customers;

namespace TOWALibrary.Services.ModelServices.CustomerServices
{
    public interface ICustomerModelServices :ICustomerRepository
    {
        void ValidateModel(CustomerModel model);

    }
}

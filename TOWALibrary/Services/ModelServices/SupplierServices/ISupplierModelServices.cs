using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Repositories.Contacts.Suppliers;

namespace TOWALibrary.Services.ModelServices.SupplierServices
{
    public interface ISupplierModelServices : ISupplierRepository
    {
        void ValidateModel(SupplierModel model);
    }
}

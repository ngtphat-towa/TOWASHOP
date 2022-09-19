using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Suppliers;

namespace TOWALibrary.Repositories.Contacts.Suppliers
{
   public interface ISupplierRepository
    {
        void Add(SupplierModel model);
        void Update(SupplierModel model);
        void Delete(SupplierModel model);
        IEnumerable<SupplierModel> GetAll();
        IEnumerable<SupplierModel> GetByValue(string value);
    }
}

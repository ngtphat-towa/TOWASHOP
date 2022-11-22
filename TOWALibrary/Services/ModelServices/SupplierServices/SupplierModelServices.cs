using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Contacts.Suppliers;

namespace TOWALibrary.Services.ModelServices.SupplierServices
{
    public class SupplierModelServices : ISupplierModelServices
    {
        ISupplierRepository _supplierRepository = DBManager.SupplierRepository;
        public void Add(SupplierModel model)
        {
            _supplierRepository.Add(model);
        }

        public void Delete(string CTID)
        {
            _supplierRepository.Delete(CTID);
        }

        public ICollection<SupplierModel> GetAll()
        {
            return _supplierRepository.GetAll();
        }

        public ICollection<SupplierModel> GetByValue(string value)
        {
            return _supplierRepository.GetByValue(value);
        }

        public void Update(SupplierModel model)
        {
            _supplierRepository.Update(model);
        }

        public void ValidateModel(SupplierModel model)
        {
            CommonServices.ModelDataValidationCheck.Validate(model);
        }
    }
}

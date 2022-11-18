using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Models.Inventory.Categoires;
using TOWALibrary.Models.Inventory.Products;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Inventory.Products;

namespace TOWALibrary.Services.ModelServices.ProductServices
{
    public class ProductModelServices : IProductModelServices
    {
        IProductRepository _productRepository = DBManager.ProductRepository;
        public void Add(ProductModel model)
        {
            _productRepository.Add(model);
        }

        public void Delete(string PID)
        {
            _productRepository.Delete(PID);
        }

        public ICollection<ProductModel> GetAll()
        {
            return _productRepository.GetAll();
        }

        public ICollection<ProductModel> GetByValue(string value)
        {
            return _productRepository.GetByValue(value);
        }

        public ICollection<CategoryModel> GetCategories()
        {
            return _productRepository.GetCategories();
        }

        public ICollection<SupplierModel> GetSupliers()
        {
           return _productRepository.GetSupliers();
        }

        public void Update(ProductModel model)
        {
            _productRepository.Update(model);
        }

        public void UpdateProductOrder(string PID, int oldQuanity, int newQuantity)
        {
            _productRepository.UpdateProductOrder(PID, oldQuanity, newQuantity);
        }

        public void UpdateProductStock(string PID, int oldQuanity, int newQuantity)
        {
            _productRepository.UpdateProductStock(PID, oldQuanity, newQuantity);
        }

        public void ValidateModel(ProductModel model)
        {
            CommonServices.ModelDataValidationCheck.Validate(model);
        }

        public void ValidateOrderDiscount(double discount)
        {
            if (discount >= 100 || discount < 0)
                throw new Exception("The discout value must be from 0 to 100 percent!");
        }

        public void ValidateProductQuantity(string PID, int quantity)
        {
          int UnitOnStock =  _productRepository.GetByValue(PID).FirstOrDefault().UnitOnStock;
            if (quantity <= 0)
                throw new ArgumentException("The quantity must be at least 1 ");
            if( quantity >= UnitOnStock)
                throw new ArgumentException("The quantity must be not larger than stocks ");

        }
    }
}

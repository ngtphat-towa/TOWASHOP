using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Models.Inventory.Categoires;
using TOWALibrary.Models.Inventory.Products;

namespace TOWALibrary.Repositories.Inventory.Products
{
   public interface IProductRepository
    {
        void Add(ProductModel model);
        void Update(ProductModel model);
        void Delete(string PID);
        ICollection<ProductModel> GetAll();
        ICollection<ProductModel> GetByValue(string value);
        ICollection<CategoryModel> GetCategories();
        ICollection<SupplierModel> GetSupliers();
        void UpdateProductOrder(string PID, int oldQuanity, int newQuantity);
        void UpdateProductStock(string PID, int oldQuanity, int newQuantity);
    }
}

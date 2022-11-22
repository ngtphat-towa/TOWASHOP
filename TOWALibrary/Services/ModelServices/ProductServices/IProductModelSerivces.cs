using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Products;
using TOWALibrary.Repositories.Inventory.Products;

namespace TOWALibrary.Services.ModelServices.ProductServices
{
   public interface IProductModelServices :IProductRepository
    {
        string CheckProductBarcodeID(string BarcodeID);
        void ValidateModel(ProductModel model);
        void ValidateProductQuantity(string PID, int  quantity);
        void ValidateOrderDiscount(double discount);
    }
}

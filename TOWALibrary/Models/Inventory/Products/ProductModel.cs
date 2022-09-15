using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Contact.Suppliers;
using TOWALibrary.Models.Inventory.Categoires;

namespace TOWALibrary.Models.Inventory.Products
{
    public class ProductModel
    {
        #region Privat Feilds
        // Product information
        private string _PID;
        private string productName;
        // Purchase and stock
        private string quantityPerUnit;
        private float unitPrice;
        private float salesPrice;
        private int unitOnStock;
        private int unitOnOrder;
        private float _VAT;
        #endregion
        #region Property
        public string PID { get => _PID; set => _PID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string QuantityPerUnit { get => quantityPerUnit; set => quantityPerUnit = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public float SalesPrice { get => salesPrice; set => salesPrice = value; }
        public int UnitOnStock { get => unitOnStock; set => unitOnStock = value; }
        public int UnitOnOrder { get => unitOnOrder; set => unitOnOrder = value; }
        public float VAT { get => _VAT; set => _VAT = value; }
        public IEnumerable<SupplierModel> Suppliers { get; set; }
        public IEnumerable<CategoryModel> Categoires { get; set; }
        #endregion
    }
}

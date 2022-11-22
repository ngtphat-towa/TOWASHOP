using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private string barcode;
        // Purchase and stock
        private string quantityPerUnit;
        private double unitPrice;
        private double salesPrice;
        private int unitOnStock;
        private int unitOnOrder;
        private double _VAT;
        private string status;
        private string content;
        #endregion
        #region Property
        [DisplayName ("PID")]
        public string PID { get => _PID; set => _PID = value; }
        [DisplayName("Name")]
        public string ProductName { get => productName; set => productName = value; }
        [DisplayName("Suplier")]
        public string SupplierName
        {
            get
            {
                return Supplier.SupplierName;
            }
        }
        [DisplayName("Category")]
        public string CategoryName
        {
            get
            {
                return Category.CategoryName;
            }
        }
        [DisplayName ("Barcode")]
        [Browsable(false)]
        public string Barcode { get => barcode; set => barcode = value; }
        [DisplayName("QPUnit")]
        public string QuantityPerUnit { get => quantityPerUnit; set => quantityPerUnit = value; }
        [DisplayName("Unit Price")]
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        [DisplayName("Sales Price")]
        public double SalesPrice { get => salesPrice; set => salesPrice = value; }
        [DisplayName("Stock Quantity")]
        public int UnitOnStock { get => unitOnStock; set => unitOnStock = value; }
        [DisplayName("Sold Quantity ")]
        public int UnitOnOrder { get => unitOnOrder; set => unitOnOrder = value; }
        [DisplayName("VAT")]
        public double VAT { get => _VAT; set => _VAT = value; }
        [DisplayName("Status")]
        public string Status { get => status; set => status = value; }
        [Browsable(false)]
        [DisplayName("Content")]
        public string Content { get => content; set => content = value; }

        [Browsable(false)]
        public virtual SupplierModel Supplier { get; set; }
        [Browsable(false)]
        public virtual CategoryModel Category { get; set; }
        #endregion
    }
}

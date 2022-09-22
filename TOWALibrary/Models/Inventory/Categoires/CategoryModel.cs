using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Products;

namespace TOWALibrary.Models.Inventory.Categoires
{
    public class CategoryModel
    {
        #region Private Fields
        private int _CATEID;
        private string categoryName;
        private string description;
        private string content;

        #endregion
        #region Property
        public int CATEID { get => _CATEID; set => _CATEID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string Description { get => description; set => description = value; }
        public string Content { get => content; set => content = value; }
        public IEnumerable<ProductModel> Products { get; set; }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

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
        [DisplayName("CID")]
        public int CATEID { get => _CATEID; set => _CATEID = value; }
        [DisplayName("Name")]
        public string CategoryName { get => categoryName; set => categoryName = value; }
        [DisplayName("Description")]
        public string Description { get => description; set => description = value; }

        [DisplayName("Comment")]
        public string Content { get => content; set => content = value; }

        [Browsable(false)]
        public virtual ICollection<ProductModel> Products { get; set; }

        [DisplayName("Products")]
        public string ProductIDList
        {
            get
            {
                if (Products == null || this.Products.ToList().Count==0)
                    return "";
                return string.Join(",", Products.ToList().Select(p => p.PID).ToArray());
            }
        }

        #endregion
    }
}

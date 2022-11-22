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

        [DisplayName("#Category ID")]
        public int CATEID { get => _CATEID; set => _CATEID = value; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(255, ErrorMessage = "The maximum length of the comment is 255 characters.")]
        public string CategoryName { get => categoryName; set => categoryName = value; }

        [DisplayName("Description")]
        [StringLength(60, ErrorMessage = "The maximum length of the description is 60 characters.")]
        public string Description { get => description; set => description = value; }

        [DisplayName("Comment")]
        [StringLength(255, ErrorMessage = "The maximum length of the comment is 255 characters.")]
        public string Content { get => content; set => content = value; }

        [Browsable(false)]
        public virtual ICollection<ProductModel> Products { get; set; }

        #endregion
    }
}

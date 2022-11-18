using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Categoires;
using TOWALibrary.Repositories.Inventory.Categories;

namespace TOWALibrary.Services.CategoryServices
{
   public interface ICategoryModelServices : ICategoryRepository
    {
        void ValidateModel(CategoryModel model);
    }
}

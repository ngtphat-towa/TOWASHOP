using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Categoires;

namespace TOWALibrary.Repositories.Inventory.Categories
{
  public  interface ICategoryRepository
    {
        void Add(CategoryModel model);
        void Update(CategoryModel model);
        void Delete(string CID);
        IEnumerable<CategoryModel> GetAll();
        IEnumerable<CategoryModel> GetByValue(string value);
    }
}

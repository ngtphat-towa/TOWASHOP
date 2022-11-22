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
        void Delete(int CID);
        ICollection<CategoryModel> GetAll();
        ICollection<CategoryModel> GetByValue(string value);
    }
}

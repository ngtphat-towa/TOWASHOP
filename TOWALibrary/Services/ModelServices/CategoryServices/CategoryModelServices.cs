using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Models.Inventory.Categoires;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Inventory.Categories;
using TOWALibrary.Services.CommonServices;

namespace TOWALibrary.Services.CategoryServices
{
    public class CategoryModelServices : ICategoryModelServices
    {
        private readonly ICategoryRepository _categoryRepository = DBManager.CategoryRepository;
        public void Add(CategoryModel model)
        {
            _categoryRepository.Add(model);
        }

        public void Delete(int CID)
        {
            _categoryRepository.Delete(CID);
        }

        public ICollection<CategoryModel> GetAll()
        {
           return _categoryRepository.GetAll();
        }

        public ICollection<CategoryModel> GetByValue(string value)
        {
            return _categoryRepository.GetByValue(value);

        }

        public void Update(CategoryModel model)
        {
            _categoryRepository.Update(model);
        }

        public void ValidateModel(CategoryModel model)
        {
            ModelDataValidationCheck.Validate(model);
            //var models = _categoryRepository.GetAll().FirstOrDefault(c=>c.CategoryName == model.CategoryName);
            //if (models != null)
            //    throw new Exception("This category name already exits! \n Category name must be unique");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Inventory.Categoires;
using TOWALibrary.Repositories.Inventory.Categories;
using TOWALibrary.Services.CategoryServices;
using TOWALibrary.Services.CommonServices;
using TOWALibrary.Views.ModuleViews.Inventory;

namespace TOWALibrary.Presenters.Modules.Inventory.Categories
{
   public class CategoryModulePresenter
    {
        private readonly ICategoryModuleView _view;
        private BindingSource _categoryBindingSource;
        private ICollection<CategoryModel> _categoryList;

        private readonly ICategoryModelServices _categoryServices = ServicesManager.CategoryModelServices;

        public CategoryModulePresenter(ICategoryModuleView view)
        {
            _view = view;
            this._categoryBindingSource = new BindingSource();
            //Wire up event handler methods to view events
            _view.SearchEvent += SearchCategory;
            _view.AddNewEvent += AddNewCategory;
            _view.EditEvent += LoadSelectedCategoryToEdit;
            _view.DeleteEvent += DeleteSelectedCategory;
            _view.SaveEvent += SaveCategory;
            _view.CancelEvent += CancelAction;
            //Set binding source
            _view.SetListViewBindingSource(_categoryBindingSource);
            LoadAllCategoryList();
            
        }

        private void LoadAllCategoryList()
        {
            _categoryBindingSource.DataSource = _categoryServices.GetAll() ;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFeilds();
        }

        private void SaveCategory(object sender, EventArgs e)
        {
            var model = new CategoryModel
            {
                CATEID = _view.CATEID,
                CategoryName = _view.CategoryName,
                Description = _view.Description,
                Content = _view.Content
            };
            try
            {
                _categoryServices.ValidateModel(model);

                if (_view.IsEdit == true)
                {
                    _categoryServices.Update(model);
                    _view.Message = "Category updated successfully!";
                }
                else
                {
                    _categoryServices.Add(model);
                    _view.Message = "Category added successfully!";
                }
                _view.IsSuccessful = true;
                LoadAllCategoryList();
                CleanViewFeilds();

            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void DeleteSelectedCategory(object sender, EventArgs e)
        {
            try
            {
                var model = (CategoryModel)_categoryBindingSource.Current;
                _categoryServices.Delete(model.CATEID);
                _view.IsSuccessful = true;
                _view.Message = "Category deleted successfully";
                LoadAllCategoryList();
            }
            catch (Exception )
            {
                _view.IsSuccessful = false;
                _view.Message = "An error occurred, could not delete this category " ;
            }
        }

        private void LoadSelectedCategoryToEdit(object sender, EventArgs e)
        {
            CategoryModel model = (CategoryModel)_categoryBindingSource.Current;
            _view.CATEID = model.CATEID;
            _view.CategoryName = model.CategoryName;
            _view.Description = model.Description;
            _view.Content = model.Content;
            _view.IsEdit = true;
        }

        private void AddNewCategory(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

        private void SearchCategory(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(_view.SearchValue);
            if (emptyValue == false)
                _categoryList = _categoryServices.GetByValue(_view.SearchValue);
            else
                _categoryList = _categoryServices.GetAll();
            _categoryBindingSource.DataSource = _categoryList;
        }
        private void CleanViewFeilds()
        {
            _view.CATEID = 0;
            _view.CategoryName = "";
            _view.Description = "";
            _view.Content = "";
        }
    }
}

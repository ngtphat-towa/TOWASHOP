using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Inventory.Categoires;
using TOWALibrary.Repositories.Inventory.Categories;
using TOWALibrary.Views.ModuleViews.Inventory;

namespace TOWALibrary.Presenters.Modules.Inventory.Categories
{
   public class CategoryModulePresenter
    {
        private readonly ICategoryModuleView view;
        private readonly ICategoryRepository repository;
        private BindingSource categoryBindingSource;
        private ICollection<CategoryModel> categoryList;

        public CategoryModulePresenter(ICategoryModuleView view, ICategoryRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.categoryBindingSource = new BindingSource();
            //Wire up event handler methods to view events
            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategory;
            this.view.EditEvent += LoadSelectedCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SaveCategory;
            this.view.CancelEvent += CancelAction;
            //Set binding source
            this.view.SetListViewBindingSource(categoryBindingSource);
            LoadAllCategoryList();
            //Show view
            this.view.Show();
        }

        private void LoadAllCategoryList()
        {
            categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFeilds();
        }

      

        private void SaveCategory(object sender, EventArgs e)
        {
            var model = new CategoryModel
            {
                CATEID = view.CATEID,
                CategoryName = view.CategoryName,
                Description = view.Description,
                Content = view.Content
            };
            try
            {
                // TODO - Vailidate the model 
                if (view.IsEdit == true)
                {
                    repository.Update(model);
                    view.Message = "Category updated successfully!";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Category added successfully!";
                }
                view.IsSuccessful = true;
                LoadAllCategoryList();
                CleanViewFeilds();

            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void DeleteSelectedCategory(object sender, EventArgs e)
        {
            try
            {
                var model = (CategoryModel)categoryBindingSource.Current;
                repository.Delete(model.CATEID.ToString());
                view.IsSuccessful = true;
                view.Message = "Category deleted successfully";
                LoadAllCategoryList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "An error occurred, could not delete this category";
            }
        }

        private void LoadSelectedCategoryToEdit(object sender, EventArgs e)
        {
            CategoryModel model = (CategoryModel)categoryBindingSource.Current;
            this.view.CATEID = model.CATEID;
            this.view.CategoryName = model.CategoryName;
            this.view.Description = model.Description;
            this.view.Content = model.Content;
            view.IsEdit = true;
        }

        private void AddNewCategory(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCategory(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);
            if (emptyValue == false)
                categoryList = repository.GetByValue(this.view.SearchValue);
            else
                categoryList = repository.GetAll();
            categoryBindingSource.DataSource = categoryList;
        }
        private void CleanViewFeilds()
        {
            this.view.CATEID = 0;
            this.view.CategoryName = "";
            this.view.Description = "";
            this.view.Content = "";
        }
    }
}

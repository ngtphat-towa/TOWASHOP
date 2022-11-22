using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Views.ModelListViewRequester;

namespace TOWALibrary.Views.ModelListVew
{
    public interface IProductListView
    {

        event EventHandler SearchFilterChangedEvent;
        event EventHandler AddProductEvent;
        event EventHandler CancelAddEvent;
        string SearchValue { get; set; }
        string SLID { get; set; }
        int CTID { get; set; }
        string PID { get; set; }
        double Discount { get; set; }
        int Quantity { get; set; }
        bool IsValueSearch { get; set; }
        bool IsMultipleAdded { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        IProductListViewRequestor CallingForm { get; }
        void SetSupplierNameListBindingSource(BindingSource bindingSource);
        void SetCategoryListBindlingSource(BindingSource bindingSource);
        void SetProductListBindingSource(BindingSource bindingSource);
        void Hide();
        void Dispose();
        void Show();

    }
}

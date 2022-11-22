using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Presenters.Modules.Orders;
using TOWALibrary.Views.ModelListVew;
using TOWALibrary.Views.ModelListViewRequester;

namespace TOWALibrary.Views.ModuleViews.Orders.OrderDetails
{
   public interface IOrderFormView :IProductListViewRequestor
    {
        event EventHandler ShowProductListEvent;
        
        event EventHandler SelectedOrderDetailChangedEvent;
        event EventHandler BarcodeIDChangedEvent;
        event EventHandler AddNewProductOrderEvent;
        event EventHandler RemoveSelectedOrderItemsEvent;
        event EventHandler EditOrderDetailValueEvent;
        event EventHandler ResetOrderDetailListEvent;
        event EventHandler SaveOrderEvent;
        event EventHandler OrderTypeChangedEvent;
        event EventHandler LoadEditOrderFormEvent;

        #region Order Type/Status 
        string CreatedByUID { get; set; }
        int OID { get; set; }
        int OrderType { get; set; }
        int OrderStatus { get; set; }
        int PaymentMethod  { get; set; }
        string CustomerPhone { get; set; }
        string SupplierPhone { get; set; }
        double DiscountValue { get; set; }
        int QuantityValue { get; set; }

        DateTime CreatedAt { get; set; }

        string Comments { get; set; }

        bool IsEditMode { get; set; }
        string Message { get; set; }
        bool IsSuccessful { get; set; }
        
        double Total { get; set; }
        double GrandTotal { get; set; }
        double TotalDiscount { get; set; }

        UserControl CustomerOrderInfoControl { get; }
        UserControl SupplierOrderInfoControl { get; }
        IProductListView ProductListView { get; }
        IOrderFormRequest CallingForm { get; set; }

        // Customer
        string SLID { get; set; }
        // Suppler
        string CTID { get; set; }

        #endregion
        #region Function
        void LoadOrderToEdit();
        void SetProductOrderDetailBindingSource(BindingSource bindingSource);
        void SetCustomerNameListDetailBindingSource(BindingSource bindingSource);
        void SetSupplierNameListDetailBindingSource(BindingSource bindingSource);
        void SetOrderInfoControl(UserControl userControl);
        #endregion
        void Show();
        void Close();

    }
}

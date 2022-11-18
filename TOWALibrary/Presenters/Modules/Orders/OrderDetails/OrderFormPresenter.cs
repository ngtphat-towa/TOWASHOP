using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Models.Order.OrderDetails;
using TOWALibrary.Models.Order.Orders;
using TOWALibrary.Models.Order.OrderType;
using TOWALibrary.Presenters.ModelListVew;
using TOWALibrary.Repositories;
using TOWALibrary.Repositories.Contacts.Customers;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Repositories.Inventory.Products;
using TOWALibrary.Repositories.Order.OrderDetails;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Services.CategoryServices;
using TOWALibrary.Services.CommonServices;
using TOWALibrary.Services.ModelServices.CustomerServices;
using TOWALibrary.Services.ModelServices.OrderDetailServices;
using TOWALibrary.Services.ModelServices.OrderServices;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.Order;
using TOWALibrary.Services.ModelServices.ProductServices;
using TOWALibrary.Services.ModelServices.SupplierServices;
using TOWALibrary.Views.ModuleViews.Orders.OrderDetails;

namespace TOWALibrary.Presenters.Modules.Orders.OrderDetails
{
    public class OrderFormPresenter
    {
        private readonly IOrderFormView _view;
        private readonly IOrderServices _orderServices ;
        private readonly IOrderDetailModelServices _orderDetailModelServices ;

        private readonly IProductModelServices _productModelServices;
        private readonly ICategoryModelServices _categoryModelServices;

        private readonly ICustomerModelServices _customerModelServices;
        private readonly ISupplierModelServices _supplierModelServices ;


        private readonly List<OrderDetailModel> _orderDetailModels;
        private BindingSource _orderDetailBindingSource;
        private BindingSource _supplierBindingSource;
        private BindingSource _customerBindingSource;


        public OrderFormPresenter(IOrderFormView view,
                                  IOrderServices orderServices,
                                  IOrderDetailModelServices orderDetailModelServices,
                                  IProductModelServices productModelServices,
                                  ICategoryModelServices categoryModelServices,
                                  ICustomerModelServices customerModelServices,
                                  ISupplierModelServices supplierModelServices)
        {
            
            _view = view;
            //Intialize Services
            _orderServices = orderServices;
            _orderDetailModelServices = orderDetailModelServices;
            _customerModelServices = customerModelServices;
            _productModelServices = productModelServices;
            _categoryModelServices = categoryModelServices;
            _supplierModelServices = supplierModelServices;
            _customerModelServices = customerModelServices;
            //Intialize Current User
            _view.CreatedByUID = GlobalConfig.CurrentUser.UID;
            // Wire up lists and binding sources
            _orderDetailBindingSource = new BindingSource();
            _supplierBindingSource = new BindingSource();
            _customerBindingSource = new BindingSource();

            _orderDetailModels = new List<OrderDetailModel>();
            // Wire up eventhandler of the view
            _view.OrderTypeChangedEvent += OrderTypeChangedEvent;
            _view.AddNewProductOrderEvent += AddNewProductOrderEvent;
            _view.ShowProductListEvent += ShowProductListEvent;
            _view.SelectedOrderDetailChangedEvent += SelectedOrderDetailChangedEvent;
            _view.EditOrderDetailValueEvent += EditOrderDetailValueEvent;
            _view.SaveOrderEvent += SaveOrderEvent;

            //

            // Wire up for new order
            _orderDetailBindingSource.DataSource = _orderDetailModels;
            _view.SetProductOrderDetailBindingSource(_orderDetailBindingSource);

            _supplierBindingSource.DataSource = _supplierModelServices.GetAll()
                .Select(s => new { ID = s.SLID, Name = s.SupplierName, Phone = s.ContactPhone }).ToList();
            _view.SetSupplierNameListDetailBindingSource(_supplierBindingSource);
           
            _customerBindingSource.DataSource = _customerModelServices.GetAll()
                .Select(s => new { ID = s.CTID, Name = s.FullName, Phone = s.ContactPhone }).ToList();
            _view.SetCustomerNameListDetailBindingSource(_customerBindingSource);
        }

        private void OrderDetailValueChangedEvent( )
        {
            _view.Total = _orderDetailModelServices.GetTotalCost(_orderDetailModels);
            _view.GrandTotal = _orderDetailModelServices.GetGrandTotal(_orderDetailModels);
            _view.TotalDiscount = Convert.ToDouble(_view.GrandTotal)/Convert.ToDouble(_view.Total);

        }

        private void SaveOrderEvent(object sender, EventArgs e)
        {
            switch (_view.OrderType)
            {
                case 0:
                    SaveRetailOrder();
                    break;
                case 1:
                    SaveCustomerOrder();
                    break;
                case 2:
                    SaveStockOrder();
                    break;
                default:
                    break;
            }
            _view.IsSuccessful = true;
            _view.Message = "Order added successfully";
        }

        private void SaveStockOrder()
        {
            StockOrderModel model = new StockOrderModel();
            //Intial Info
            model.OID = _view.OID;
            model.CreatedByUID = _view.CreatedByUID;
            model.CreatedBy = GlobalConfig.CurrentUser;

            // OrderType Info
            model.OrderType = _view.OrderType;
            model.PaymentMethod = _view.PaymentMethod;
            // General info
            model.OrderDetails = _orderDetailModels;
            model.Total = _view.Total;
            model.GrandTotal = _view.GrandTotal;
            //meta
            model.Status = _view.OrderStatus;
            model.Comments = _view.Comments;

            // Customer Info 
            model.SO_SLID = _view.SLID;
            model.Supplier = _supplierModelServices.GetByValue(_view.SLID).FirstOrDefault();
            // Check Model
            _orderServices.StockOrderModelServices.ValidateModel(model);
            if (!_view.IsEditMode)
            {
                model.CreatedAt = DateTime.Now;
                model.UpdatedAt = DateTime.Now;
                _orderServices.StockOrderModelServices.Add(model);

            }
            else
            {
                model.UpdatedAt = DateTime.Now;
                _orderServices.StockOrderModelServices.Update(model);
            }

        }

        private void SaveCustomerOrder()
        {
            CustomerOrderModel model = new CustomerOrderModel();
            //Intial Info
            model.OID = _view.OID;
            model.CreatedByUID = _view.CreatedByUID;
            model.CreatedBy = GlobalConfig.CurrentUser;

            // OrderType Info
            model.OrderType = _view.OrderType;
            model.PaymentMethod = _view.PaymentMethod;
            // General info
            model.OrderDetails = _orderDetailModels;
            model.Total = _view.Total;
            model.GrandTotal = _view.GrandTotal;
            //meta
            model.Status = _view.OrderStatus;
            model.Comments = _view.Comments;
   
            // Customer Info 
            model.CO_CTID = _view.CTID;
            model.Customer = _customerModelServices.GetByValue(_view.CTID).FirstOrDefault();
            // Check Model
            _orderServices.CustomerOrderModelServices.ValidateModel(model);
            if (!_view.IsEditMode)
            {
                model.CreatedAt = DateTime.Now;
                model.UpdatedAt = DateTime.Now;
                _orderServices.CustomerOrderModelServices.Add(model);

            }
            else
            {
                model.UpdatedAt = DateTime.Now;
                _orderServices.CustomerOrderModelServices.Update(model);
            }
        }

        private void SaveRetailOrder()
        {
            OrderModel model = new OrderModel();
            //Intial Info
            model.OID = _view.OID;
            model.CreatedByUID = _view.CreatedByUID ;
            model.CreatedBy = GlobalConfig.CurrentUser;

            // OrderType Info
            model.OrderType = _view.OrderType;
            model.PaymentMethod = _view.PaymentMethod;
            // General info
            model.OrderDetails = _orderDetailModels;
            model.Total = _view.Total;
            model.GrandTotal = _view.GrandTotal;
            //meta
            model.Status = _view.OrderStatus;
            model.Comments = _view.Comments;
            // Check Model
            _orderServices.OrderModelServices.ValidateModel(model);
            // 
            if (!_view.IsEditMode)
            {
                model.CreatedAt = DateTime.Now;
                model.UpdatedAt = DateTime.Now;
                _orderServices.OrderModelServices.Add(model);

            }
            else
            {
                model.UpdatedAt = DateTime.Now;
                _orderServices.OrderModelServices.Update(model);

            }
        }

        private void EditOrderDetailValueEvent(object sender, EventArgs e)
        {
            try
            {
                if (_orderDetailBindingSource.Current ==null || _orderDetailBindingSource.Count == 0)
                    throw new Exception("The current list of order items is empty. \n Please sellect new product!");

                // Validate changed OrderDetail values - Quantity
                string PID = ((OrderDetailModel)_orderDetailBindingSource.Current).OD_PID;
                _productModelServices.ValidateProductQuantity(PID,_view.QuantityValue);
                // Discount Range
                _productModelServices.ValidateOrderDiscount(_view.DiscountValue);

                var current = _orderDetailModels.First(p => p.OD_PID == PID);
                current.Quantity = _view.QuantityValue;
                current.Discount = _view.DiscountValue;

                _orderDetailBindingSource.DataSource = null;
                _orderDetailBindingSource.DataSource = _orderDetailModels;

                OrderDetailValueChangedEvent();

                _view.IsSuccessful = true;
                _view.Message = "";
            }
            catch (Exception ex)
            {

                _view.IsSuccessful = false;
                _view.Message = ex.Message;

                _view.DiscountValue = 0;
                _view.QuantityValue = 1;
            }
          
        }

        private void SelectedOrderDetailChangedEvent(object sender, EventArgs e)
        {
            if (_orderDetailBindingSource.DataSource == null)
                return;
            OrderDetailModel model = (OrderDetailModel)_orderDetailBindingSource.Current;
            _view.DiscountValue = model.Discount;
            _view.QuantityValue = model.Quantity;
        }
 
        private void ShowProductListEvent(object sender, EventArgs e)
        {

            _view.ProductListView.Show();
        }

        //event EventHandler AddNewEvent;
        //event EventHandler EditEvent;
        //event EventHandler RefreshEvent;
        //event EventHandler OrderTypeChangedEvent;

        private void AddNewProductOrderEvent(object sender, EventArgs e)
        {
            
            OrderDetailModel model;
            if(_orderDetailModels.Any(p=> _view.OD_PID.Equals(p.OD_PID))){
                model = _orderDetailModels.FirstOrDefault(p => _view.OD_PID.Equals(p.OD_PID));
                model.Quantity += _view.OD_Quantity;
            }
            else
            {
                model = new OrderDetailModel
                {
                    OD_PID = _view.OD_PID,
                    Product = _productModelServices.GetByValue(_view.OD_PID).FirstOrDefault(),
                    Quantity = _view.OD_Quantity,
                };
                _orderDetailModels.Add(model);
            }
            model.Discount = _view.OD_Discount;
            model.UnitPrice = model.Product.SalesPrice;


            _orderDetailBindingSource.DataSource = null;


            _orderDetailBindingSource.DataSource = _orderDetailModels;

            OrderDetailValueChangedEvent();
        }
        

        private void OrderTypeChangedEvent(object sender, EventArgs e)
        {
            switch (_view.OrderType)
            {
                case 1:
                    _view.SetOrderInfoControl(_view.CustomerOrderInfoControl);
                    break;
                case 2:
                    _view.SetOrderInfoControl(_view.SupplierOrderInfoControl);
                    break;
                default:
                    break;
            }
        }
    }
}

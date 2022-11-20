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
        // Services
        private readonly IOrderServices _orderServices  = ServicesManager.OrderServices;
        private readonly IOrderDetailModelServices _orderDetailModelServices = ServicesManager.OrderDetailModelServices;

        private readonly IProductModelServices _productModelServices = ServicesManager.ProductModelServices;

        private readonly ICustomerModelServices _customerModelServices= ServicesManager.CustomerModelServices;
        private readonly ISupplierModelServices _supplierModelServices  = ServicesManager.SupplierModelServices;


        private List<OrderDetailModel> _orderDetailModels;
        private List<OrderDetailModel> _LoadOrderDetailModels;
        private BindingSource _orderDetailBindingSource;
        private BindingSource _supplierBindingSource;
        private BindingSource _customerBindingSource;


        public OrderFormPresenter(IOrderFormView view)
        {
            
            _view = view;
            //Intialize Current User
            _view.CreatedByUID = GlobalConfig.CurrentUser.UID;
            // Wire up lists and binding sources
            _orderDetailBindingSource = new BindingSource();
            _supplierBindingSource = new BindingSource();
            _customerBindingSource = new BindingSource();

            _orderDetailModels = new List<OrderDetailModel>();
            _LoadOrderDetailModels = new List<OrderDetailModel>();
            // Wire up eventhandler of the view
            _view.OrderTypeChangedEvent += OrderTypeChangedEvent;
            _view.AddNewProductOrderEvent += AddNewProductOrderEvent;
            _view.ShowProductListEvent += ShowProductListEvent;
            _view.SelectedOrderDetailChangedEvent += SelectedOrderDetailChangedEvent;
            _view.EditOrderDetailValueEvent += EditOrderDetailValueEvent;
            _view.SaveOrderEvent += SaveOrderEvent;
            _view.LoadEditOrderFormEvent += LoadEditOrderFormEvent;
            _view.RemoveSelectedOrderItemsEvent += RemoveSelectedOrderItemsEvent;
            _view.ResetOrderDetailListEvent += ResetOrderDetailListEvent;
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

        private void ResetOrderDetailListEvent(object sender, EventArgs e)
        {
            _orderDetailModels = new List<OrderDetailModel>();
            if (_view.IsEditMode)
            {
                _LoadOrderDetailModels.ForEach(p => p.Status = OrderDetailStatus.Load);
                _orderDetailModels = new List<OrderDetailModel>(_LoadOrderDetailModels);
            }

            SetOrderDetailListChanged();
            OrderDetailValueChangedEvent();
        }
        #region Event Handler
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
        private void AddNewProductOrderEvent(object sender, EventArgs e)
        {

            OrderDetailModel model;
            if (_orderDetailModels.Any(p => _view.OD_PID.Equals(p.OD_PID)))
            {
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
                model.Status = OrderDetailStatus.New;
                _orderDetailModels.Add(model);
            }
            model.Discount = _view.OD_Discount;
            model.UnitPrice = model.Product.SalesPrice;

            if (_view.IsEditMode && _LoadOrderDetailModels.Any(p => p.OD_PID == model.OD_PID))
                model.Status = OrderDetailStatus.Modify;


            SetOrderDetailListChanged();
            OrderDetailValueChangedEvent();
        }
        private void ShowProductListEvent(object sender, EventArgs e)
        {

            _view.ProductListView.Show();
        }

        private void SelectedOrderDetailChangedEvent(object sender, EventArgs e)
        {
            if (_orderDetailBindingSource.DataSource == null || _orderDetailBindingSource.Count == 0)
                return;
            OrderDetailModel model = (OrderDetailModel)_orderDetailBindingSource.Current;
            if (model == null)
                return;
            _view.DiscountValue = model.Discount;
            _view.QuantityValue = model.Quantity;
        }
        private void EditOrderDetailValueEvent(object sender, EventArgs e)
        {
            try
            {
                var PID = "";
                ValidateOrderDetailCurent(out PID);

                // Validate changed OrderDetail values - Quantity
                ValidateOrderDetailValue(PID);

                var current = _orderDetailModels.First(p => p.OD_PID == PID);
                current.Quantity = _view.QuantityValue;
                current.Discount = _view.DiscountValue;

                //TODO Update Status
                if (_view.IsEditMode && _LoadOrderDetailModels.Any(p => p.OD_PID == current.OD_PID))
                    current.Status = OrderDetailStatus.Modify;

                SetOrderDetailListChanged();

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
        private void SaveOrderEvent(object sender, EventArgs e)
        {

            try
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
                if (_view.CallingForm != null)
                    _view.CallingForm.SaveComplete();
                _view.Close();
            }
            catch (Exception ex)
            {
                _view.Message = "Saved order failed. \n"+ ex.Message;
                _view.IsSuccessful = false;
            }

        }
        private void LoadEditOrderFormEvent(object sender, EventArgs e)
        {
            switch (_view.OrderType)
            {
                case 0:
                    var orderModel = _orderServices.OrderModelServices.GetByValue(_view.OID.ToString()).FirstOrDefault();

                    LoadOrderInfo(orderModel);
                    break;
                case 1:
                    var customerOrderModel = _orderServices.CustomerOrderModelServices.GetByValue(_view.OID.ToString()).FirstOrDefault();

                    _view.CTID = customerOrderModel.CO_CTID;
                    LoadOrderInfo(customerOrderModel);
                    break;
                case 2:
                    var stockOrderModel = _orderServices.StockOrderModelServices.GetByValue(_view.OID.ToString()).FirstOrDefault();

                    _view.SLID = stockOrderModel.SO_SLID;
                    LoadOrderInfo(stockOrderModel);
                    break;
                default:
                    break;
            }
        }
        private void RemoveSelectedOrderItemsEvent(object sender, EventArgs e)
        {
            try
            {
                var PID = "";
                ValidateOrderDetailCurent(out PID);

                var current = _orderDetailModels.Where(p => p.Status != OrderDetailStatus.Remove).First(p => p.OD_PID == PID);

                if (_view.IsEditMode && _LoadOrderDetailModels.Any(p => p.OD_PID == current.OD_PID))
                    current.Status = OrderDetailStatus.Remove;
                else
                    _orderDetailModels.Remove(current);

                SetOrderDetailListChanged();
                OrderDetailValueChangedEvent();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion



        private void SetOrderDetailListChanged()
        {
            _orderDetailBindingSource.DataSource = null;
            var list = _orderDetailModels.Where(p => p.Status != OrderDetailStatus.Remove).ToList();
            if(list.Count>0)
            _orderDetailBindingSource.DataSource = list;
        }

      

        private void LoadOrderInfo(OrderModel orderModel)
        {
            
            _LoadOrderDetailModels = orderModel.OrderDetails.ToList();
            _orderDetailModels = new List<OrderDetailModel>(_LoadOrderDetailModels);

            _view.CreatedAt = orderModel.CreatedAt;

            SetOrderDetailListChanged();
            OrderDetailValueChangedEvent();
        }

        private void OrderDetailValueChangedEvent( )
        {
            var list = _orderDetailModels.Where(p => p.Status != OrderDetailStatus.Remove).ToList();
            _view.Total = _orderDetailModelServices.GetTotalCost(list);
            _view.GrandTotal = _orderDetailModelServices.GetGrandTotal(list);
            _view.TotalDiscount = 1-Convert.ToDouble(_view.GrandTotal)/Convert.ToDouble(_view.Total);

        }

        #region Save Order By Type
        private void SaveRetailOrder()
        {
            OrderModel model = new OrderModel();
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
                model.CreatedAt = _view.CreatedAt;
                model.UpdatedAt = DateTime.Now;
                var oldModel = _orderServices.OrderModelServices.GetByValue(model.OID.ToString()).FirstOrDefault();
                _orderServices.OrderModelServices.Update(oldModel, model);

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
                model.CreatedAt = _view.CreatedAt;
                model.UpdatedAt = DateTime.Now;
                var oldModel = _orderServices.CustomerOrderModelServices.GetByValue(model.OID.ToString()).FirstOrDefault();
                _orderServices.CustomerOrderModelServices.Update(oldModel, model);
            }
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
                model.CreatedAt = _view.CreatedAt;
                model.UpdatedAt = DateTime.Now;
                var oldModel = _orderServices.StockOrderModelServices.GetByValue(model.OID.ToString()).FirstOrDefault();
                _orderServices.StockOrderModelServices.Update(oldModel, model);
            }

        }
        #endregion


        #region Private Validation
        private void ValidateOrderDetailCurent(out string PID)
        {
            if (_orderDetailBindingSource.Current == null || _orderDetailBindingSource.Count == 0)
                throw new Exception("The current list of order items is empty. \n Please sellect new product!");
            PID = ((OrderDetailModel)_orderDetailBindingSource.Current).OD_PID;
        }
        private void ValidateOrderDetailValue(string PID)
        {
            if (_view.OrderType != 2)// Stock 
                _productModelServices.ValidateProductQuantity(PID, _view.QuantityValue);
            else
                   if (_view.QuantityValue <= 0)
                throw new Exception("The stock must be larger 1 items");
            // Discount Range
            _productModelServices.ValidateOrderDiscount(_view.DiscountValue);
        }
        #endregion










    }
}

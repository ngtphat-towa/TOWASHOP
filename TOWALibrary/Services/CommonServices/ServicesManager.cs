using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Services.CategoryServices;
using TOWALibrary.Services.ModelServices.CustomerServices;
using TOWALibrary.Services.ModelServices.OrderDetailServices;
using TOWALibrary.Services.ModelServices.OrderServices;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.CustomerOrder;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.Order;
using TOWALibrary.Services.ModelServices.OrderServices.OrderType.StockOrder;
using TOWALibrary.Services.ModelServices.ProductServices;
using TOWALibrary.Services.ModelServices.SupplierServices;

namespace TOWALibrary.Services.CommonServices
{
    public static class ServicesManager
    {
        private static IProductModelServices productModelServices;
        public static IProductModelServices ProductModelServices
        {
            get
            {
                if (productModelServices == null)
                {
                    productModelServices = new ProductModelServices();
                }
                return productModelServices;
            }
        }
        private static ICategoryModelServices categoryModelServices;
        public static ICategoryModelServices CategoryModelServices
        {
            get
            {
                if (categoryModelServices == null)
                {
                    categoryModelServices = new CategoryModelServices();
                }
                return categoryModelServices;
            }
        }
        private static ICustomerModelServices customerModelServices;
        public static ICustomerModelServices CustomerModelServices
        {
            get
            {
                if (customerModelServices == null)
                {
                    customerModelServices = new CustomerModelServices();
                }
                return customerModelServices;
            }
        }
        private static ISupplierModelServices supplierModelServices;
        public static ISupplierModelServices SupplierModelServices
        {
            get
            {
                if (supplierModelServices == null)
                {
                    supplierModelServices = new SupplierModelServices();
                }
                return supplierModelServices;
            }
        }



        private static IOrderServices orderServices;
        public static IOrderServices OrderServices
        {
            get
            {
                if (orderServices == null)
                {
                    orderServices = new OrderServices();
                }
                return orderServices;
            }
        }

        private static IStockOrderModelServices stockOrderServices;
        public static IStockOrderModelServices StockOrderModelServices
        {
            get
            {
                if (stockOrderServices == null)
                {
                    stockOrderServices = new StockOrderModelServices();
                }
                return stockOrderServices;
            }
        }
        private static ICustomerOrderModelServices customerOrderServices;
        public static ICustomerOrderModelServices CustomerOrderModelServices
        {
            get
            {
                if (customerOrderServices == null)
                {
                    customerOrderServices = new CustomerOrderModelServices();
                }
                return customerOrderServices;
            }
        }
        private static IOrderModelServices orderModelServices;
        public static IOrderModelServices OrderModelServices
        {
            get
            {
                if (orderModelServices == null)
                {
                    orderModelServices = new OrderModelServices();
                }
                return orderModelServices;
            }
        }
        private static IOrderDetailModelServices orderDetailModelServices;
        public static IOrderDetailModelServices OrderDetailModelServices
        {
            get
            {
                if (orderDetailModelServices == null)
                {
                    orderDetailModelServices = new OrderDetailModelServices();
                }
                return orderDetailModelServices;
            }
        }

        //ICustomerOrderModelServices customerOrderServices


        //IOrderDetailModelServices OrderDetailModelServices,
        //IProductModelServices productModelServices,
        //ICategoryModelServices CategoryModelServices,
        //ICustomerModelServices customerModelServices,
        //ISupplierModelServices supplierModelServices
    }
}

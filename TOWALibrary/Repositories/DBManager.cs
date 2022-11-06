using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOWALibrary.Presenters.Modules.Orders;
using TOWALibrary.Repositories.Accounts.Users;
using TOWALibrary.Repositories.Contacts.Customers;
using TOWALibrary.Repositories.Contacts.Suppliers;
using TOWALibrary.Repositories.DBConnector;
using TOWALibrary.Repositories.Inventory.Categories;
using TOWALibrary.Repositories.Inventory.Products;
using TOWALibrary.Repositories.Order.CustomerOrder;
using TOWALibrary.Repositories.Order.OrderDetails;
using TOWALibrary.Repositories.Order.Orders;
using TOWALibrary.Repositories.Order.SupplyOrders;

namespace TOWALibrary.Repositories
{

    public enum DataProvider
    {
        SQLServer,
        MySQL
    }
   public static class DBManager
    {
        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static IDBConnector Connection { get; private set; }

        public static void InitializeConnections(DataProvider db)
        {
            switch (db)
            {
                case DataProvider.SQLServer:
                    Connection = SqlDBConnector.GetInstance() ;

                   
                    break;
                case DataProvider.MySQL:
                    Connection = MySqlDBConnector.GetInstance();
                    break;
            }
        }

        private static IProductRepository productRepository;
        
        public static IProductRepository ProductRepository
        {
            get
            {
                if (productRepository == null )
                {
                    productRepository = new ProductRepository();
                }
                return productRepository;
            }
        }

        private static ISupplierRepository supplierRepository;
        public static ISupplierRepository SupplierRepository
        {
            get
            {
                if (supplierRepository == null)
                {
                    supplierRepository = new SupplierRepository();
                }
                return supplierRepository;
            }
        }
        private static ICategoryRepository categoryRepository;
        public static ICategoryRepository CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository();
                }
                return categoryRepository;
            }
        }
        private static IOrderDetailRepository orderDetailRepository;
        public static IOrderDetailRepository OrderDetailRepository
        {
            get
            {
                if (orderDetailRepository == null)
                {
                    orderDetailRepository = new OrderDetailRepository();
                }
                return orderDetailRepository;
            }
        }
        private static IOrderRepository orderRepository;
        public static IOrderRepository OrderRepository
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new OrderRepository();
                }
                return orderRepository;
            }
        }
        private static IAccountRepository accountRepository;
        public static IAccountRepository AccountRepository
        {
            get
            {
                if (accountRepository == null)
                {
                    accountRepository = new AccountRepository();
                }
                return accountRepository;
            }
        }
        private static ICustomerRepository customerRepository;
        public static ICustomerRepository CustomerRepository
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new CustomerRepository();
                }
                return customerRepository;
            }
        }
        private static ICustomerOrderRepository customerOrderRepository;
        public static ICustomerOrderRepository CustomerOrderRepository
        {
            get
            {
                if (customerOrderRepository == null)
                {
                    customerOrderRepository = new CustomerOrderRepository();
                }
                return customerOrderRepository;
            }
        }
        private static IStockOrderRepository stockOrderRepository;
        public static IStockOrderRepository StockOrderRepository
        {
            get
            {
                if (stockOrderRepository == null)
                {
                    stockOrderRepository = new StockOrderRepository();
                }
                return stockOrderRepository;
            }
        }
    }
}
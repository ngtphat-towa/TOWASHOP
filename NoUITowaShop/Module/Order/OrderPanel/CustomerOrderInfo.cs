using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOWALibrary.Views.ModuleViews.Orders;

namespace NoUITowaShop
{
    public partial class CustomerOrderInfo : UserControl
    {
        public CustomerOrderInfo()
        {
            InitializeComponent();
        }
        
        public ComboBox CustomerList { get => this.cbCustomerListName;  }
        public TextBox PhoneNumber { get => this.txtPhoneNumber;}
        public Button AdvancedSearch { get => this.btnAdvancedSearch; }

        private static CustomerOrderInfo instance;

        public static CustomerOrderInfo Instance
        {
            get {

                if (instance == null)
                {
                    instance = new CustomerOrderInfo();
                    instance.BorderStyle = BorderStyle.None;
                    instance.Dock = DockStyle.Fill;
                }
                return instance;
            }
            
        }
        //public void SetCustomerNameBindingSource(BindingSource bindingSource)
        //{
        //    this.
        //}
    }
}

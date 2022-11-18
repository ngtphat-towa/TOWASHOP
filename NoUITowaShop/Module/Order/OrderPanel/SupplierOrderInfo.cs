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

namespace NoUITowaShop.Module.Order.OrderPanel
{
    public partial class SupplierOrderInfo : UserControl
    {
        public SupplierOrderInfo()
        {
            InitializeComponent();
        }
        public ComboBox SupplierList { get => this.cbSupplierListName; }
        public TextBox PhoneNumber { get => this.txtPhoneNumber; }
        public Button AdvancedSearch { get => this.btnAdvancedSearch; }


        private static SupplierOrderInfo instance;

        public static SupplierOrderInfo Instance
        {
            get
            {

                if (instance == null || instance.IsDisposed)
                {
                    instance = new SupplierOrderInfo();
                    instance.BorderStyle = BorderStyle.None;
                    instance.Dock = DockStyle.Fill;
                }
                return instance;
            }

        }
    }
}

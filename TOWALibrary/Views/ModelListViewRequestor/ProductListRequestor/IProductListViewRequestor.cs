using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOWALibrary.Views.ModelListViewRequester
{
    public interface IProductListViewRequestor
    {
        string OD_PID { get; set; }
        double OD_Discount { get; set; }
        int OD_Quantity { get; set; }
        void AddNewProductOrderToList();
    }
}

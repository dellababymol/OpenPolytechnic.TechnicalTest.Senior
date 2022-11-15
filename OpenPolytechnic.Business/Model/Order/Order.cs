using OpenPolytechnic.Business.Model.Order.Enum;
using System.Collections.Generic;

namespace OpenPolytechnic.Business.Model.Order
{
    public class Order
    {
        public CustomerType customerType { get; set; }     
        public List<int> MenuItemIds { get; set; }
        
    }
}

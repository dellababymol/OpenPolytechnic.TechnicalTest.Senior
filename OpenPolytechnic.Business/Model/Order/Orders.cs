using OpenPolytechnic.Business.Model.Order.Enum;
using System.Collections.Generic;

namespace OpenPolytechnic.Business.Model.Order
{
    public class Orders
    {
       public string MenuType { get; set; }
        public IEnumerable<Order> IndividualOrders { get; set; }
    }
}

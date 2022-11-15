using OpenPolytechnic.Business.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPolytechnic.Business.Services.Interfaces
{
    public interface IOrderService
    {
        OrderSummary PlaceOrders(Orders orders);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenPolytechnic.Business.Model.Order;

namespace OpenPolytechnic.Business.Factories
{
    public class OrderCostFactory
    {
        public OrderCost costFactory()
            { return new OrderCost(); }
    }
}

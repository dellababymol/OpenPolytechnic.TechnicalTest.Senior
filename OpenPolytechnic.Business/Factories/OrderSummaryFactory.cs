using OpenPolytechnic.Business.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPolytechnic.Business.Factories
{
    public class OrderSummaryFactory
    {
        public OrderSummary OrderSummary()
        { return new OrderSummary(); }
    }
}

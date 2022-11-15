using OpenPolytechnic.Business.Factories;
using OpenPolytechnic.Business.Model.Order;
using OpenPolytechnic.Business.Model.Order.Enum;
using OpenPolytechnic.Business.Services.Interfaces;
using System;

namespace OpenPolytechnic.Business.Services
{
    public class OrderService : IOrderService
    {
      
        private readonly OrderSummaryFactory orderSummaryFactory;
        private readonly MenuItemFactory menuItemFactory;
        private readonly OrderCostFactory orderCostFactory;

        #region const
        private const decimal SeniorDiscount = (10.00m / 100);
        private const decimal kidsSurcharge = (5.00m / 100);
        private const decimal discountThreshold = 100;
        private const decimal discountThresholdPercent = (5.00m / 100);
        private const decimal ThursdayDiscount = (3.00m / 100);

        private const string Standard = "standard";
        private const string Weekend = "weekend";
        private const string Catering = "catering";

       
        #endregion const
        public OrderService()
        {            
            menuItemFactory = new MenuItemFactory();
            orderCostFactory = new OrderCostFactory();
            orderSummaryFactory = new OrderSummaryFactory();
        }

        public OrderSummary PlaceOrders(Orders orders)
        {         
            if (orders == null)
            {
                throw new ArgumentNullException(nameof(orders));
            }

            try
            {

                var orderSummary = orderSummaryFactory.OrderSummary();
                var totalOrderPrice = 0.00m;

                foreach (var individualOrder in orders.IndividualOrders)
                {

                    var orderCost = orderCostFactory.costFactory();

                    orderCost.Order = individualOrder;
                    var IndividualorginalPrice = 0.00m;
                    var individualKidsSurgeCharge = 0.00m;

                    foreach (var item in individualOrder.MenuItemIds)
                    {
                        IndividualorginalPrice += menuItemFactory.GetMenuItemById(item).Cost;
                        orderSummary.Items.Add(menuItemFactory.GetMenuItemById(item));
                        if (menuItemFactory.IsItemBelongToKidsItem(item))
                        {
                            var itemOriginalCost = menuItemFactory.GetMenuItemById(item).Cost;
                            individualKidsSurgeCharge += itemOriginalCost * kidsSurcharge;
                        }
                    }

                    orderCost.DiscountAmount = calculateDiscount(orders.MenuType, IndividualorginalPrice, individualOrder.customerType);
                    orderCost.Surcharge = calculateSurcharge(individualKidsSurgeCharge, individualOrder.customerType);
                    orderCost.TotalOwing = IndividualorginalPrice - orderCost.DiscountAmount + orderCost.Surcharge;

                    orderSummary.OriginalCost += IndividualorginalPrice;
                    orderSummary.Surcharge += orderCost.Surcharge;
                    orderSummary.TotalCost += orderCost.TotalOwing;
                }
                return orderSummary;
            }
            catch(Exception e)
            {
                throw new Exception("Error while placing order.", e);
            }
        }

        private decimal calculateSurcharge(decimal individualKidsSurgeCharge, CustomerType customerType)
        {
            if (customerType == CustomerType.Child)
                return 0.00m;
            else
                return individualKidsSurgeCharge;
        }

        private decimal calculateDiscount(string menuType, decimal IndividualorginalPrice, CustomerType customerType)
        {
            decimal discount = 0.00m;

            if (menuType == Catering)
                return discount;

            if (IndividualorginalPrice > discountThreshold)
                discount += IndividualorginalPrice * discountThresholdPercent;

            if (customerType == CustomerType.SeniorCitizen && menuType == Standard)
            {
                discount += SeniorDiscount * IndividualorginalPrice;
            }
            if(menuType != Weekend && DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                discount += IndividualorginalPrice * ThursdayDiscount;
            }
            return discount;
        }
    }
}
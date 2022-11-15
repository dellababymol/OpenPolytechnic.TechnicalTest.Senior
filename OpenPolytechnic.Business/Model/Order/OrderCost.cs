namespace OpenPolytechnic.Business.Model.Order
{
    public class OrderCost
    {
        public decimal OriginalCost { get; set; }
        public decimal TotalOwing { get; set; }
        public decimal Surcharge { get; set; }
        public decimal DiscountAmount { get; set; }

        public Order Order { get; set; }
    }
}

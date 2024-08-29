namespace LuilleWebAPI.Entities.Concreate
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int EmloyeeID { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Freight { get; set; }
        public decimal Total { get; set; }
        public Employee Employee { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace LuilleWebAPI.Entities.Concreate
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
        public string ShipDistrict { get; set; }
        public string ShipStreet { get; set; }
        public string ShipApartmentNo { get; set; }
        public string ShipIndoorNo { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}

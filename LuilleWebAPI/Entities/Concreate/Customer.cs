namespace LuilleWebAPI.Entities.Concreate
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerSurname { get; set; }
        public short? CustomerAge { get; set; }
        public string? Gender { get; set; }
        public short? TitleId { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? SiteName { get; set; }
        public string? ApartmentNumber { get; set; }
        public string? IndoorNumber { get; set; }
        public string? OrderId  { get; set; }
        public List<Order> Orders { get; set; }


    }
}

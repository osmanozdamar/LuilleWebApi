namespace LuilleWebAPI.Entities.Concreate
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID{ get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string Color { get; set; }
        public short UnitsOnOrder { get; set; }
        public bool IsActive { get; set; }
        public string ProductPhotoPath { get; set; }
        public ICollection <Category> Categories { get; set; }
        public ICollection <OrderDetail> OrderDetails { get; set; }
        public ICollection<ProductPhoto> ProductPhotos { get; set; }


    }
}

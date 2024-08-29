namespace LuilleWebAPI.Entities.Concreate
{
    public class ProductPhoto
    {
        public int ProductPhotoID { get; set; }
        public int ProductID { get; set; }
        public string ProductPhotoPaty { get; set; }
        public Product Product { get; set; }
    }
}

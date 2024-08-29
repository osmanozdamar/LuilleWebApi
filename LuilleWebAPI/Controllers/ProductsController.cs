using LuilleWebAPI.Context;
using LuilleWebAPI.Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LuilleWebAPI.Controllers
{
    [Route("api/[controller]")]    //http://localhost:5216/api/products/
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            var ctx = new LuilleContext();
            var products = ctx.Products.ToList();
            return products;

            //select from products where yaparsak sorguyu db de yapıp sonucu rama alırız. ama önce tolist yapıp sonra orderby() yaparsak bu sever tüm ürünler gelir ancak listeleme ve filtreleme işi 0ramde yapılır. bu sürecimizi çok yavaşlatır. IQueryable şeklinde sorgu yaparsak sorgu veya komutun oluşturulduğunu ancak çalıştırılmadığını ifade eder. IEnumerable yaparsak sorgunun veya komutun çalıştırıldığını ve sonucun RAM e aktarıldığını ifade eder. ToList yaptığımızda sorguyu çalıştırır. En son ToList yaparsak tüm filtreyi çalıştırıp sonra listeye alır.
            // ctx.Products.Where(x=>x.ProductID>2).ToList(); //yapılması gereken sorgu tipi budur.
        }

        [HttpGet("getbyid")]
        public List<Product> GetById([FromQuery] int id)
        {
            var ctx = new LuilleContext();
            var products = ctx.Products
                .Where(x => x.ProductID == id)
                .ToList();
            return products;
        }

        //[HttpGet("getcheap")]
        //public List<Product> GetAllCheapProducts()
        //{
        //    var ctx = new LuilleContext();
        //    var products = ctx.Products.Where(x => x.UnitPrice > 10 && x.UnitPrice <= 50).ToList();
        //    return products;
        //}



        //[FromQuery]--> ilgili endpoint'in tetiklediği metoda, metodun istediği parametre değerinin querystring üzerinden setlenmesini gerektiği söyler. Bu yöntemle veri, endpoint'e endpoint adresinin sonuna ? konulup parametre isimleri kullanılarak taşınır. Örneğin:
        //http://localhost:5216/api/products/getbypricerange?min=10&max=20      //10 min'e 25'max e gidiyor
        [HttpGet("getbypricerange")]
        public List<Product> GetByPriceRange([FromQuery] decimal min, [FromQuery] decimal max)
        {
            var ctx = new LuilleContext();
            var products = ctx.Products.Where(x => x.UnitPrice > min && x.UnitPrice <= max).ToList();
            return products;
        }


        [HttpGet("getbycategory")]
        public List<Product> GetByCategory([FromQuery]int categoryId)
        {
            var ctx = new LuilleContext();
            var products = 
                ctx.Products
                    .Where(x => x.CategoryID == categoryId)
                    .ToList();
            return products;
        }




        //--------------POST METHODS-----------------------------------------------------------------------------------------

        //Yeni Ürün Ekle.
        [HttpPost]
            public string AddNewProduct([FromBody] Product product)
        {
            var ctx = new LuilleContext();
            ctx.Products.Add(product);
            ctx.SaveChanges();
            return "Yeni Ürün Eklendi.";
        }

        [HttpPut("{id:int}")]
        public string UpdateProduct([FromRoute]int id)
        {
            return "";
        }

        [HttpDelete("{id:int}")]
        public string DeleteProduct([FromRoute]int id)
        {
            return "";
        }
    }
}

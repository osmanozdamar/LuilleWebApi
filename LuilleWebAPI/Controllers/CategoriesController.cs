using LuilleWebAPI.Context;
using LuilleWebAPI.Dtos;
using LuilleWebAPI.Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LuilleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {




        //Tüm Kategorileri getir.
        [HttpGet]  // http://localhost:5216
        public List<CategoryGetDto> GetCategories() 
        {  
            var ctx = new LuilleContext();
            #region Entity To Dto Mapping 1
            //List<Category> categories = ctx.Categories.ToList();
            //List<CategoryGetDto> result = new List<CategoryGetDto>();
            //foreach (var category in categories)
            //{
            //    CategoryGetDto dto = new CategoryGetDto();
            //    dto.CategoryId = category.CategoryID;
            //    dto.CategoryName = category.CategoryName;
            //    dto.Description = category.Description;
            //    dto.ProductCount = 0;    //Buna sayım kodunu yazacağız. Şu anda böyle kaldı.

            //    result.Add(dto);
            //}
            //return result;
            #endregion

            #region Entity To Dto Mapping 2 Yaygın kullanım
            var result = ctx.Categories.Select(x => new  CategoryGetDto()
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                Description = x.Description,
                ProductCount = 0

            })
                .ToList();
            return result;

            #endregion

        }




        //Yeni Kategori Ekle.
        [HttpPost]
        public string SaveNewCategory([FromBody] CategoryPostDto dto)
        {
            var ctx = new LuilleContext();
            Category entity = new Category();
            entity.CategoryID = dto.CategoryID;
            entity.CategoryName = dto.CategoryName;
            entity.Description = dto.Description;
            ctx.Categories.Add(entity);
            //ctx.SaveChanges();

            return "Yeni kategori eklendi.";
        }





        [HttpPut("{id:int}")]
        public string UpdateCategory([FromRoute]int id, [FromBody] CategoryPutDto dto)
        {
            var ctx = new LuilleContext();

            Category entity= ctx.Categories.SingleOrDefault(x=>x.CategoryID == id);
            entity.CategoryName = dto.CategoryName;
            entity.Description = dto.Description;
            entity.Products = dto.Products;
            ctx.Categories.Update(entity);
            ctx.SaveChanges();

            return "İşlem Başarılı.";
        }





        //Kategori Sil
        [HttpDelete("deletecategory")]
        public string DeleteCategory([FromQuery] int id)
        {
            var ctx = new LuilleContext();
            var categoryEntity=
                ctx.Categories
                .SingleOrDefault (x=>x.CategoryID == id);
            
            ctx.Categories.Remove(categoryEntity);
            ctx.SaveChanges();


            return "Başarılı şekilde silindi.";

        }

    }
}

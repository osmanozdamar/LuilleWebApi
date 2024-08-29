﻿using LuilleWebAPI.Entities.Concreate;

namespace LuilleWebAPI.Dtos
{
    public class CategoryPutDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

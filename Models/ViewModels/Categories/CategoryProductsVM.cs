using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetpractice.Models.ViewModels.Products;

namespace dotnetpractice.Models.ViewModels.Categories
{
    public class CategoryProductsVM
    {
        public CategoriesVM Category { get; set; }
        public List<ProductsVM> Products { get; set; }
    }
}

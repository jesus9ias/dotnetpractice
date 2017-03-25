using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetpractice.Models.ViewModels
{
    public class CategoryProductsVM
    {
        public CategoriesVM Category { get; set; }
        public List<ProductsVM> Products { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetpractice.Models.ViewModels
{
    public class ProductsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Inventory { get; set; }
        public string Image { get; set; }
        public int Category { get; set; }
        public List<CategoriesVM> Categories { get; set; }
    }
}

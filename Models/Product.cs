using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetpractice.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLengthAttribute(100)]
        public string Name { get; set; }
        [Column("Description", TypeName = "text")]
        public string Description { get; set; }
        public double Price { get; set; }
        public int Inventory { get; set; }
        public string Image { get; set; }
        public int Category { get; set; }

        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}

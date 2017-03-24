using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetpractice.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLengthAttribute(100)]
        public string Name { get; set; }
        [Column("Description", TypeName = "text")]
        public string Description { get; set; }
    }
}

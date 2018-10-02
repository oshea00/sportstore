using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace SportsStore.Models {

    [Table("products")]
    public class Product {
        [Key]
        [Column("productid")]
        public int ProductID { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("category")]
        public string Category { get; set; }
    }
}


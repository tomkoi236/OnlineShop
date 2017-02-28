using ShopOnline.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ShopOnline.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        [Required]
        public int CatagoryID { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImage { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }

        [MaxLength(500)]
        public string Descripton { get; set; }

        public string Content { get; set; }

        public bool? HomeFlat { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
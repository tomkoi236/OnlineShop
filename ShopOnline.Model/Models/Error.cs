using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Model.Models
{
    [Table("Error")]
    public class Error
    {
        [Key]
        public int ID { get; set; }

        public string Message { get; set; }
        public string StrackTrace { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
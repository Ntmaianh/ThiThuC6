using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        [Key] // khóa chính 
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0,int.MaxValue)]
        public int Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWorkIntro.Models
{
    public class Products
    {
        [Key]
        public int product_id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string description { get; set; }
    }
}

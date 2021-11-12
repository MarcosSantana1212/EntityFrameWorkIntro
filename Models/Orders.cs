using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWorkIntro.Models
{
    public class Orders
    {
        [Key]
        public int order_id { get; set; }
        public int Id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EricStore.Models
{
    public class ProductModel
    {
        public string ShoeName { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public int ID { get; set; }
        public string Thumb { get;  set; }
        public string Full { get;  set; }
    }
}
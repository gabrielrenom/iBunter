using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iBunter.Models
{
    public class Product
    {
        public Product()
        {
            this.Rate = this.Id = 0;
            this.Name = this.Description = "";
        }
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iBunter.Models
{
    public class Rate
    {
        public Rate()
        {
            this.Rated = this.Id = 0;
            this.Name = this.Description = this.Entity= "";
        }
        public int Id { get; set; }
        public int Rated { get; set; }
        public string Name { get; set; }
        public string Entity { get; set; }
        public string Description { get; set; }
    }
}
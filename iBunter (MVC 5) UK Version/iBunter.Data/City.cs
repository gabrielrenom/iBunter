using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBunter.Data
{
    public class City
    {
        public int Id { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> StateId { get; set; }
        public string Name { get; set; }
        public string Active { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBunter.Data
{
    public class Address
    {
        public int Id { get; set; }
        public string Postcode { get; set; }
        public string Road { get; set; }
        public string Street { get; set; }
        public string Website { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> StateId { get; set; }
    }
}

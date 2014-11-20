using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBunter.Data
{
    public class Entity
    {
        public int Id { get; set; }
        public Nullable<int> EntityTypeId { get; set; }
        public Nullable<int> ContactId { get; set; }
        public string Email { get; set; }
        public Nullable<int> AddressId { get; set; }
        public byte[] Posted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBunter.Data
{
    public class Rating
    {
        public int Id { get; set; }
        public Nullable<int> EntityTypeId { get; set; }
        public Nullable<int> RatingTypeId { get; set; }
        public Nullable<int> EntityId { get; set; }
        public Nullable<int> Rating1 { get; set; }
        public string Review { get; set; }
        public byte[] Posted { get; set; }
    }
}

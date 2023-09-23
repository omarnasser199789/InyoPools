using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class PartProducts
    {
        public int ID { get; set; }
        public int PartPageID { get; set; }
        public int ProductID { get; set; }

        public virtual PartPages IPPEA_DATA_PartPages { get; set; }
        public virtual Product IPPEA_DATA_Product { get; set; }

    }
}

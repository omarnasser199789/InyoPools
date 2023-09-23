using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class ProductType
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }

        //public virtual Product Product { get; set; }
        //public virtual ProductCategory IPPEA_DATA_ProductCategory { get; set; }
    }
}

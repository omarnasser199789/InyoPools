using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class ProductCategoryRelated
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public int RelatedCategoryID { get; set; }
        public int SortOrder { get; set; }

        public virtual ProductCategory IPPEA_DATA_ProductCategory_CategoryID { get; set; }
        public virtual ProductCategory IPPEA_DATA_ProductCategory_RelatedCategoryID { get; set; }
    }
}


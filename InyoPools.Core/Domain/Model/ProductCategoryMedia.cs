using InyoPools.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class ProductCategoryMedia
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public int MediaId { get; set; }
        public MediaResource MediaResourceTypeId { get; set; }
        public System.DateTimeOffset InsertDate { get; set; }

        public virtual Media IPPEA_DATA_Media { get; set; }
        public virtual ProductCategory IPPEA_DATA_ProductCategory { get; set; }
        public virtual MediaResourceTypes IPPEA_DECODE_MediaResourceTypes { get; set; }

    }
}

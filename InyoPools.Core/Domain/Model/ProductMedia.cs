using InyoPools.Core.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class ProductMedia
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int MediaId { get; set; }
        public MediaResource MediaResourceTypeId { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual Media IPPEA_DATA_Media { get; set; }
        public virtual Product IPPEA_DATA_Product { get; set; }
        public virtual MediaResourceTypes IPPEA_DECODE_MediaResourceTypes { get; set; }

    }
}

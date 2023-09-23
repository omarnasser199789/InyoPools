using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Model
{
    public class PartPages
    {
        public int ID { get; set; }
        public int? PartCategoryID { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string ImageFileName { get; set; }
        public string ProductInformation { get; set; }
        public string Footer { get; set; }
        public string PageTitle { get; set; }
        public string UserID { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public int? SectionID { get; set; }
        public bool InXml { get; set; }
        public bool IsActive { get; set; }
        public bool DontDisplayFreeShippingBanner { get; set; }
        public int? ManufacturerID { get; set; }

        public virtual ICollection<PartProducts> IPPEA_DATA_PartProducts { get; set; } = new HashSet<PartProducts>();
        //public virtual Manufacturer IPPEA_DATA_Manufacturer { get; set; }
        //public virtual ICollection<IPPEA_DATA_PartCharts> IPPEA_DATA_PartCharts { get; set; } = new HashSet<IPPEA_DATA_PartCharts>();
        //public virtual ICollection<IPPEA_DATA_PartPageMedia> IPPEA_DATA_PartPageMedia { get; set; } = new HashSet<IPPEA_DATA_PartPageMedia>();
        //public virtual ICollection<IPPEA_DATA_PartPageCategories> IPPEA_DATA_PartPageCategories { get; set; } = new HashSet<IPPEA_DATA_PartPageCategories>();

    }
}

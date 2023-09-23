

namespace InyoPools.Core.Domain.Model
{
    public class Manufacturer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public bool NoPublicDisplayOfMfg { get; set; }
        public bool NoDisplayPopularItems { get; set; }
        public bool NoDisplayToVendors { get; set; }
        public string AbbrDisplayName { get; set; }

        //public virtual ICollection<Product> IPPEA_DATA_Product { get; set; } = new HashSet<Product>();
       // public virtual ICollection<PartPages> IPPEA_DATA_PartPages { get; set; } = new HashSet<PartPages>();
        //public virtual ICollection<IPPEA_DATA_EmailLog> IPPEA_DATA_EmailLog { get; set; } = new HashSet<IPPEA_DATA_EmailLog>();
        //public virtual ICollection<IPPEA_DATA_EmailQueue> IPPEA_DATA_EmailQueue { get; set; } = new HashSet<IPPEA_DATA_EmailQueue>();
        //public virtual ICollection<IPPEA_DATA_QandAAnswer> IPPEA_DATA_QandAAnswer { get; set; } = new HashSet<IPPEA_DATA_QandAAnswer>();
        //public virtual ICollection<IPPEA_DATA_QandAAsked> IPPEA_DATA_QandAAsked { get; set; } = new HashSet<IPPEA_DATA_QandAAsked>();
        //public virtual ICollection<AspNetManufacturers> AspNetManufacturers { get; set; } = new HashSet<AspNetManufacturers>();

    }
}

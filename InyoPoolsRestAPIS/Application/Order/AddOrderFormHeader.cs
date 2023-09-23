using AutoMapper;
using InyoPools.Core.Domain.Enums;
using InyoPools.Core.Domain.Model;

namespace InyoPoolsRest.API.Application.Order
{



    public class AddOrderFormHeader
    {

        public class Request
        {
            public int ID { get; set; }
            public int OrderGroupID { get; set; }
            public int CustomerID { get; set; }
            public string CustomerName { get; set; }
            public DateTime OrderFormDate { get; set; }
            public int OrderStatusID { get; set; }
            public int VendorID { get; set; }

            public int ServiceRepID { get; set; }
            public DateTime VendorDateApproved { get; set; }
            public DateTime VendorDateAccepted { get; set; }
            public DateTime VendorDateShipped { get; set; }
            public bool VendorAccepted { get; set; }
            public string Vendor { get; set; }
            public string ContactFirstName { get; set; }
            public string ContactLastName { get; set; }
            public string CompanyName { get; set; }
            public string ContactCompany { get; set; }
            public string ContactAddress1 { get; set; }
            public string ContactAddress2 { get; set; }
            public string ContactCity { get; set; }
            public string ContactState { get; set; }
            public string ContactCountry { get; set; }
            public string ContactZip { get; set; }
            public string ContactPhone { get; set; }
            public string ContactFax { get; set; }
            public string ContactEmail { get; set; }
            public string BillToFirstName { get; set; }
            public string BillToLastName { get; set; }
            public string BillToCompany { get; set; }
            public string BillToAddress1 { get; set; }
            public string BillToAddress2 { get; set; }
            public string BillToCity { get; set; }
            public string BillToState { get; set; }
            public string BillToCountry { get; set; }
            public string BillToZip { get; set; }
            public string BillToPhone { get; set; }
            public string BillToFax { get; set; }
            public string BillToEmail { get; set; }
            public string BillOptionDescription { get; set; }
            public string ShipToFirstName { get; set; }
            public string ShipToLastName { get; set; }
            public string ShipToCompany { get; set; }
            public string ShipToAddress1 { get; set; }
            public string ShipToAddress2 { get; set; }
            public string ShipToCity { get; set; }
            public string ShipToState { get; set; }
            public string ShipToCountry { get; set; }
            public string ShipToZip { get; set; }
            public string ShipToPhone { get; set; }
            public string ShipToFax { get; set; }
            public string ShipToEmail { get; set; }
            public int InvoiceStatusID { get; set; }
            public string InvoiceStatus { get; set; }
            public int BillingTypeID { get; set; }
            public string CCNumber { get; set; }
            public string CCID { get; set; }
            public string CCExpDate { get; set; }
            public string CCNameOnCard { get; set; }
            public string BAAccountName { get; set; }
            public string BABankName { get; set; }
            public string BARoutingNumber { get; set; }
            public string BAAccountNumber { get; set; }
            public string BACheckNumber { get; set; }
            public double BillTotal { get; set; }

            public bool SelectedLiftGate { get; set; }
            public double Subtotal { get; set; }
            public double TaxRate { get; set; }
            public double Shipping { get; set; }
            public double Handling { get; set; }
            public int ShipMethodID { get; set; }
            public string ShipMethodDesc { get; set; }
            public double ShipTotal { get; set; }
            public double HandlingTotal { get; set; }
            public double Tax { get; set; }
            public string PPUserID { get; set; }
            public string ShipAccountNumber { get; set; }
            public string TaxCertificateNum { get; set; }
            public bool TaxCertificateOnFile { get; set; }
            public bool UsedNewVendorSelectionCriteria { get; set; }
            public DateTime TaxCertificateExpDate { get; set; }
            public bool UseTaxCertificate { get; set; }
            public string OrderItems { get; set; }
            public string PONumber { get; set; }
            public double AuthAmount { get; set; }
            public string AuthTransID { get; set; }
            public bool AuthCaptured { get; set; }
            public string UserID { get; set; }
            public bool IsDeleted { get; set; }
            public int TransMethodID { get; set; }
            public string BillOptionType { get; set; }
            public double CommissionPct { get; set; }
            public string OrderStatus { get; set; }
            public string OrderStatusPublic { get; set; }
            public int ServiceLevelID { get; set; }
            public int Priority { get; set; }
            public string OrderError { get; set; }
            public int CreatedBy { get; set; }
            public DateTime DateCreated { get; set; }
            public int ModifiedBy { get; set; }
            public DateTime DateModified { get; set; }
            public string UploadOrderNumber { get; set; }
        }



        public class Response
        {
            public string Status { get; set; }
            public string Message { get; set; }

        }



        public class Mapper : Profile
        {


            public Mapper()
            {
                CreateMap<AddOrderFormHeader, Response>();
            }



        }

    }
}

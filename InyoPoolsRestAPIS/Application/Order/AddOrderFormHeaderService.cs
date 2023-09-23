using InyoPools.Core.Domain.Model.Order;
using InyoPools.Infrastructure;

namespace InyoPoolsRest.API.Application.Order
{
    


    public interface IAddOrderFormHeaderService
    {
        Task<AddOrderFormHeader.Response> AddOrderFormHeader(AddOrderFormHeader.Request request);
    }

    public class AddOrderFormHeaderService : IAddOrderFormHeaderService
    {
        private readonly InyoPoolsDbContext _inyoPoolsDbContext;

        public AddOrderFormHeaderService(InyoPoolsDbContext inyoPoolsDbContext)
        {
            _inyoPoolsDbContext = inyoPoolsDbContext;

        }



        public async Task<AddOrderFormHeader.Response> AddOrderFormHeader(AddOrderFormHeader.Request request)
        {
            try
            {
                var orderFormHeader = new OrderFormHeader
                {
                    OrderGroupID = request.OrderGroupID,
                    CustomerID = request.CustomerID,
                    CustomerName = request.CustomerName,
                    OrderFormDate = request.OrderFormDate,
                    OrderStatusID = request.OrderStatusID,
                    VendorID = request.VendorID,
                    ServiceRepID =request.ServiceRepID,
                    VendorDateApproved = request.VendorDateApproved,
                    VendorDateAccepted = request.VendorDateAccepted,
                    VendorDateShipped = request.VendorDateShipped,
                    VendorAccepted = request.VendorAccepted,
                    Vendor = request.Vendor,
                    ContactFirstName = request.ContactFirstName,
                    ContactLastName = request.ContactLastName,
                    CompanyName = request.CompanyName,
                    ContactCompany = request.ContactCompany,
                    ContactAddress1 = request.ContactAddress1,
                    ContactAddress2 = request.ContactAddress2,
                    ContactCity = request.ContactCity,
                    ContactState = request.ContactState,
                    ContactCountry = request.ContactCountry,
                    ContactZip = request.ContactZip,
                    ContactPhone = request.ContactPhone,
                    ContactFax = request.ContactFax,
                    ContactEmail = request.ContactEmail,
                    BillToFirstName = request.BillToFirstName,
                    BillToLastName = request.BillToLastName,
                    BillToCompany = request.BillToCompany,
                    BillToAddress1 = request.BillToAddress1,
                    BillToAddress2 = request.BillToAddress2,
                    BillToCity = request.BillToCity,
                    BillToState = request.BillToState,
                    BillToCountry = request.BillToCountry,
                    BillToZip = request.BillToZip,
                    BillToPhone = request.BillToPhone,
                    BillToFax = request.BillToFax,
                    BillToEmail = request.BillToEmail,
                    BillOptionDescription = request.BillOptionDescription,
                    ShipToFirstName = request.ShipToFirstName,
                    ShipToLastName = request.ShipToLastName,
                    ShipToCompany = request.ShipToCompany,
                    ShipToAddress1 = request.ShipToAddress1,
                    ShipToAddress2 = request.ShipToAddress2,
                    ShipToCity = request.ShipToCity,
                    ShipToState = request.ShipToState,
                    ShipToCountry = request.ShipToCountry,
                    ShipToZip = request.ShipToZip,
                    ShipToPhone = request.ShipToPhone,
                    ShipToFax = request.ShipToFax,
                    ShipToEmail = request.ShipToEmail,
                    InvoiceStatusID = request.InvoiceStatusID,
                    InvoiceStatus = request.InvoiceStatus,
                    BillingTypeID = request.BillingTypeID,
                    CCNumber = request.CCNumber,
                    CCID = request.CCID,
                    CCExpDate = request.CCExpDate,
                    CCNameOnCard = request.CCNameOnCard,
                    BAAccountName = request.BAAccountName,
                    BABankName = request.BABankName,
                    BARoutingNumber = request.BARoutingNumber,
                    BAAccountNumber = request.BAAccountNumber,
                    BACheckNumber = request.BACheckNumber,
                    BillTotal = request.BillTotal,

                    SelectedLiftGate= request.SelectedLiftGate,
                    UsedNewVendorSelectionCriteria = request.UsedNewVendorSelectionCriteria,
                    Subtotal = request.Subtotal,
                    TaxRate = request.TaxRate,
                    Shipping = request.Shipping,
                    Handling = request.Handling,
                    ShipMethodID = request.ShipMethodID,
                    ShipMethodDesc = request.ShipMethodDesc,
                    ShipTotal = request.ShipTotal,
                    HandlingTotal = request.HandlingTotal,
                    Tax = request.Tax,
                    PPUserID = request.PPUserID,
                    ShipAccountNumber = request.ShipAccountNumber,
                    TaxCertificateNum = request.TaxCertificateNum,
                    TaxCertificateOnFile = request.TaxCertificateOnFile,
                    TaxCertificateExpDate = request.TaxCertificateExpDate,
                    UseTaxCertificate = request.UseTaxCertificate,
                    OrderItems = request.OrderItems,
                    PONumber = request.PONumber,
                    AuthAmount = request.AuthAmount,
                    AuthTransID = request.AuthTransID,
                    AuthCaptured = request.AuthCaptured,
                    UserID = request.UserID,
                    IsDeleted = request.IsDeleted,
                    TransMethodID = request.TransMethodID,
                    BillOptionType = request.BillOptionType,
                    CommissionPct = request.CommissionPct,
                    OrderStatus = request.OrderStatus,
                    OrderStatusPublic = request.OrderStatusPublic,
                    ServiceLevelID = request.ServiceLevelID,
                    Priority = request.Priority,
                    OrderError = request.OrderError,
                    CreatedBy = request.CreatedBy,
                    DateCreated = request.DateCreated,
                    ModifiedBy = request.ModifiedBy,
                    DateModified = request.DateModified,
                    UploadOrderNumber = request.UploadOrderNumber
                };


                await _inyoPoolsDbContext.OrdersFormHeader.AddAsync(orderFormHeader);

                await _inyoPoolsDbContext.SaveChangesAsync();


                // If the OrderFormHeader was added successfully, return a success response.
                var response = new AddOrderFormHeader.Response { Status = "Success", Message = "EmailLog added successfully." };
                return response;
            }
            catch (Exception ex) {
                // If an error occurred, return an error response.
                var response = new AddOrderFormHeader.Response { Status = "Error", Message = ex.Message };
                return response;
            }

        }




    }
}

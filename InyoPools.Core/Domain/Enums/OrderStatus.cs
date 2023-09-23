using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Core.Domain.Enums
{
    public enum OrderStatus
    {
        RMA = -1,
        RMAClosed = -2,
        [System.ComponentModel.Description("In Progress")]
        InProgress = 1,
        [System.ComponentModel.Description("Pending Inyo Approval")]
        PendingVendorApproval = 2,
        [System.ComponentModel.Description("Approved For Vendor")]
        ApprovedForVendor = 3,
        [System.ComponentModel.Description("Accepted By Vendor")]
        AcceptedByVendor = 4,
        [System.ComponentModel.Description("Shipped But Unpaid")]
        Shipped = 5,
        [System.ComponentModel.Description("Not Authorized")]
        NotAuthorized = 6,
        [System.ComponentModel.Description("Declined")]
        Declined = 7,
        [System.ComponentModel.Description("Pending Price Change")]
        PendingPriceChange = 8,
        [System.ComponentModel.Description("Declined By Vendor")]
        DeclinedByVendor = 9,
        [System.ComponentModel.Description("Pending Response")]
        PendingResponse = 10,
        [System.ComponentModel.Description("Response Answered")]
        ResponseAnswered = 11,
        [System.ComponentModel.Description("Waiting For Check")]
        WaitingForCheck = 12,
        [System.ComponentModel.Description("Shipped And Billed")]
        ShippedAndBilled = 13,
        [System.ComponentModel.Description("Waiting For Customer Confirmation")]
        WaitingForCustomerConfirmation = 14,
        [System.ComponentModel.Description("Confirmed By Customer")]
        ConfirmedByCustomer = 15,
        [System.ComponentModel.Description("Waiting For Customer - Email Sent")]
        WaitingForCustomerEmailSent = 16,
        [System.ComponentModel.Description("Waiting For PayPal")]
        WaitingForPayPal = 17,
        [System.ComponentModel.Description("Cancelled")]
        Cancelled = 18,
        [System.ComponentModel.Description("Waiting For Payment To Clear")]
        WaitingForPaymentToClear = 19,
        [System.ComponentModel.Description("Waiting For Tax Certificate")]
        WaitingForTaxCertificate = 20,
        [System.ComponentModel.Description("Other")]
        Other = 21,
        [System.ComponentModel.Description("Waiting For Google Payment")]
        WaitingForGooglePayment = 22,
        [System.ComponentModel.Description("Edit Paypal/Google Checkout Order")]
        EditPaypalGoogleCheckoutOrder = 23,
        [System.ComponentModel.Description("On Hold")]
        OnHold = 24,
        [System.ComponentModel.Description("Low Margin Hold")]
        LowMarginHold = 25,
        [System.ComponentModel.Description("Pending Inyo Approval - Problems")]
        PendingInyoApprovalProblems = 26
    }

}

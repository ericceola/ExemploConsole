using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PArserExcelConsole
{
    public class InvoiceResponse
    {
       
       
            [JsonProperty("InvoiceId")]
            public long InvoiceId { get; set; }

            [JsonProperty("InvoiceNumber")]
            public string InvoiceNumber { get; set; }

            [JsonProperty("InvoiceCurrency")]
            public string InvoiceCurrency { get; set; }

            [JsonProperty("PaymentCurrency")]
            public string PaymentCurrency { get; set; }

            [JsonProperty("InvoiceAmount")]
            public double InvoiceAmount { get; set; }

            [JsonProperty("InvoiceDate")]
            public string InvoiceDate { get; set; }

            [JsonProperty("BusinessUnit")]
            public string BusinessUnit { get; set; }

            [JsonProperty("Supplier")]
            public string Supplier { get; set; }

            [JsonProperty("SupplierNumber")]
            public string SupplierNumber { get; set; }

            [JsonProperty("ProcurementBU")]
            public object ProcurementBU { get; set; }

            [JsonProperty("SupplierSite")]
            public string SupplierSite { get; set; }

            [JsonProperty("RequesterId")]
            public object RequesterId { get; set; }

            [JsonProperty("Requester")]
            public object Requester { get; set; }

            [JsonProperty("InvoiceGroup")]
            public object InvoiceGroup { get; set; }

            [JsonProperty("ConversionRateType")]
            public object ConversionRateType { get; set; }

            [JsonProperty("ConversionDate")]
            public object ConversionDate { get; set; }

            [JsonProperty("ConversionRate")]
            public object ConversionRate { get; set; }

            [JsonProperty("AccountingDate")]
            public string AccountingDate { get; set; }

            [JsonProperty("Description")]
            public string Description { get; set; }

            [JsonProperty("DeliveryChannelCode")]
            public object DeliveryChannelCode { get; set; }

            [JsonProperty("DeliveryChannel")]
            public object DeliveryChannel { get; set; }

            [JsonProperty("PayAloneFlag")]
            public bool PayAloneFlag { get; set; }

            [JsonProperty("InvoiceSource")]
            public string InvoiceSource { get; set; }

            [JsonProperty("InvoiceType")]
            public object InvoiceType { get; set; }

            [JsonProperty("PayGroup")]
            public string PayGroup { get; set; }

            [JsonProperty("InvoiceReceivedDate")]
            public object InvoiceReceivedDate { get; set; }

            [JsonProperty("PaymentReasonCode")]
            public object PaymentReasonCode { get; set; }

            [JsonProperty("PaymentReason")]
            public object PaymentReason { get; set; }

            [JsonProperty("PaymentReasonComments")]
            public object PaymentReasonComments { get; set; }

            [JsonProperty("PaymentTerms")]
            public object PaymentTerms { get; set; }

            [JsonProperty("TermsDate")]
            public string TermsDate { get; set; }

            [JsonProperty("GoodsReceivedDate")]
            public object GoodsReceivedDate { get; set; }

            [JsonProperty("PaymentMethodCode")]
            public string PaymentMethodCode { get; set; }

            [JsonProperty("PaymentMethod")]
            public object PaymentMethod { get; set; }

            [JsonProperty("SupplierTaxRegistrationNumber")]
            public object SupplierTaxRegistrationNumber { get; set; }

            [JsonProperty("FirstPartyTaxRegistrationId")]
            public long FirstPartyTaxRegistrationId { get; set; }

            [JsonProperty("FirstPartyTaxRegistrationNumber")]
            public string FirstPartyTaxRegistrationNumber { get; set; }

            [JsonProperty("LegalEntity")]
            public string LegalEntity { get; set; }

            [JsonProperty("LegalEntityIdentifier")]
            public object LegalEntityIdentifier { get; set; }

            [JsonProperty("LiabilityDistribution")]
            public string LiabilityDistribution { get; set; }

            [JsonProperty("DocumentCategory")]
            public object DocumentCategory { get; set; }

            [JsonProperty("DocumentSequence")]
            public object DocumentSequence { get; set; }

            [JsonProperty("VoucherNumber")]
            public object VoucherNumber { get; set; }

            [JsonProperty("ValidationStatus")]
            public object ValidationStatus { get; set; }

            [JsonProperty("ApprovalStatus")]
            public object ApprovalStatus { get; set; }

            [JsonProperty("PaidStatus")]
            public object PaidStatus { get; set; }

            [JsonProperty("AccountingStatus")]
            public object AccountingStatus { get; set; }

            [JsonProperty("ApplyAfterDate")]
            public object ApplyAfterDate { get; set; }

            [JsonProperty("CanceledFlag")]
            public object CanceledFlag { get; set; }

            [JsonProperty("AmountPaid")]
            public object AmountPaid { get; set; }

            [JsonProperty("BaseAmount")]
            public object BaseAmount { get; set; }

            [JsonProperty("PurchaseOrderNumber")]
            public object PurchaseOrderNumber { get; set; }

            [JsonProperty("Party")]
            public string Party { get; set; }

            [JsonProperty("PartySite")]
            public string PartySite { get; set; }

            [JsonProperty("ControlAmount")]
            public object ControlAmount { get; set; }

            [JsonProperty("DocumentFiscalClassificationCodePath")]
            public object DocumentFiscalClassificationCodePath { get; set; }

            [JsonProperty("TaxationCountry")]
            public string TaxationCountry { get; set; }

            [JsonProperty("RoutingAttribute1")]
            public object RoutingAttribute1 { get; set; }

            [JsonProperty("RoutingAttribute2")]
            public object RoutingAttribute2 { get; set; }

            [JsonProperty("RoutingAttribute3")]
            public object RoutingAttribute3 { get; set; }

            [JsonProperty("RoutingAttribute4")]
            public object RoutingAttribute4 { get; set; }

            [JsonProperty("RoutingAttribute5")]
            public object RoutingAttribute5 { get; set; }

            [JsonProperty("AccountCodingStatus")]
            public object AccountCodingStatus { get; set; }

            [JsonProperty("BudgetDate")]
            public string BudgetDate { get; set; }

            [JsonProperty("FundsStatus")]
            public object FundsStatus { get; set; }

            [JsonProperty("CanceledDate")]
            public object CanceledDate { get; set; }

            [JsonProperty("CanceledBy")]
            public object CanceledBy { get; set; }

            [JsonProperty("UniqueRemittanceIdentifier")]
            public object UniqueRemittanceIdentifier { get; set; }

            [JsonProperty("UniqueRemittanceIdentifierCheckDigit")]
            public object UniqueRemittanceIdentifierCheckDigit { get; set; }

            [JsonProperty("CreationDate")]
            public DateTime CreationDate { get; set; }

            [JsonProperty("CreatedBy")]
            public string CreatedBy { get; set; }

            [JsonProperty("LastUpdatedBy")]
            public string LastUpdatedBy { get; set; }

            [JsonProperty("LastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }

            [JsonProperty("LastUpdateLogin")]
            public string LastUpdateLogin { get; set; }

            [JsonProperty("invoiceInstallments")]
            public List<InvoiceInstallment> InvoiceInstallments { get; set; }

            [JsonProperty("invoiceDff")]
            public List<InvoiceDff> InvoiceDff { get; set; }

            [JsonProperty("invoiceLines")]
            public List<InvoiceLine> InvoiceLines { get; set; }

            [JsonProperty("links")]
            public List<Link> Links { get; set; }
    }

    public class Properties
    {
        [JsonProperty("changeIndicator")]
        public string ChangeIndicator { get; set; }
    }

    public class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

    public class InvoiceInstallment
    {
        [JsonProperty("InstallmentNumber")]
        public int InstallmentNumber { get; set; }

        [JsonProperty("UnpaidAmount")]
        public double UnpaidAmount { get; set; }

        [JsonProperty("FirstDiscountAmount")]
        public object FirstDiscountAmount { get; set; }

        [JsonProperty("FirstDiscountDate")]
        public object FirstDiscountDate { get; set; }

        [JsonProperty("DueDate")]
        public string DueDate { get; set; }

        [JsonProperty("GrossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("HoldReason")]
        public object HoldReason { get; set; }

        [JsonProperty("PaymentPriority")]
        public int PaymentPriority { get; set; }

        [JsonProperty("SecondDiscountAmount")]
        public object SecondDiscountAmount { get; set; }

        [JsonProperty("SecondDiscountDate")]
        public object SecondDiscountDate { get; set; }

        [JsonProperty("ThirdDiscountAmount")]
        public object ThirdDiscountAmount { get; set; }

        [JsonProperty("ThirdDiscountDate")]
        public object ThirdDiscountDate { get; set; }

        [JsonProperty("NetAmountOne")]
        public object NetAmountOne { get; set; }

        [JsonProperty("NetAmountTwo")]
        public object NetAmountTwo { get; set; }

        [JsonProperty("NetAmountThree")]
        public object NetAmountThree { get; set; }

        [JsonProperty("HoldFlag")]
        public bool HoldFlag { get; set; }

        [JsonProperty("HeldBy")]
        public object HeldBy { get; set; }

        [JsonProperty("HoldType")]
        public object HoldType { get; set; }

        [JsonProperty("PaymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("PaymentMethodCode")]
        public string PaymentMethodCode { get; set; }

        [JsonProperty("HoldDate")]
        public object HoldDate { get; set; }

        [JsonProperty("BankAccount")]
        public object BankAccount { get; set; }

        [JsonProperty("ExternalBankAccountId")]
        public object ExternalBankAccountId { get; set; }

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("CreationDate")]
        public DateTime CreationDate { get; set; }

        [JsonProperty("LastUpdateDate")]
        public DateTime LastUpdateDate { get; set; }

        [JsonProperty("LastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [JsonProperty("LastUpdateLogin")]
        public string LastUpdateLogin { get; set; }

        [JsonProperty("RemitToAddressName")]
        public object RemitToAddressName { get; set; }

        [JsonProperty("RemitToSupplier")]
        public object RemitToSupplier { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }

    public class InvoiceDff
    {
        [JsonProperty("InvoiceId")]
        public long InvoiceId { get; set; }

        [JsonProperty("__FLEX_Context")]
        public string FLEXContext { get; set; }

        [JsonProperty("__FLEX_Context_DisplayValue")]
        public string FLEXContextDisplayValue { get; set; }

        [JsonProperty("laclsBrInputMethodBcode")]
        public string LaclsBrInputMethodBcode { get; set; }

        [JsonProperty("laclsBrBarcodeNum")]
        public string LaclsBrBarcodeNum { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }

    public class InvoiceLine
    {
        [JsonProperty("LineNumber")]
        public int LineNumber { get; set; }

        [JsonProperty("LineAmount")]
        public double LineAmount { get; set; }

        [JsonProperty("AccountingDate")]
        public string AccountingDate { get; set; }

        [JsonProperty("UOM")]
        public object UOM { get; set; }

        [JsonProperty("TaxRateName")]
        public object TaxRateName { get; set; }

        [JsonProperty("LineType")]
        public string LineType { get; set; }

        [JsonProperty("AssetBook")]
        public object AssetBook { get; set; }

        [JsonProperty("TrackAsAssetFlag")]
        public bool TrackAsAssetFlag { get; set; }

        [JsonProperty("BaseAmount")]
        public object BaseAmount { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("IncomeTaxRegion")]
        public object IncomeTaxRegion { get; set; }

        [JsonProperty("Item")]
        public object Item { get; set; }

        [JsonProperty("ItemDescription")]
        public object ItemDescription { get; set; }

        [JsonProperty("LineSource")]
        public object LineSource { get; set; }

        [JsonProperty("Quantity")]
        public object Quantity { get; set; }

        [JsonProperty("DistributionCombination")]
        public string DistributionCombination { get; set; }

        [JsonProperty("AssetCategory")]
        public string AssetCategory { get; set; }

        [JsonProperty("UnitPrice")]
        public object UnitPrice { get; set; }

        [JsonProperty("ProrateAcrossAllItemsFlag")]
        public object ProrateAcrossAllItemsFlag { get; set; }

        [JsonProperty("LandedCostEnabled")]
        public object LandedCostEnabled { get; set; }

        [JsonProperty("DiscardedFlag")]
        public bool DiscardedFlag { get; set; }

        [JsonProperty("CanceledFlag")]
        public bool CanceledFlag { get; set; }

        [JsonProperty("IncomeTaxType")]
        public object IncomeTaxType { get; set; }

        [JsonProperty("TaxRateCode")]
        public object TaxRateCode { get; set; }

        [JsonProperty("TaxRate")]
        public object TaxRate { get; set; }

        [JsonProperty("TaxClassification")]
        public object TaxClassification { get; set; }

        [JsonProperty("GenerateDistributions")]
        public string GenerateDistributions { get; set; }

        [JsonProperty("BudgetDate")]
        public string BudgetDate { get; set; }

        [JsonProperty("FundsStatus")]
        public object FundsStatus { get; set; }

        [JsonProperty("ApprovalStatus")]
        public object ApprovalStatus { get; set; }

        [JsonProperty("DistributionSet")]
        public object DistributionSet { get; set; }

        [JsonProperty("Withholding")]
        public object Withholding { get; set; }

        [JsonProperty("ShipToLocationCode")]
        public object ShipToLocationCode { get; set; }

        [JsonProperty("ShipToLocation")]
        public object ShipToLocation { get; set; }

        [JsonProperty("ShipToCustomerLocation")]
        public object ShipToCustomerLocation { get; set; }

        [JsonProperty("TaxControlAmount")]
        public object TaxControlAmount { get; set; }

        [JsonProperty("AssessableValue")]
        public double AssessableValue { get; set; }

        [JsonProperty("ProductType")]
        public object ProductType { get; set; }

        [JsonProperty("ProductCategory")]
        public object ProductCategory { get; set; }

        [JsonProperty("ProductCategoryCodePath")]
        public object ProductCategoryCodePath { get; set; }

        [JsonProperty("UserDefinedFiscalClassification")]
        public object UserDefinedFiscalClassification { get; set; }

        [JsonProperty("UserDefinedFiscalClassificationCode")]
        public object UserDefinedFiscalClassificationCode { get; set; }

        [JsonProperty("IntendedUse")]
        public object IntendedUse { get; set; }

        [JsonProperty("IntendedUseCode")]
        public object IntendedUseCode { get; set; }

        [JsonProperty("ProductFiscalClassification")]
        public object ProductFiscalClassification { get; set; }

        [JsonProperty("ProductFiscalClassificationCode")]
        public object ProductFiscalClassificationCode { get; set; }

        [JsonProperty("ProductFiscalClassificationType")]
        public object ProductFiscalClassificationType { get; set; }

        [JsonProperty("TransactionBusinessCategory")]
        public object TransactionBusinessCategory { get; set; }

        [JsonProperty("TransactionBusinessCategoryCodePath")]
        public string TransactionBusinessCategoryCodePath { get; set; }

        [JsonProperty("Requester")]
        public object Requester { get; set; }

        [JsonProperty("PurchasingCategory")]
        public object PurchasingCategory { get; set; }

        [JsonProperty("MatchType")]
        public string MatchType { get; set; }

        [JsonProperty("MatchOption")]
        public object MatchOption { get; set; }

        [JsonProperty("MatchBasis")]
        public object MatchBasis { get; set; }

        [JsonProperty("PurchaseOrderNumber")]
        public object PurchaseOrderNumber { get; set; }

        [JsonProperty("PurchaseOrderLineNumber")]
        public object PurchaseOrderLineNumber { get; set; }

        [JsonProperty("PurchaseOrderScheduleLineNumber")]
        public object PurchaseOrderScheduleLineNumber { get; set; }

        [JsonProperty("ReceiptNumber")]
        public object ReceiptNumber { get; set; }

        [JsonProperty("ReceiptLineNumber")]
        public object ReceiptLineNumber { get; set; }

        [JsonProperty("ConsumptionAdviceNumber")]
        public object ConsumptionAdviceNumber { get; set; }

        [JsonProperty("ConsumptionAdviceLineNumber")]
        public object ConsumptionAdviceLineNumber { get; set; }

        [JsonProperty("FinalMatchFlag")]
        public object FinalMatchFlag { get; set; }

        [JsonProperty("MultiperiodAccountingStartDate")]
        public object MultiperiodAccountingStartDate { get; set; }

        [JsonProperty("MultiperiodAccountingEndDate")]
        public object MultiperiodAccountingEndDate { get; set; }

        [JsonProperty("MultiperiodAccountingAccrualAccount")]
        public string MultiperiodAccountingAccrualAccount { get; set; }

        [JsonProperty("CreatedBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("CreationDate")]
        public DateTime CreationDate { get; set; }

        [JsonProperty("LastUpdateDate")]
        public DateTime LastUpdateDate { get; set; }

        [JsonProperty("LastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [JsonProperty("LastUpdateLogin")]
        public string LastUpdateLogin { get; set; }

        [JsonProperty("RequesterId")]
        public object RequesterId { get; set; }

        [JsonProperty("PrepaymentNumber")]
        public object PrepaymentNumber { get; set; }

        [JsonProperty("PrepaymentLineNumber")]
        public object PrepaymentLineNumber { get; set; }

        [JsonProperty("PrepaymentIncludedonInvoiceFlag")]
        public object PrepaymentIncludedonInvoiceFlag { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }
    }

}

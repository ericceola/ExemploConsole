using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleINT096
{
    public class FileAccountReceivableSettings
    {
            [JsonProperty("businessUnitIdentifier")]
            public string BusinessUnitIdentifier { get; set; }

            [JsonProperty("transactionBatchSourceName")]
            public string TransactionBatchSourceName { get; set; }

            [JsonProperty("originalSystemBilltoCustomerReference")]
            public string OriginalSystemBilltoCustomerReference { get; set; }

            [JsonProperty("originalSystemBilltoCustomerAddressReference")]
            public string OriginalSystemBilltoCustomerAddressReference { get; set; }

            [JsonProperty("originalSystemBilltoCustomerContactReference")]
            public string OriginalSystemBilltoCustomerContactReference { get; set; }

            [JsonProperty("originalSystemShiptoCustomerReference")]
            public string OriginalSystemShiptoCustomerReference { get; set; }

            [JsonProperty("originalSystemShiptoCustomerAddressReference")]
            public string OriginalSystemShiptoCustomerAddressReference { get; set; }

            [JsonProperty("originalSystemShiptoCustomerContactReference")]
            public string OriginalSystemShiptoCustomerContactReference { get; set; }

            [JsonProperty("originalSystemShiptoCustomerAccountReference")]
            public string OriginalSystemShiptoCustomerAccountReference { get; set; }

            [JsonProperty("originalSystemShiptoCustomerAccountAddressReference")]
            public string OriginalSystemShiptoCustomerAccountAddressReference { get; set; }

            [JsonProperty("originalSystemShiptoCustomerAccountContactReference")]
            public string OriginalSystemShiptoCustomerAccountContactReference { get; set; }

            [JsonProperty("originalSystemSoldtoCustomerReference")]
            public string OriginalSystemSoldtoCustomerReference { get; set; }

            [JsonProperty("originalSystemSoldtoCustomerAccountReference")]
            public string OriginalSystemSoldtoCustomerAccountReference { get; set; }

            [JsonProperty("transactionLineType")]
            public string TransactionLineType { get; set; }

            [JsonProperty("currencyConversionType")]
            public string CurrencyConversionType { get; set; }

            [JsonProperty("currencyConversionDate")]
            public string CurrencyConversionDate { get; set; }

            [JsonProperty("currencyConversionRate")]
            public string CurrencyConversionRate { get; set; }

            [JsonProperty("transactionLineQuantity")]
            public string TransactionLineQuantity { get; set; }

            [JsonProperty("lineTransactionsFlexfieldContext")]
            public string LineTransactionsFlexfieldContext { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment2")]
            public string LineTransactionsFlexfieldSegment2 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment3")]
            public string LineTransactionsFlexfieldSegment3 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment4")]
            public string LineTransactionsFlexfieldSegment4 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment5")]
            public string LineTransactionsFlexfieldSegment5 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment6")]
            public string LineTransactionsFlexfieldSegment6 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment7")]
            public string LineTransactionsFlexfieldSegment7 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment8")]
            public string LineTransactionsFlexfieldSegment8 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment9")]
            public string LineTransactionsFlexfieldSegment9 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment10")]
            public string LineTransactionsFlexfieldSegment10 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment11")]
            public string LineTransactionsFlexfieldSegment11 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment12")]
            public string LineTransactionsFlexfieldSegment12 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment13")]
            public string LineTransactionsFlexfieldSegment13 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment14")]
            public string LineTransactionsFlexfieldSegment14 { get; set; }

            [JsonProperty("lineTransactionsFlexfieldSegment15")]
            public string LineTransactionsFlexfieldSegment15 { get; set; }

            [JsonProperty("primarySalespersonNumber")]
            public string PrimarySalespersonNumber { get; set; }

            [JsonProperty("taxClassificationCode")]
            public string TaxClassificationCode { get; set; }

            [JsonProperty("legalEntityIdentifier")]
            public string LegalEntityIdentifier { get; set; }

            [JsonProperty("accountedAmountinLedgerCurrency")]
            public string AccountedAmountinLedgerCurrency { get; set; }

            [JsonProperty("salesOrderNumber")]
            public string SalesOrderNumber { get; set; }

            [JsonProperty("salesOrderDate")]
            public string SalesOrderDate { get; set; }

            [JsonProperty("warehouseCode")]
            public string WarehouseCode { get; set; }

            [JsonProperty("unitofMeasureCode")]
            public string UnitofMeasureCode { get; set; }

            [JsonProperty("unitofMeasureName")]
            public string UnitofMeasureName { get; set; }

            [JsonProperty("invoicingRuleName")]
            public string InvoicingRuleName { get; set; }

            [JsonProperty("revenueSchedulingRuleName")]
            public string RevenueSchedulingRuleName { get; set; }

            [JsonProperty("numberofRevenuePeriods")]
            public string NumberofRevenuePeriods { get; set; }

            [JsonProperty("revenueSchedulingRuleStartDate")]
            public string RevenueSchedulingRuleStartDate { get; set; }

            [JsonProperty("revenueSchedulingRuleEndDate")]
            public string RevenueSchedulingRuleEndDate { get; set; }

            [JsonProperty("reasonCodeMeaning")]
            public string ReasonCodeMeaning { get; set; }

            [JsonProperty("lastPeriodtoCredit")]
            public string LastPeriodtoCredit { get; set; }

            [JsonProperty("transactionBusinessCategoryCode")]
            public string TransactionBusinessCategoryCode { get; set; }

            [JsonProperty("productFiscalClassificationCode")]
            public string ProductFiscalClassificationCode { get; set; }

            [JsonProperty("productCategoryCode")]
            public string ProductCategoryCode { get; set; }

            [JsonProperty("productType")]
            public string ProductType { get; set; }

            [JsonProperty("lineIntendedUseCode")]
            public string LineIntendedUseCode { get; set; }

            [JsonProperty("assessableValue")]
            public string AssessableValue { get; set; }

            [JsonProperty("documentSubType")]
            public string DocumentSubType { get; set; }

            [JsonProperty("defaultTaxationCountry")]
            public string DefaultTaxationCountry { get; set; }

            [JsonProperty("userDefinedFiscalClassification")]
            public string UserDefinedFiscalClassification { get; set; }

            [JsonProperty("taxInvoiceNumber")]
            public string TaxInvoiceNumber { get; set; }

            [JsonProperty("taxInvoiceDate")]
            public string TaxInvoiceDate { get; set; }

            [JsonProperty("taxRegimeCode")]
            public string TaxRegimeCode { get; set; }

            [JsonProperty("tax")]
            public string Tax { get; set; }

            [JsonProperty("taxStatusCode")]
            public string TaxStatusCode { get; set; }

            [JsonProperty("taxRateCode")]
            public string TaxRateCode { get; set; }

            [JsonProperty("taxJurisdictionCode")]
            public string TaxJurisdictionCode { get; set; }

            [JsonProperty("firstPartyRegistrationNumber")]
            public string FirstPartyRegistrationNumber { get; set; }

            [JsonProperty("thirdPartyRegistrationNumber")]
            public string ThirdPartyRegistrationNumber { get; set; }

            [JsonProperty("finalDischargeLocation")]
            public string FinalDischargeLocation { get; set; }

            [JsonProperty("taxableAmount")]
            public string TaxableAmount { get; set; }

            [JsonProperty("taxableFlag")]
            public string TaxableFlag { get; set; }

            [JsonProperty("taxExemptionFlag")]
            public string TaxExemptionFlag { get; set; }

            [JsonProperty("taxExemptionReasonCode")]
            public string TaxExemptionReasonCode { get; set; }

            [JsonProperty("taxExemptionReasonCodeMeaning")]
            public string TaxExemptionReasonCodeMeaning { get; set; }

            [JsonProperty("taxExemptionCertificateNumber")]
            public string TaxExemptionCertificateNumber { get; set; }

            [JsonProperty("lineAmountIncludesTaxFlag")]
            public string LineAmountIncludesTaxFlag { get; set; }

            [JsonProperty("taxPrecedence")]
            public string TaxPrecedence { get; set; }

            [JsonProperty("creditMethodToBeUsedForLinesWithRevenueSchedulingRules")]
            public string CreditMethodToBeUsedForLinesWithRevenueSchedulingRules { get; set; }

            [JsonProperty("creditMethodToBeUsedForTransactionsWithSplitPaymentTerms")]
            public string CreditMethodToBeUsedForTransactionsWithSplitPaymentTerms { get; set; }

            [JsonProperty("reasonCode")]
            public string ReasonCode { get; set; }

            [JsonProperty("taxRate")]
            public string TaxRate { get; set; }

            [JsonProperty("fobPoint")]
            public string FobPoint { get; set; }

            [JsonProperty("carrier")]
            public string Carrier { get; set; }

            [JsonProperty("shippingReference")]
            public string ShippingReference { get; set; }

            [JsonProperty("salesOrderLineNumber")]
            public string SalesOrderLineNumber { get; set; }

            [JsonProperty("salesOrderSource")]
            public string SalesOrderSource { get; set; }

            [JsonProperty("salesOrderRevisionNumber")]
            public string SalesOrderRevisionNumber { get; set; }

            [JsonProperty("purchaseOrderNumber")]
            public string PurchaseOrderNumber { get; set; }

            [JsonProperty("purchaseOrderRevisionNumber")]
            public string PurchaseOrderRevisionNumber { get; set; }

            [JsonProperty("purchaseOrderDate")]
            public string PurchaseOrderDate { get; set; }

            [JsonProperty("agreementName")]
            public string AgreementName { get; set; }

            [JsonProperty("documentNumber")]
            public string DocumentNumber { get; set; }

            [JsonProperty("originalSystemBatchName")]
            public string OriginalSystemBatchName { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldContext")]
            public string LinktoTransactionsFlexfieldContext { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment1")]
            public string LinktoTransactionsFlexfieldSegment1 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment2")]
            public string LinktoTransactionsFlexfieldSegment2 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment3")]
            public string LinktoTransactionsFlexfieldSegment3 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment4")]
            public string LinktoTransactionsFlexfieldSegment4 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment5")]
            public string LinktoTransactionsFlexfieldSegment5 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment6")]
            public string LinktoTransactionsFlexfieldSegment6 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment7")]
            public string LinktoTransactionsFlexfieldSegment7 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment8")]
            public string LinktoTransactionsFlexfieldSegment8 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment9")]
            public string LinktoTransactionsFlexfieldSegment9 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment10")]
            public string LinktoTransactionsFlexfieldSegment10 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment11")]
            public string LinktoTransactionsFlexfieldSegment11 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment12")]
            public string LinktoTransactionsFlexfieldSegment12 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment13")]
            public string LinktoTransactionsFlexfieldSegment13 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment14")]
            public string LinktoTransactionsFlexfieldSegment14 { get; set; }

            [JsonProperty("linktoTransactionsFlexfieldSegment15")]
            public string LinktoTransactionsFlexfieldSegment15 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldContext")]
            public string ReferenceTransactionsFlexfieldContext { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment1")]
            public string ReferenceTransactionsFlexfieldSegment1 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment2")]
            public string ReferenceTransactionsFlexfieldSegment2 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment3")]
            public string ReferenceTransactionsFlexfieldSegment3 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment4")]
            public string ReferenceTransactionsFlexfieldSegment4 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment5")]
            public string ReferenceTransactionsFlexfieldSegment5 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment6")]
            public string ReferenceTransactionsFlexfieldSegment6 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment7")]
            public string ReferenceTransactionsFlexfieldSegment7 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment8")]
            public string ReferenceTransactionsFlexfieldSegment8 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment9")]
            public string ReferenceTransactionsFlexfieldSegment9 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment10")]
            public string ReferenceTransactionsFlexfieldSegment10 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment11")]
            public string ReferenceTransactionsFlexfieldSegment11 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment12")]
            public string ReferenceTransactionsFlexfieldSegment12 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment13")]
            public string ReferenceTransactionsFlexfieldSegment13 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment14")]
            public string ReferenceTransactionsFlexfieldSegment14 { get; set; }

            [JsonProperty("referenceTransactionsFlexfieldSegment15")]
            public string ReferenceTransactionsFlexfieldSegment15 { get; set; }

            [JsonProperty("linkToParentLineContext")]
            public string LinkToParentLineContext { get; set; }

            [JsonProperty("linkToParentLineSegment1")]
            public string LinkToParentLineSegment1 { get; set; }

            [JsonProperty("linkToParentLineSegment2")]
            public string LinkToParentLineSegment2 { get; set; }

            [JsonProperty("linkToParentLineSegment3")]
            public string LinkToParentLineSegment3 { get; set; }

            [JsonProperty("linkToParentLineSegment4")]
            public string LinkToParentLineSegment4 { get; set; }

            [JsonProperty("linkToParentLineSegment5")]
            public string LinkToParentLineSegment5 { get; set; }

            [JsonProperty("linkToParentLineSegment6")]
            public string LinkToParentLineSegment6 { get; set; }

            [JsonProperty("linkToParentLineSegment7")]
            public string LinkToParentLineSegment7 { get; set; }

            [JsonProperty("linkToParentLineSegment8")]
            public string LinkToParentLineSegment8 { get; set; }

            [JsonProperty("linkToParentLineSegment9")]
            public string LinkToParentLineSegment9 { get; set; }

            [JsonProperty("linkToParentLineSegment10")]
            public string LinkToParentLineSegment10 { get; set; }

            [JsonProperty("linkToParentLineSegment11")]
            public string LinkToParentLineSegment11 { get; set; }

            [JsonProperty("linkToParentLineSegment12")]
            public string LinkToParentLineSegment12 { get; set; }

            [JsonProperty("linkToParentLineSegment13")]
            public string LinkToParentLineSegment13 { get; set; }

            [JsonProperty("linkToParentLineSegment14")]
            public string LinkToParentLineSegment14 { get; set; }

            [JsonProperty("linkToParentLineSegment15")]
            public string LinkToParentLineSegment15 { get; set; }

            [JsonProperty("printingOption")]
            public string PrintingOption { get; set; }

            [JsonProperty("relatedBatchSourceName")]
            public string RelatedBatchSourceName { get; set; }

            [JsonProperty("relatedTransactionNumber")]
            public string RelatedTransactionNumber { get; set; }

            [JsonProperty("inventoryItemNumber")]
            public string InventoryItemNumber { get; set; }

            [JsonProperty("inventoryItemSegment2")]
            public string InventoryItemSegment2 { get; set; }

            [JsonProperty("inventoryItemSegment3")]
            public string InventoryItemSegment3 { get; set; }

            [JsonProperty("inventoryItemSegment4")]
            public string InventoryItemSegment4 { get; set; }

            [JsonProperty("inventoryItemSegment5")]
            public string InventoryItemSegment5 { get; set; }

            [JsonProperty("inventoryItemSegment6")]
            public string InventoryItemSegment6 { get; set; }

            [JsonProperty("inventoryItemSegment7")]
            public string InventoryItemSegment7 { get; set; }

            [JsonProperty("inventoryItemSegment8")]
            public string InventoryItemSegment8 { get; set; }

            [JsonProperty("inventoryItemSegment9")]
            public string InventoryItemSegment9 { get; set; }

            [JsonProperty("inventoryItemSegment10")]
            public string InventoryItemSegment10 { get; set; }

            [JsonProperty("inventoryItemSegment11")]
            public string InventoryItemSegment11 { get; set; }

            [JsonProperty("inventoryItemSegment12")]
            public string InventoryItemSegment12 { get; set; }

            [JsonProperty("inventoryItemSegment13")]
            public string InventoryItemSegment13 { get; set; }

            [JsonProperty("inventoryItemSegment14")]
            public string InventoryItemSegment14 { get; set; }

            [JsonProperty("inventoryItemSegment15")]
            public string InventoryItemSegment15 { get; set; }

            [JsonProperty("inventoryItemSegment16")]
            public string InventoryItemSegment16 { get; set; }

            [JsonProperty("inventoryItemSegment17")]
            public string InventoryItemSegment17 { get; set; }

            [JsonProperty("inventoryItemSegment18")]
            public string InventoryItemSegment18 { get; set; }

            [JsonProperty("inventoryItemSegment19")]
            public string InventoryItemSegment19 { get; set; }

            [JsonProperty("inventoryItemSegment20")]
            public string InventoryItemSegment20 { get; set; }

            [JsonProperty("billToCustomerBankAccountName")]
            public string BillToCustomerBankAccountName { get; set; }

            [JsonProperty("resetTransactionDateFlag")]
            public string ResetTransactionDateFlag { get; set; }

            [JsonProperty("paymentServerOrderNumber")]
            public string PaymentServerOrderNumber { get; set; }

            [JsonProperty("lastTransactiononDebitAuthorization")]
            public string LastTransactiononDebitAuthorization { get; set; }

            [JsonProperty("approvalCode")]
            public string ApprovalCode { get; set; }

            [JsonProperty("addressVerificationCode")]
            public string AddressVerificationCode { get; set; }

            [JsonProperty("transactionLineTranslatedDescription")]
            public string TransactionLineTranslatedDescription { get; set; }

            [JsonProperty("consolidatedBillingNumber")]
            public string ConsolidatedBillingNumber { get; set; }

            [JsonProperty("promisedCommitmentAmount")]
            public string PromisedCommitmentAmount { get; set; }

            [JsonProperty("paymentSetIdentifier")]
            public string PaymentSetIdentifier { get; set; }

            [JsonProperty("originalAccountingDate")]
            public string OriginalAccountingDate { get; set; }

            [JsonProperty("invoicedLineAccountingLevel")]
            public string InvoicedLineAccountingLevel { get; set; }

            [JsonProperty("overrideAutoAccountingFlag")]
            public string OverrideAutoAccountingFlag { get; set; }

            [JsonProperty("historicalFlag")]
            public string HistoricalFlag { get; set; }

            [JsonProperty("deferralExclusionFlag")]
            public string DeferralExclusionFlag { get; set; }

            [JsonProperty("paymentAttributes")]
            public string PaymentAttributes { get; set; }

            [JsonProperty("invoiceBillingDate")]
            public string InvoiceBillingDate { get; set; }

            [JsonProperty("invoiceLinesFlexfieldContext")]
            public string InvoiceLinesFlexfieldContext { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment1")]
            public string InvoiceLinesFlexfieldSegment1 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment2")]
            public string InvoiceLinesFlexfieldSegment2 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment3")]
            public string InvoiceLinesFlexfieldSegment3 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment5")]
            public string InvoiceLinesFlexfieldSegment5 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment6")]
            public string InvoiceLinesFlexfieldSegment6 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment7")]
            public string InvoiceLinesFlexfieldSegment7 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment8")]
            public string InvoiceLinesFlexfieldSegment8 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment9")]
            public string InvoiceLinesFlexfieldSegment9 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment10")]
            public string InvoiceLinesFlexfieldSegment10 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment11")]
            public string InvoiceLinesFlexfieldSegment11 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment12")]
            public string InvoiceLinesFlexfieldSegment12 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment13")]
            public string InvoiceLinesFlexfieldSegment13 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment14")]
            public string InvoiceLinesFlexfieldSegment14 { get; set; }

            [JsonProperty("invoiceLinesFlexfieldSegment15")]
            public string InvoiceLinesFlexfieldSegment15 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldContext")]
            public string InvoiceTransactionsFlexfieldContext { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment1")]
            public string InvoiceTransactionsFlexfieldSegment1 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment2")]
            public string InvoiceTransactionsFlexfieldSegment2 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment3")]
            public string InvoiceTransactionsFlexfieldSegment3 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment4")]
            public string InvoiceTransactionsFlexfieldSegment4 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment5")]
            public string InvoiceTransactionsFlexfieldSegment5 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment6")]
            public string InvoiceTransactionsFlexfieldSegment6 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment7")]
            public string InvoiceTransactionsFlexfieldSegment7 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment8")]
            public string InvoiceTransactionsFlexfieldSegment8 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment9")]
            public string InvoiceTransactionsFlexfieldSegment9 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment10")]
            public string InvoiceTransactionsFlexfieldSegment10 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment11")]
            public string InvoiceTransactionsFlexfieldSegment11 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment12")]
            public string InvoiceTransactionsFlexfieldSegment12 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment13")]
            public string InvoiceTransactionsFlexfieldSegment13 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment14")]
            public string InvoiceTransactionsFlexfieldSegment14 { get; set; }

            [JsonProperty("invoiceTransactionsFlexfieldSegment15")]
            public string InvoiceTransactionsFlexfieldSegment15 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldContext")]
            public string ReceivablesTransactionRegionInformationFlexfieldContext { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment1")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment1 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment2")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment2 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment3")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment3 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment4")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment4 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment5")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment5 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment6")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment6 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment7")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment7 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment8")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment8 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment9")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment9 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment10")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment10 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment11")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment11 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment12")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment12 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment13")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment13 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment14")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment14 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment15")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment15 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment16")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment16 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment17")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment17 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment18")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment18 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment19")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment19 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment20")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment20 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment21")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment21 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment22")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment22 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment23")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment23 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment24")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment24 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment25")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment25 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment26")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment26 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment27")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment27 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment28")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment28 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment29")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment29 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldSegment30")]
            public string ReceivablesTransactionRegionInformationFlexfieldSegment30 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldAttributeCategory")]
            public string LineGlobalDescriptiveFlexfieldAttributeCategory { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment1")]
            public string LineGlobalDescriptiveFlexfieldSegment1 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment2")]
            public string LineGlobalDescriptiveFlexfieldSegment2 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment3")]
            public string LineGlobalDescriptiveFlexfieldSegment3 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment4")]
            public string LineGlobalDescriptiveFlexfieldSegment4 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment5")]
            public string LineGlobalDescriptiveFlexfieldSegment5 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment6")]
            public string LineGlobalDescriptiveFlexfieldSegment6 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment7")]
            public string LineGlobalDescriptiveFlexfieldSegment7 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment8")]
            public string LineGlobalDescriptiveFlexfieldSegment8 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment9")]
            public string LineGlobalDescriptiveFlexfieldSegment9 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment10")]
            public string LineGlobalDescriptiveFlexfieldSegment10 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment11")]
            public string LineGlobalDescriptiveFlexfieldSegment11 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment12")]
            public string LineGlobalDescriptiveFlexfieldSegment12 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment13")]
            public string LineGlobalDescriptiveFlexfieldSegment13 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment14")]
            public string LineGlobalDescriptiveFlexfieldSegment14 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment15")]
            public string LineGlobalDescriptiveFlexfieldSegment15 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment16")]
            public string LineGlobalDescriptiveFlexfieldSegment16 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment17")]
            public string LineGlobalDescriptiveFlexfieldSegment17 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment18")]
            public string LineGlobalDescriptiveFlexfieldSegment18 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment19")]
            public string LineGlobalDescriptiveFlexfieldSegment19 { get; set; }

            [JsonProperty("lineGlobalDescriptiveFlexfieldSegment20")]
            public string LineGlobalDescriptiveFlexfieldSegment20 { get; set; }

            [JsonProperty("comments")]
            public string Comments { get; set; }

            [JsonProperty("notesfromSource")]
            public string NotesfromSource { get; set; }

            [JsonProperty("creditCardTokenNumber")]
            public string CreditCardTokenNumber { get; set; }

            [JsonProperty("creditCardExpirationDate")]
            public string CreditCardExpirationDate { get; set; }

            [JsonProperty("firstNameoftheCreditCardHolder")]
            public string FirstNameoftheCreditCardHolder { get; set; }

            [JsonProperty("lastNameoftheCreditCardHolder")]
            public string LastNameoftheCreditCardHolder { get; set; }

            [JsonProperty("creditCardIssuerCode")]
            public string CreditCardIssuerCode { get; set; }

            [JsonProperty("maskedCreditCardNumber")]
            public string MaskedCreditCardNumber { get; set; }

            [JsonProperty("creditCardAuthorizationRequestIdentifier")]
            public string CreditCardAuthorizationRequestIdentifier { get; set; }

            [JsonProperty("creditCardVoiceAuthorizationCode")]
            public string CreditCardVoiceAuthorizationCode { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment1")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment1 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment2")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment2 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment3")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment3 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment4")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment4 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment5")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment5 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment6")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment6 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment7")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment7 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment8")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment8 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment9")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment9 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment10")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment10 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment11")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment11 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldNumberSegment12")]
            public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment12 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldDateSegment1")]
            public string ReceivablesTransactionRegionInformationFlexfieldDateSegment1 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldDateSegment2")]
            public string ReceivablesTransactionRegionInformationFlexfieldDateSegment2 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldDateSegment3")]
            public string ReceivablesTransactionRegionInformationFlexfieldDateSegment3 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldDateSegment4")]
            public string ReceivablesTransactionRegionInformationFlexfieldDateSegment4 { get; set; }

            [JsonProperty("receivablesTransactionRegionInformationFlexfieldDateSegment5")]
            public string ReceivablesTransactionRegionInformationFlexfieldDateSegment5 { get; set; }

            [JsonProperty("receivablesTransactionLineRegionInformationFlexfieldNumberSegment1")]
            public string ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment1 { get; set; }

            [JsonProperty("receivablesTransactionLineRegionInformationFlexfieldNumberSegment2")]
            public string ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment2 { get; set; }

            [JsonProperty("receivablesTransactionLineRegionInformationFlexfieldNumberSegment3")]
            public string ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment3 { get; set; }

            [JsonProperty("receivablesTransactionLineRegionInformationFlexfieldNumberSegment4")]
            public string ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment4 { get; set; }

            [JsonProperty("receivablesTransactionLineRegionInformationFlexfieldNumberSegment5")]
            public string ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment5 { get; set; }

            [JsonProperty("receivablesTransactionLineRegionInformationFlexfieldDateSegment1")]
            public string ReceivablesTransactionLineRegionInformationFlexfieldDateSegment1 { get; set; }

            [JsonProperty("receivablesTransactionLineRegionInformationFlexfieldDateSegment2")]
            public string ReceivablesTransactionLineRegionInformationFlexfieldDateSegment2 { get; set; }

            [JsonProperty("receivablesTransactionLineRegionInformationFlexfieldDateSegment3")]
            public string ReceivablesTransactionLineRegionInformationFlexfieldDateSegment3 { get; set; }

            [JsonProperty("receivablesTransactionLineRegionInformationFlexfieldDateSegment4")]
            public string ReceivablesTransactionLineRegionInformationFlexfieldDateSegment4 { get; set; }

            [JsonProperty("receivablesTransactionLineRegionInformationFlexfieldDateSegment5")]
            public string ReceivablesTransactionLineRegionInformationFlexfieldDateSegment5 { get; set; }

            [JsonProperty("freightCharge")]
            public string FreightCharge { get; set; }

            [JsonProperty("insuranceCharge")]
            public string InsuranceCharge { get; set; }

            [JsonProperty("packingCharge")]
            public string PackingCharge { get; set; }

            [JsonProperty("miscellaneousCharge")]
            public string MiscellaneousCharge { get; set; }

            [JsonProperty("commercialDiscount")]
            public string CommercialDiscount { get; set; }

            [JsonProperty("enforceChronologicalDocumentSequencing")]
            public string EnforceChronologicalDocumentSequencing { get; set; }
        


    }
}

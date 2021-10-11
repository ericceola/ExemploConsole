using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleINT096
{
   public class FileCsv
    {
        public string BusinessUnitIdentifier { get; set; }
        public string BusinessUnitName { get; set; }
        public string TransactionBatchSourceName { get; set; }
        public string TransactionTypeName { get; set; }
        public string PaymentTerms { get; set; }
        public string TransactionDate { get; set; }
        public string AccountingDate { get; set; }
        public string TransactionNumber { get; set; }
        public string OriginalSystemBilltoCustomerReference { get; set; }
        public string OriginalSystemBilltoCustomerAddressReference { get; set; }
        public string OriginalSystemBilltoCustomerContactReference { get; set; }
        public string OriginalSystemShiptoCustomerReference { get; set; }
        public string OriginalSystemShiptoCustomerAddressReference { get; set; }
        public string OriginalSystemShiptoCustomerContactReference { get; set; }
        public string OriginalSystemShiptoCustomerAccountReference { get; set; }
        public string OriginalSystemShiptoCustomerAccountAddressReference { get; set; }
        public string OriginalSystemShiptoCustomerAccountContactReference { get; set; }
        public string OriginalSystemSoldtoCustomerReference { get; set; }
        public string OriginalSystemSoldtoCustomerAccountReference { get; set; }
        public string BilltoCustomerAccountNumber { get; set; }
        public string BilltoCustomerSiteNumber { get; set; }
        public string BilltoContactPartyNumber { get; set; }
        public string ShiptoCustomerAccountNumber { get; set; }
        public string ShiptoCustomerSiteNumber { get; set; }
        public string ShiptoContactPartyNumber { get; set; }
        public string SoldtoCustomerAccountNumber { get; set; }
        public string TransactionLineType { get; set; }
        public string TransactionLineDescription { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyConversionType { get; set; }
        public string CurrencyConversionDate { get; set; }
        public string CurrencyConversionRate { get; set; }
        public string TransactionLineAmount { get; set; }
        public string TransactionLineQuantity { get; set; }
        public string CustomerOrderedQuantity { get; set; }
        public string UnitSellingPrice { get; set; }
        public string UnitStandardPrice { get; set; }
        public string LineTransactionsFlexfieldContext { get; set; }
        public string LineTransactionsFlexfieldSegment1 { get; set; }
        public string LineTransactionsFlexfieldSegment2 { get; set; }
        public string LineTransactionsFlexfieldSegment3 { get; set; }
        public string LineTransactionsFlexfieldSegment4 { get; set; }
        public string LineTransactionsFlexfieldSegment5 { get; set; }
        public string LineTransactionsFlexfieldSegment6 { get; set; }
        public string LineTransactionsFlexfieldSegment7 { get; set; }
        public string LineTransactionsFlexfieldSegment8 { get; set; }
        public string LineTransactionsFlexfieldSegment9 { get; set; }
        public string LineTransactionsFlexfieldSegment10 { get; set; }
        public string LineTransactionsFlexfieldSegment11 { get; set; }
        public string LineTransactionsFlexfieldSegment12 { get; set; }
        public string LineTransactionsFlexfieldSegment13 { get; set; }
        public string LineTransactionsFlexfieldSegment14 { get; set; }
        public string LineTransactionsFlexfieldSegment15 { get; set; }
        public string PrimarySalespersonNumber { get; set; }
        public string TaxClassificationCode { get; set; }
        public string LegalEntityIdentifier { get; set; }
        public string AccountedAmountinLedgerCurrency { get; set; }
        public string SalesOrderNumber { get; set; }
        public string SalesOrderDate { get; set; }
        public string ActualShipDate { get; set; }
        public string WarehouseCode { get; set; }
        public string UnitofMeasureCode { get; set; }
        public string UnitofMeasureName { get; set; }
        public string InvoicingRuleName { get; set; }
        public string RevenueSchedulingRuleName { get; set; }
        public string NumberofRevenuePeriods { get; set; }
        public string RevenueSchedulingRuleStartDate { get; set; }
        public string RevenueSchedulingRuleEndDate { get; set; }
        public string ReasonCodeMeaning { get; set; }
        public string LastPeriodtoCredit { get; set; }
        public string TransactionBusinessCategoryCode { get; set; }
        public string ProductFiscalClassificationCode { get; set; }
        public string ProductCategoryCode { get; set; }
        public string ProductType { get; set; }
        public string LineIntendedUseCode { get; set; }
        public string AssessableValue { get; set; }
        public string DocumentSubType { get; set; }
        public string DefaultTaxationCountry { get; set; }
        public string UserDefinedFiscalClassification { get; set; }
        public string TaxInvoiceNumber { get; set; }
        public string TaxInvoiceDate { get; set; }
        public string TaxRegimeCode { get; set; }
        public string Tax { get; set; }
        public string TaxStatusCode { get; set; }
        public string TaxRateCode { get; set; }
        public string TaxJurisdictionCode { get; set; }
        public string FirstPartyRegistrationNumber { get; set; }
        public string ThirdPartyRegistrationNumber { get; set; }
        public string FinalDischargeLocation { get; set; }
        public string TaxableAmount { get; set; }
        public string TaxableFlag { get; set; }
        public string TaxExemptionFlag { get; set; }
        public string TaxExemptionReasonCode { get; set; }
        public string TaxExemptionReasonCodeMeaning { get; set; }
        public string TaxExemptionCertificateNumber { get; set; }
        public string LineAmountIncludesTaxFlag { get; set; }
        public string TaxPrecedence { get; set; }
        public string CreditMethodToBeUsedForLinesWithRevenueSchedulingRules { get; set; }
        public string CreditMethodToBeUsedForTransactionsWithSplitPaymentTerms { get; set; }
        public string ReasonCode { get; set; }
        public string TaxRate { get; set; }
        public string FOBPoint { get; set; }
        public string Carrier { get; set; }
        public string ShippingReference { get; set; }
        public string SalesOrderLineNumber { get; set; }
        public string SalesOrderSource { get; set; }
        public string SalesOrderRevisionNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string PurchaseOrderRevisionNumber { get; set; }
        public string PurchaseOrderDate { get; set; }
        public string AgreementName { get; set; }
        public string MemoLineName { get; set; }
        public string DocumentNumber { get; set; }
        public string OriginalSystemBatchName { get; set; }
        public string LinktoTransactionsFlexfieldContext { get; set; }
        public string LinktoTransactionsFlexfieldSegment1 { get; set; }
        public string LinktoTransactionsFlexfieldSegment2 { get; set; }
        public string LinktoTransactionsFlexfieldSegment3 { get; set; }
        public string LinktoTransactionsFlexfieldSegment4 { get; set; }
        public string LinktoTransactionsFlexfieldSegment5 { get; set; }
        public string LinktoTransactionsFlexfieldSegment6 { get; set; }
        public string LinktoTransactionsFlexfieldSegment7 { get; set; }
        public string LinktoTransactionsFlexfieldSegment8 { get; set; }
        public string LinktoTransactionsFlexfieldSegment9 { get; set; }
        public string LinktoTransactionsFlexfieldSegment10 { get; set; }
        public string LinktoTransactionsFlexfieldSegment11 { get; set; }
        public string LinktoTransactionsFlexfieldSegment12 { get; set; }
        public string LinktoTransactionsFlexfieldSegment13 { get; set; }
        public string LinktoTransactionsFlexfieldSegment14 { get; set; }
        public string LinktoTransactionsFlexfieldSegment15 { get; set; }
        public string ReferenceTransactionsFlexfieldContext { get; set; }
        public string ReferenceTransactionsFlexfieldSegment1 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment2 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment3 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment4 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment5 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment6 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment7 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment8 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment9 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment10 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment11 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment12 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment13 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment14 { get; set; }
        public string ReferenceTransactionsFlexfieldSegment15 { get; set; }
        public string LinkToParentLineContext { get; set; }
        public string LinkToParentLineSegment1 { get; set; }
        public string LinkToParentLineSegment2 { get; set; }
        public string LinkToParentLineSegment3 { get; set; }
        public string LinkToParentLineSegment4 { get; set; }
        public string LinkToParentLineSegment5 { get; set; }
        public string LinkToParentLineSegment6 { get; set; }
        public string LinkToParentLineSegment7 { get; set; }
        public string LinkToParentLineSegment8 { get; set; }
        public string LinkToParentLineSegment9 { get; set; }
        public string LinkToParentLineSegment10 { get; set; }
        public string LinkToParentLineSegment11 { get; set; }
        public string LinkToParentLineSegment12 { get; set; }
        public string LinkToParentLineSegment13 { get; set; }
        public string LinkToParentLineSegment14 { get; set; }
        public string LinkToParentLineSegment15 { get; set; }
        public string ReceiptMethodName { get; set; }
        public string PrintingOption { get; set; }
        public string RelatedBatchSourceName { get; set; }
        public string RelatedTransactionNumber { get; set; }
        public string InventoryItemNumber { get; set; }
        public string InventoryItemSegment2 { get; set; }
        public string InventoryItemSegment3 { get; set; }
        public string InventoryItemSegment4 { get; set; }
        public string InventoryItemSegment5 { get; set; }
        public string InventoryItemSegment6 { get; set; }
        public string InventoryItemSegment7 { get; set; }
        public string InventoryItemSegment8 { get; set; }
        public string InventoryItemSegment9 { get; set; }
        public string InventoryItemSegment10 { get; set; }
        public string InventoryItemSegment11 { get; set; }
        public string InventoryItemSegment12 { get; set; }
        public string InventoryItemSegment13 { get; set; }
        public string InventoryItemSegment14 { get; set; }
        public string InventoryItemSegment15 { get; set; }
        public string InventoryItemSegment16 { get; set; }
        public string InventoryItemSegment17 { get; set; }
        public string InventoryItemSegment18 { get; set; }
        public string InventoryItemSegment19 { get; set; }
        public string InventoryItemSegment20 { get; set; }
        public string BillToCustomerBankAccountName { get; set; }
        public string ResetTransactionDateFlag { get; set; }
        public string PaymentServerOrderNumber { get; set; }
        public string LastTransactiononDebitAuthorization { get; set; }
        public string ApprovalCode { get; set; }
        public string AddressVerificationCode { get; set; }
        public string TransactionLineTranslatedDescription { get; set; }
        public string ConsolidatedBillingNumber { get; set; }
        public string PromisedCommitmentAmount { get; set; }
        public string PaymentSetIdentifier { get; set; }
        public string OriginalAccountingDate { get; set; }
        public string InvoicedLineAccountingLevel { get; set; }
        public string OverrideAutoAccountingFlag { get; set; }
        public string HistoricalFlag { get; set; }
        public string DeferralExclusionFlag { get; set; }
        public string PaymentAttributes { get; set; }
        public string InvoiceBillingDate { get; set; }
        public string InvoiceLinesFlexfieldContext { get; set; }
        public string InvoiceLinesFlexfieldSegment1 { get; set; }
        public string InvoiceLinesFlexfieldSegment2 { get; set; }
        public string InvoiceLinesFlexfieldSegment3 { get; set; }
        public string InvoiceLinesFlexfieldSegment4 { get; set; }
        public string InvoiceLinesFlexfieldSegment5 { get; set; }
        public string InvoiceLinesFlexfieldSegment6 { get; set; }
        public string InvoiceLinesFlexfieldSegment7 { get; set; }
        public string InvoiceLinesFlexfieldSegment8 { get; set; }
        public string InvoiceLinesFlexfieldSegment9 { get; set; }
        public string InvoiceLinesFlexfieldSegment10 { get; set; }
        public string InvoiceLinesFlexfieldSegment11 { get; set; }
        public string InvoiceLinesFlexfieldSegment12 { get; set; }
        public string InvoiceLinesFlexfieldSegment13 { get; set; }
        public string InvoiceLinesFlexfieldSegment14 { get; set; }
        public string InvoiceLinesFlexfieldSegment15 { get; set; }
        public string InvoiceTransactionsFlexfieldContext { get; set; }
        public string InvoiceTransactionsFlexfieldSegment1 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment2 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment3 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment4 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment5 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment6 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment7 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment8 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment9 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment10 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment11 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment12 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment13 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment14 { get; set; }
        public string InvoiceTransactionsFlexfieldSegment15 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldContext { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment1 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment2 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment3 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment4 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment5 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment6 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment7 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment8 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment9 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment10 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment11 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment12 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment13 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment14 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment15 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment16 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment17 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment18 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment19 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment20 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment21 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment22 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment23 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment24 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment25 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment26 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment27 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment28 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment29 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldSegment30 { get; set; }
        public string LineGlobalDescriptiveFlexfieldAttributeCategory { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment1 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment2 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment3 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment4 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment5 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment6 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment7 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment8 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment9 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment10 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment11 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment12 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment13 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment14 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment15 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment16 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment17 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment18 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment19 { get; set; }
        public string LineGlobalDescriptiveFlexfieldSegment20 { get; set; }
        public string Comments { get; set; }
        public string NotesfromSource { get; set; }
        public string CreditCardTokenNumber { get; set; }
        public string CreditCardExpirationDate { get; set; }
        public string FirstNameoftheCreditCardHolder { get; set; }
        public string LastNameoftheCreditCardHolder { get; set; }
        public string CreditCardIssuerCode { get; set; }
        public string MaskedCreditCardNumber { get; set; }
        public string CreditCardAuthorizationRequestIdentifier { get; set; }
        public string CreditCardVoiceAuthorizationCode { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment1 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment2 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment3 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment4 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment5 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment6 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment7 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment8 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment9 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment10 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment11 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldNumberSegment12 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldDateSegment1 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldDateSegment2 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldDateSegment3 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldDateSegment4 { get; set; }
        public string ReceivablesTransactionRegionInformationFlexfieldDateSegment5 { get; set; }
        public string ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment1 { get; set; }
        public string ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment2 { get; set; }
        public string ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment3 { get; set; }
        public string ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment4 { get; set; }
        public string ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment5 { get; set; }
        public string ReceivablesTransactionLineRegionInformationFlexfieldDateSegment1 { get; set; }
        public string ReceivablesTransactionLineRegionInformationFlexfieldDateSegment2 { get; set; }
        public string ReceivablesTransactionLineRegionInformationFlexfieldDateSegment3 { get; set; }
        public string ReceivablesTransactionLineRegionInformationFlexfieldDateSegment4 { get; set; }
        public string ReceivablesTransactionLineRegionInformationFlexfieldDateSegment5 { get; set; }
        public string FreightCharge { get; set; }
        public string InsuranceCharge { get; set; }
        public string PackingCharge { get; set; }
        public string MiscellaneousCharge { get; set; }
        public string CommercialDiscount { get; set; }
        public string EnforceChronologicalDocumentSequencing { get; set; }

        public override string ToString()
        {
            return $"{BusinessUnitIdentifier},{BusinessUnitName},{TransactionBatchSourceName},{TransactionTypeName},{PaymentTerms},{TransactionDate}," +
                   $"{AccountingDate},{TransactionNumber},{OriginalSystemBilltoCustomerReference},{OriginalSystemBilltoCustomerAddressReference}," +
                   $"{OriginalSystemBilltoCustomerContactReference},{OriginalSystemShiptoCustomerReference},{OriginalSystemShiptoCustomerAddressReference}," +
                   $"{OriginalSystemShiptoCustomerContactReference},{OriginalSystemShiptoCustomerAccountReference},{OriginalSystemShiptoCustomerAccountAddressReference}," +
                   $"{OriginalSystemShiptoCustomerAccountContactReference},{OriginalSystemSoldtoCustomerReference},{OriginalSystemSoldtoCustomerAccountReference}," +
                   $"{BilltoCustomerAccountNumber},{BilltoCustomerSiteNumber},{BilltoContactPartyNumber},{ShiptoCustomerAccountNumber},{ShiptoCustomerSiteNumber}," +
                   $"{ShiptoContactPartyNumber},{SoldtoCustomerAccountNumber},{TransactionLineType},{TransactionLineDescription},{CurrencyCode},{CurrencyConversionType}," +
                   $"{CurrencyConversionDate},{CurrencyConversionRate},{TransactionLineAmount},{TransactionLineQuantity},{CustomerOrderedQuantity}," +
                   $"{UnitSellingPrice},{UnitStandardPrice},{LineTransactionsFlexfieldContext},{LineTransactionsFlexfieldSegment1},{LineTransactionsFlexfieldSegment2}," +
                   $"{LineTransactionsFlexfieldSegment3},{LineTransactionsFlexfieldSegment4},{LineTransactionsFlexfieldSegment5},{LineTransactionsFlexfieldSegment6}," +
                   $"{LineTransactionsFlexfieldSegment7},{LineTransactionsFlexfieldSegment8},{LineTransactionsFlexfieldSegment9},{LineTransactionsFlexfieldSegment10}," +
                   $"{LineTransactionsFlexfieldSegment11},{LineTransactionsFlexfieldSegment12},{LineTransactionsFlexfieldSegment13},{LineTransactionsFlexfieldSegment14}," +
                   $"{LineTransactionsFlexfieldSegment15},{PrimarySalespersonNumber},{TaxClassificationCode},{LegalEntityIdentifier},{AccountedAmountinLedgerCurrency}," +
                   $"{SalesOrderNumber},{SalesOrderDate},{ActualShipDate},{WarehouseCode},{UnitofMeasureCode},{UnitofMeasureName},{InvoicingRuleName},{RevenueSchedulingRuleName}," +
                   $"{NumberofRevenuePeriods},{RevenueSchedulingRuleStartDate},{RevenueSchedulingRuleEndDate},{ReasonCodeMeaning},{LastPeriodtoCredit}," +
                   $"{TransactionBusinessCategoryCode},{ProductFiscalClassificationCode},{ProductCategoryCode},{ProductType},{LineIntendedUseCode},{AssessableValue}," +
                   $"{DocumentSubType},{DefaultTaxationCountry},{UserDefinedFiscalClassification},{TaxInvoiceNumber},{TaxInvoiceDate},{TaxRegimeCode},{Tax},{TaxStatusCode}," +
                   $"{TaxRateCode},{TaxJurisdictionCode},{FirstPartyRegistrationNumber},{ThirdPartyRegistrationNumber},{FinalDischargeLocation},{TaxableAmount},{TaxableFlag}," +
                   $"{TaxExemptionFlag},{TaxExemptionReasonCode},{TaxExemptionReasonCodeMeaning},{TaxExemptionCertificateNumber},{LineAmountIncludesTaxFlag},{TaxPrecedence}," +
                   $"{CreditMethodToBeUsedForLinesWithRevenueSchedulingRules},{CreditMethodToBeUsedForTransactionsWithSplitPaymentTerms},{ReasonCode},{TaxRate},{FOBPoint}," +
                   $"{Carrier},{ShippingReference},{SalesOrderLineNumber},{SalesOrderSource},{SalesOrderRevisionNumber},{PurchaseOrderNumber},{PurchaseOrderRevisionNumber}," +
                   $"{PurchaseOrderDate},{AgreementName},{MemoLineName},{DocumentNumber},{OriginalSystemBatchName},{LinktoTransactionsFlexfieldContext}," +
                   $"{LinktoTransactionsFlexfieldSegment1},{LinktoTransactionsFlexfieldSegment2},{LinktoTransactionsFlexfieldSegment3},{LinktoTransactionsFlexfieldSegment4}," +
                   $"{LinktoTransactionsFlexfieldSegment5},{LinktoTransactionsFlexfieldSegment6},{LinktoTransactionsFlexfieldSegment7},{LinktoTransactionsFlexfieldSegment8}," +
                   $"{LinktoTransactionsFlexfieldSegment9},{LinktoTransactionsFlexfieldSegment10},{LinktoTransactionsFlexfieldSegment11},{LinktoTransactionsFlexfieldSegment12}," +
                   $"{LinktoTransactionsFlexfieldSegment13},{LinktoTransactionsFlexfieldSegment14},{LinktoTransactionsFlexfieldSegment15},{ReferenceTransactionsFlexfieldContext}," +
                   $"{ReferenceTransactionsFlexfieldSegment1},{ReferenceTransactionsFlexfieldSegment2},{ReferenceTransactionsFlexfieldSegment3}," +
                   $"{ReferenceTransactionsFlexfieldSegment4},{ReferenceTransactionsFlexfieldSegment5},{ReferenceTransactionsFlexfieldSegment6}," +
                   $"{ReferenceTransactionsFlexfieldSegment7},{ReferenceTransactionsFlexfieldSegment8},{ReferenceTransactionsFlexfieldSegment9}," +
                   $"{ReferenceTransactionsFlexfieldSegment10},{ReferenceTransactionsFlexfieldSegment11},{ReferenceTransactionsFlexfieldSegment12}," +
                   $"{ReferenceTransactionsFlexfieldSegment13},{ReferenceTransactionsFlexfieldSegment14},{ReferenceTransactionsFlexfieldSegment15}," +
                   $"{LinkToParentLineContext},{LinkToParentLineSegment1},{LinkToParentLineSegment2},{LinkToParentLineSegment3},{LinkToParentLineSegment4},{LinkToParentLineSegment5}," +
                   $"{LinkToParentLineSegment6},{LinkToParentLineSegment7},{LinkToParentLineSegment8},{LinkToParentLineSegment9},{LinkToParentLineSegment10}," +
                   $"{LinkToParentLineSegment11},{LinkToParentLineSegment12},{LinkToParentLineSegment13},{LinkToParentLineSegment14},{LinkToParentLineSegment15},{ReceiptMethodName}," +
                   $"{PrintingOption},{RelatedBatchSourceName},{RelatedTransactionNumber},{InventoryItemNumber},{InventoryItemSegment2},{InventoryItemSegment3}," +
                   $"{InventoryItemSegment4},{InventoryItemSegment5},{InventoryItemSegment6},{InventoryItemSegment7},{InventoryItemSegment8},{InventoryItemSegment9}," +
                   $"{InventoryItemSegment10},{InventoryItemSegment11},{InventoryItemSegment12},{InventoryItemSegment13},{InventoryItemSegment14},{InventoryItemSegment15}," +
                   $"{InventoryItemSegment16},{InventoryItemSegment17},{InventoryItemSegment18},{InventoryItemSegment19},{InventoryItemSegment20},{BillToCustomerBankAccountName}," +
                   $"{ResetTransactionDateFlag},{PaymentServerOrderNumber},{LastTransactiononDebitAuthorization},{ApprovalCode},{AddressVerificationCode}," +
                   $"{TransactionLineTranslatedDescription},{ConsolidatedBillingNumber},{PromisedCommitmentAmount},{PaymentSetIdentifier},{OriginalAccountingDate}," +
                   $"{InvoicedLineAccountingLevel},{OverrideAutoAccountingFlag},{HistoricalFlag},{DeferralExclusionFlag},{PaymentAttributes},{InvoiceBillingDate}," +
                   $"{InvoiceLinesFlexfieldContext},{InvoiceLinesFlexfieldSegment1},{InvoiceLinesFlexfieldSegment2},{InvoiceLinesFlexfieldSegment3},{InvoiceLinesFlexfieldSegment4}," +
                   $"{InvoiceLinesFlexfieldSegment5},{InvoiceLinesFlexfieldSegment6},{InvoiceLinesFlexfieldSegment7},{InvoiceLinesFlexfieldSegment8},{InvoiceLinesFlexfieldSegment9}," +
                   $"{InvoiceLinesFlexfieldSegment10},{InvoiceLinesFlexfieldSegment11},{InvoiceLinesFlexfieldSegment12},{InvoiceLinesFlexfieldSegment13}," +
                   $"{InvoiceLinesFlexfieldSegment14},{InvoiceLinesFlexfieldSegment15},{InvoiceTransactionsFlexfieldContext},{InvoiceTransactionsFlexfieldSegment1}," +
                   $"{InvoiceTransactionsFlexfieldSegment2},{InvoiceTransactionsFlexfieldSegment3},{InvoiceTransactionsFlexfieldSegment4},{InvoiceTransactionsFlexfieldSegment5}," +
                   $"{InvoiceTransactionsFlexfieldSegment6},{InvoiceTransactionsFlexfieldSegment7},{InvoiceTransactionsFlexfieldSegment8},{InvoiceTransactionsFlexfieldSegment9}," +
                   $"{InvoiceTransactionsFlexfieldSegment10},{InvoiceTransactionsFlexfieldSegment11},{InvoiceTransactionsFlexfieldSegment12},{InvoiceTransactionsFlexfieldSegment13}," +
                   $"{InvoiceTransactionsFlexfieldSegment14},{InvoiceTransactionsFlexfieldSegment15},{ReceivablesTransactionRegionInformationFlexfieldContext}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment1},{ReceivablesTransactionRegionInformationFlexfieldSegment2}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment3},{ReceivablesTransactionRegionInformationFlexfieldSegment4}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment5},{ReceivablesTransactionRegionInformationFlexfieldSegment6}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment7},{ReceivablesTransactionRegionInformationFlexfieldSegment8}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment9},{ReceivablesTransactionRegionInformationFlexfieldSegment10}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment11},{ReceivablesTransactionRegionInformationFlexfieldSegment12}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment13},{ReceivablesTransactionRegionInformationFlexfieldSegment14}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment15},{ReceivablesTransactionRegionInformationFlexfieldSegment16}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment17},{ReceivablesTransactionRegionInformationFlexfieldSegment18}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment19},{ReceivablesTransactionRegionInformationFlexfieldSegment20}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment21},{ReceivablesTransactionRegionInformationFlexfieldSegment22}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment23},{ReceivablesTransactionRegionInformationFlexfieldSegment24}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment25},{ReceivablesTransactionRegionInformationFlexfieldSegment26}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment27},{ReceivablesTransactionRegionInformationFlexfieldSegment28}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldSegment29},{ReceivablesTransactionRegionInformationFlexfieldSegment30}," +
                   $"{LineGlobalDescriptiveFlexfieldAttributeCategory},{LineGlobalDescriptiveFlexfieldSegment1},{LineGlobalDescriptiveFlexfieldSegment2}," +
                   $"{LineGlobalDescriptiveFlexfieldSegment3},{LineGlobalDescriptiveFlexfieldSegment4},{LineGlobalDescriptiveFlexfieldSegment5}," +
                   $"{LineGlobalDescriptiveFlexfieldSegment6},{LineGlobalDescriptiveFlexfieldSegment7},{LineGlobalDescriptiveFlexfieldSegment8}," +
                   $"{LineGlobalDescriptiveFlexfieldSegment9},{LineGlobalDescriptiveFlexfieldSegment10},{LineGlobalDescriptiveFlexfieldSegment11}," +
                   $"{LineGlobalDescriptiveFlexfieldSegment12},{LineGlobalDescriptiveFlexfieldSegment13},{LineGlobalDescriptiveFlexfieldSegment14}," +
                   $"{LineGlobalDescriptiveFlexfieldSegment15},{LineGlobalDescriptiveFlexfieldSegment16},{LineGlobalDescriptiveFlexfieldSegment17}," +
                   $"{LineGlobalDescriptiveFlexfieldSegment18},{LineGlobalDescriptiveFlexfieldSegment19},{LineGlobalDescriptiveFlexfieldSegment20},{Comments},{NotesfromSource}," +
                   $"{CreditCardTokenNumber},{CreditCardExpirationDate},{FirstNameoftheCreditCardHolder},{LastNameoftheCreditCardHolder},{CreditCardIssuerCode}," +
                   $"{MaskedCreditCardNumber},{CreditCardAuthorizationRequestIdentifier},{CreditCardVoiceAuthorizationCode}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldNumberSegment1},{ReceivablesTransactionRegionInformationFlexfieldNumberSegment2}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldNumberSegment3},{ReceivablesTransactionRegionInformationFlexfieldNumberSegment4}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldNumberSegment5},{ReceivablesTransactionRegionInformationFlexfieldNumberSegment6}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldNumberSegment7},{ReceivablesTransactionRegionInformationFlexfieldNumberSegment8}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldNumberSegment9},{ReceivablesTransactionRegionInformationFlexfieldNumberSegment10}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldNumberSegment11},{ReceivablesTransactionRegionInformationFlexfieldNumberSegment12}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldDateSegment1},{ReceivablesTransactionRegionInformationFlexfieldDateSegment2}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldDateSegment3},{ReceivablesTransactionRegionInformationFlexfieldDateSegment4}," +
                   $"{ReceivablesTransactionRegionInformationFlexfieldDateSegment5},{ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment1}," +
                   $"{ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment2},{ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment3}," +
                   $"{ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment4},{ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment5}," +
                   $"{ReceivablesTransactionLineRegionInformationFlexfieldDateSegment1},{ReceivablesTransactionLineRegionInformationFlexfieldDateSegment2}," +
                   $"{ReceivablesTransactionLineRegionInformationFlexfieldDateSegment3},{ReceivablesTransactionLineRegionInformationFlexfieldDateSegment4}," +
                   $"{ReceivablesTransactionLineRegionInformationFlexfieldDateSegment5},{FreightCharge},{InsuranceCharge},{PackingCharge},{MiscellaneousCharge}," +
                   $"{CommercialDiscount},{EnforceChronologicalDocumentSequencing}";

        }
    }
}

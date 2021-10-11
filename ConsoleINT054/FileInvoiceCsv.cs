using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleINT054
{
    public class FileInvoiceCsv
    {
        public string InvoiceID { get; set; }
        public string BusinessUnit { get; set; }
        public string Source { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceAmount { get; set; }
        public string InvoiceDate { get; set; }
        public string SupplierName { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierSite { get; set; }
        public string InvoiceCurrency { get; set; }
        public string PaymentCurrency { get; set; }
        public string Description { get; set; }
        public string ImportSet { get; set; }
        public string InvoiceType { get; set; }
        public string LegalEntity { get; set; }
        public string CustomerTaxRegistrationNumber { get; set; }
        public string CustomerRegistrationCode { get; set; }
        public string FirstPartyTaxRegistrationNumber { get; set; }
        public string SupplierTaxRegistrationNumber { get; set; }
        public string PaymentTerms { get; set; }
        public string TermsDate { get; set; }
        public string GoodsReceivedDate { get; set; }
        public string InvoiceReceivedDate { get; set; }
        public string AccountingDate { get; set; }
        public string PaymentMethod { get; set; }
        public string PayGroup { get; set; }
        public string PayAlone { get; set; }
        public string DiscountableAmount { get; set; }
        public string PrepaymentNumber { get; set; }
        public string PrepaymentLineNumber { get; set; }
        public string PrepaymentApplicationAmount { get; set; }
        public string PrepaymentAccountingDate { get; set; }
        public string InvoiceIncludesPrepayment { get; set; }
        public string ConversionRateType { get; set; }
        public string ConversionDate { get; set; }
        public string ConversionRate { get; set; }
        public string LiabilityCombination { get; set; }
        public string DocumentCategoryCode { get; set; }
        public string VoucherNumber { get; set; }
        public string DeliveryChannelCode { get; set; }
        public string BankChargeBearer { get; set; }
        public string RemittoSupplier { get; set; }
        public string RemittoSupplierNumber { get; set; }
        public string RemittoAddressName { get; set; }
        public string PaymentPriority { get; set; }
        public string SettlementPriority { get; set; }
        public string UniqueRemittanceIdentifier { get; set; }
        public string UniqueRemittanceIdentifierCheckDigit { get; set; }
        public string PaymentReasonCode { get; set; }
        public string PaymentReasonComments { get; set; }
        public string RemittanceMessage1 { get; set; }
        public string RemittanceMessage2 { get; set; }
        public string RemittanceMessage3 { get; set; }
        public string WithholdingTaxGroup { get; set; }
        public string ShiptoLocation { get; set; }
        public string TaxationCountry { get; set; }
        public string DocumentSubType { get; set; }
        public string TaxInvoiceInternalSequenceNumber { get; set; }
        public string SupplierTaxInvoiceNumber { get; set; }
        public string TaxInvoiceRecordingDate { get; set; }
        public string SupplierTaxInvoiceDate { get; set; }
        public string SupplierTaxInvoiceConversionRate { get; set; }
        public string PortOfEntryCode { get; set; }
        public string ImportDocumentNumber { get; set; }
        public string ImportDocumentDate { get; set; }
        public string TaxControlAmount { get; set; }
        public string CalculateTaxDuringImport { get; set; }
        public string AddTaxToInvoiceAmount { get; set; }
        public string AttributeCategory { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
        public string Attribute4 { get; set; }
        public string Attribute5 { get; set; }
        public string Attribute6 { get; set; }
        public string Attribute7 { get; set; }
        public string Attribute8 { get; set; }
        public string Attribute9 { get; set; }
        public string Attribute10 { get; set; }
        public string Attribute11 { get; set; }
        public string Attribute12 { get; set; }
        public string Attribute13 { get; set; }
        public string Attribute14 { get; set; }
        public string Attribute15 { get; set; }
        public string AttributeNumber1 { get; set; }
        public string AttributeNumber2 { get; set; }
        public string AttributeNumber3 { get; set; }
        public string AttributeNumber4 { get; set; }
        public string AttributeNumber5 { get; set; }
        public string AttributeDate1 { get; set; }
        public string AttributeDate2 { get; set; }
        public string AttributeDate3 { get; set; }
        public string AttributeDate4 { get; set; }
        public string AttributeDate5 { get; set; }
        public string GlobalAttributeCategory { get; set; }
        public string GlobalAttribute1 { get; set; }
        public string GlobalAttribute2 { get; set; }
        public string GlobalAttribute3 { get; set; }
        public string GlobalAttribute4 { get; set; }
        public string GlobalAttribute5 { get; set; }
        public string GlobalAttribute6 { get; set; }
        public string GlobalAttribute7 { get; set; }
        public string GlobalAttribute8 { get; set; }
        public string GlobalAttribute9 { get; set; }
        public string GlobalAttribute10 { get; set; }
        public string GlobalAttribute11 { get; set; }
        public string GlobalAttribute12 { get; set; }
        public string GlobalAttribute13 { get; set; }
        public string GlobalAttribute14 { get; set; }
        public string GlobalAttribute15 { get; set; }
        public string GlobalAttribute16 { get; set; }
        public string GlobalAttribute17 { get; set; }
        public string GlobalAttribute18 { get; set; }
        public string GlobalAttribute19 { get; set; }
        public string GlobalAttribute20 { get; set; }
        public string GlobalAttributeNumber1 { get; set; }
        public string GlobalAttributeNumber2 { get; set; }
        public string GlobalAttributeNumber3 { get; set; }
        public string GlobalAttributeNumber4 { get; set; }
        public string GlobalAttributeNumber5 { get; set; }
        public string GlobalAttributeDate1 { get; set; }
        public string GlobalAttributeDate2 { get; set; }
        public string GlobalAttributeDate3 { get; set; }
        public string GlobalAttributeDate4 { get; set; }
        public string GlobalAttributeDate5 { get; set; }
        public string URLAttachments { get; set; }

        public override string ToString()
        {

            return $"{InvoiceID},{BusinessUnit},{Source},{InvoiceNumber},{InvoiceAmount},{InvoiceDate},{SupplierName},{SupplierNumber},{SupplierSite}," +
                   $"{InvoiceCurrency},{PaymentCurrency},{Description},{ImportSet},{InvoiceType},{LegalEntity},{CustomerTaxRegistrationNumber}," +
                   $"{CustomerRegistrationCode},{FirstPartyTaxRegistrationNumber},{SupplierTaxRegistrationNumber},{PaymentTerms},{TermsDate},{GoodsReceivedDate}," +
                   $"{InvoiceReceivedDate},{AccountingDate},{PaymentMethod},{PayGroup},{PayAlone},{DiscountableAmount},{PrepaymentNumber},{PrepaymentLineNumber}," +
                   $"{PrepaymentApplicationAmount},{PrepaymentAccountingDate},{InvoiceIncludesPrepayment},{ConversionRateType},{ConversionDate},{ConversionRate}," +
                   $"{LiabilityCombination},{DocumentCategoryCode},{VoucherNumber},{DeliveryChannelCode},{BankChargeBearer},{RemittoSupplier},{RemittoSupplierNumber}," +
                   $"{RemittoAddressName},{PaymentPriority},{SettlementPriority},{UniqueRemittanceIdentifier},{UniqueRemittanceIdentifierCheckDigit},{PaymentReasonCode}," +
                   $"{PaymentReasonComments},{RemittanceMessage1},{RemittanceMessage2},{RemittanceMessage3},{WithholdingTaxGroup},{ShiptoLocation},{TaxationCountry}," +
                   $"{DocumentSubType},{TaxInvoiceInternalSequenceNumber},{SupplierTaxInvoiceNumber},{TaxInvoiceRecordingDate},{SupplierTaxInvoiceDate}," +
                   $"{SupplierTaxInvoiceConversionRate},{PortOfEntryCode},{ImportDocumentNumber},{ImportDocumentDate},{TaxControlAmount},{CalculateTaxDuringImport}," +
                   $"{AddTaxToInvoiceAmount},{AttributeCategory},{Attribute1},{Attribute2},{Attribute3},{Attribute4},{Attribute5},{Attribute6},{Attribute7}," +
                   $"{Attribute8},{Attribute9},{Attribute10},{Attribute11},{Attribute12},{Attribute13},{Attribute14},{Attribute15},{AttributeNumber1},{AttributeNumber2}," +
                   $"{AttributeNumber3},{AttributeNumber4},{AttributeNumber5},{AttributeDate1},{AttributeDate2},{AttributeDate3},{AttributeDate4},{AttributeDate5}," +
                   $"{GlobalAttributeCategory},{GlobalAttribute1},{GlobalAttribute2},{GlobalAttribute3},{GlobalAttribute4},{GlobalAttribute5},{GlobalAttribute6}," +
                   $"{GlobalAttribute7},{GlobalAttribute8},{GlobalAttribute9},{GlobalAttribute10},{GlobalAttribute11},{GlobalAttribute12},{GlobalAttribute13}," +
                   $"{GlobalAttribute14},{GlobalAttribute15},{GlobalAttribute16},{GlobalAttribute17},{GlobalAttribute18},{GlobalAttribute19},{GlobalAttribute20}," +
                   $"{GlobalAttributeNumber1},{GlobalAttributeNumber2},{GlobalAttributeNumber3},{GlobalAttributeNumber4},{GlobalAttributeNumber5},{GlobalAttributeDate1}," +
                   $"{GlobalAttributeDate2},{GlobalAttributeDate3},{GlobalAttributeDate4},{GlobalAttributeDate5},{URLAttachments}"; 

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleINT054
{
    public class FileLineCsv
    {
        public string InvoiceID { get; set; }
        public string LineNumber { get; set; }
        public string LineType { get; set; }
        public string Amount { get; set; }
        public string InvoiceQuantity { get; set; }
        public string UnitPrice { get; set; }
        public string UOM { get; set; }
        public string Description { get; set; }
        public string PONumber { get; set; }
        public string POLineNumber { get; set; }
        public string POScheduleNumber { get; set; }
        public string PODistributionNumber { get; set; }
        public string ItemDescription { get; set; }
        public string POReleaseNumber { get; set; }
        public string PurchasingCategory { get; set; }
        public string ReceiptNumber { get; set; }
        public string ReceiptLineNumber { get; set; }
        public string ConsumptionAdviceNumber { get; set; }
        public string ConsumptionAdviceLineNumber { get; set; }
        public string PackingSlip { get; set; }
        public string FinalMatch { get; set; }
        public string DistributionCombination { get; set; }
        public string DistributionSet { get; set; }
        public string AccountingDate { get; set; }
        public string OverlayAccountSegment { get; set; }
        public string OverlayPrimaryBalancingSegment { get; set; }
        public string OverlayCostCenterSegment { get; set; }
        public string TaxClassificationCode { get; set; }
        public string ShiptoLocation { get; set; }
        public string ShipfromLocation { get; set; }
        public string LocationofFinalDischarge { get; set; }
        public string TransactionBusinessCategory { get; set; }
        public string ProductFiscalClassification { get; set; }
        public string IntendedUse { get; set; }
        public string UserDefinedFiscalClassification { get; set; }
        public string ProductType { get; set; }
        public string AssessableValue { get; set; }
        public string ProductCategory { get; set; }
        public string TaxControlAmount { get; set; }
        public string TaxRegimeCode { get; set; }
        public string Tax { get; set; }
        public string TaxStatusCode { get; set; }
        public string TaxJurisdictionCode { get; set; }
        public string TaxRateCode { get; set; }
        public string TaxRate { get; set; }
        public string WithholdingTaxGroup { get; set; }
        public string IncomeTaxType { get; set; }
        public string IncomeTaxRegion { get; set; }
        public string ProrateAcrossAllItemLines { get; set; }
        public string LineGroupNumber { get; set; }
        public string CostFactorName { get; set; }
        public string StatisticalQuantity { get; set; }
        public string TrackasAsset { get; set; }
        public string AssetBookTypeCode { get; set; }
        public string AssetCategoryID { get; set; }
        public string SerialNumber { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNumber { get; set; }
        public string WarrantyNumber { get; set; }
        public string PriceCorrectionLine { get; set; }
        public string PriceCorrectionInvoiceNumber { get; set; }
        public string PriceCorrectionInvoiceLineNumber { get; set; }
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
        public string ExpenditureItemDate { get; set; }
        public string ProjectNumber { get; set; }
        public string TaskNumber { get; set; }
        public string ExpenditureType { get; set; }
        public string ExpenditureOrganization { get; set; }
        public string FiscalChargeType { get; set; }
        public string ProjectName { get; set; }
        public string TaskName { get; set; }

        public override string ToString()
        {
            return $"{InvoiceID},{LineNumber},{LineType},{Amount},{InvoiceQuantity},{UnitPrice},{UOM},{Description},{PONumber}," +
                   $"{POLineNumber},{POScheduleNumber},{PODistributionNumber},{ItemDescription},{POReleaseNumber},{PurchasingCategory}," +
                   $"{ReceiptNumber},{ReceiptLineNumber},{ConsumptionAdviceNumber},{ConsumptionAdviceLineNumber},{PackingSlip},{FinalMatch}," +
                   $"{DistributionCombination},{DistributionSet},{AccountingDate},{OverlayAccountSegment},{OverlayPrimaryBalancingSegment}," +
                   $"{OverlayCostCenterSegment},{TaxClassificationCode},{ShiptoLocation},{ShipfromLocation},{LocationofFinalDischarge}," +
                   $"{TransactionBusinessCategory},{ProductFiscalClassification},{IntendedUse},{UserDefinedFiscalClassification}," +
                   $"{ProductType},{AssessableValue},{ProductCategory},{TaxControlAmount},{TaxRegimeCode},{Tax},{TaxStatusCode},{TaxJurisdictionCode}," +
                   $"{TaxRateCode},{TaxRate},{WithholdingTaxGroup},{IncomeTaxType},{IncomeTaxRegion},{ProrateAcrossAllItemLines},{LineGroupNumber}," +
                   $"{CostFactorName},{StatisticalQuantity},{TrackasAsset},{AssetBookTypeCode},{AssetCategoryID},{SerialNumber},{Manufacturer}," +
                   $"{ModelNumber},{WarrantyNumber},{PriceCorrectionLine},{PriceCorrectionInvoiceNumber},{PriceCorrectionInvoiceLineNumber},{AttributeCategory}," +
                   $"{Attribute1},{Attribute2},{Attribute3},{Attribute4},{Attribute5},{Attribute6},{Attribute7},{Attribute8},{Attribute9},{Attribute10}," +
                   $"{Attribute11},{Attribute12},{Attribute13},{Attribute14},{Attribute15},{AttributeNumber1},{AttributeNumber2},{AttributeNumber3}," +
                   $"{AttributeNumber4},{AttributeNumber5},{AttributeDate1},{AttributeDate2},{AttributeDate3},{AttributeDate4},{AttributeDate5}," +
                   $"{GlobalAttributeCategory},{GlobalAttribute1},{GlobalAttribute2},{GlobalAttribute3},{GlobalAttribute4},{GlobalAttribute5}," +
                   $"{GlobalAttribute6},{GlobalAttribute7},{GlobalAttribute8},{GlobalAttribute9},{GlobalAttribute10},{GlobalAttribute11},{GlobalAttribute12}," +
                   $"{GlobalAttribute13},{GlobalAttribute14},{GlobalAttribute15},{GlobalAttribute16},{GlobalAttribute17},{GlobalAttribute18},{GlobalAttribute19}," +
                   $"{GlobalAttribute20},{GlobalAttributeNumber1},{GlobalAttributeNumber2},{GlobalAttributeNumber3},{GlobalAttributeNumber4},{GlobalAttributeNumber5}," +
                   $"{GlobalAttributeDate1},{GlobalAttributeDate2},{GlobalAttributeDate3},{GlobalAttributeDate4},{GlobalAttributeDate5},{ExpenditureItemDate}," +
                   $"{ProjectNumber},{TaskNumber},{ExpenditureType},{ExpenditureOrganization},{FiscalChargeType},{ProjectName},{TaskName}";

        }

    }
}

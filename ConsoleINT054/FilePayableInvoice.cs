using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleINT054
{
    public class FilePayableInvoice : FilePayableInvoiceFactory
    {
        public static AppSettings appsetting;
        public override string Parser(BaseAracFile baseAracFile)
        {
            string company = string.Empty;

            DateTime dataFechamentoContabilidade = DateTime.ParseExact(baseAracFile.FECHA_CONTABILIZACION.Trim(), "YYYYMMdd", CultureInfo.InvariantCulture);

            FileInvoiceCsv fileInvoiceCsv = new FileInvoiceCsv();

            fileInvoiceCsv.InvoiceID = ""; // Sequencial 
            fileInvoiceCsv.BusinessUnit = ""; //Parâmetro do front
            fileInvoiceCsv.Source = appsetting.FileInvoiceSettings.Source; // linha 14
            fileInvoiceCsv.InvoiceNumber = baseAracFile.NUMERO_DE_DOCUMENTO;
            fileInvoiceCsv.InvoiceAmount = baseAracFile.NUMERO_DE_DOCUMENTO; // Verificar linha 16  AP_INVOICE_LINES_INTERFACE.AMOUNT
            fileInvoiceCsv.InvoiceDate = dataFechamentoContabilidade.ToString("yyyy/MM/DD");

            #region Procurement.Suppliers.GetSupplier - Linha 18,19 e 20

            fileInvoiceCsv.DocumentSubType = "ORA_BR_IATA";
            fileInvoiceCsv.SupplierName = "";
            fileInvoiceCsv.SupplierNumber = "";

            fileInvoiceCsv.SupplierSite = "";


            #endregion

            fileInvoiceCsv.InvoiceCurrency = baseAracFile.MONEDA;
            fileInvoiceCsv.PaymentCurrency = baseAracFile.MONEDA;

            if(baseAracFile.CODIGO_ARACS == "METV")
            {
                fileInvoiceCsv.Description = $"INCENTIVO VARIAVEL {baseAracFile.FECHA_CONTABILIZACION}";
            }
            else
            {
                fileInvoiceCsv.Description = $"FATURAS CREDORAS {baseAracFile.FECHA_CONTABILIZACION}";
            }

            fileInvoiceCsv.ImportSet = "";
            fileInvoiceCsv.InvoiceType = appsetting.FileInvoiceSettings.InvoiceType;
            fileInvoiceCsv.LegalEntity = "";
            fileInvoiceCsv.CustomerTaxRegistrationNumber = "";
            fileInvoiceCsv.CustomerRegistrationCode = "";
            fileInvoiceCsv.FirstPartyTaxRegistrationNumber = "";
            fileInvoiceCsv.SupplierTaxRegistrationNumber = "";

            DateTime DataVencimento = DateTime.Parse(baseAracFile.FECHA_VENCIMIENTO);
            DateTime DataContabilizacao = DateTime.Parse(baseAracFile.FECHA_CONTABILIZACION);
            int NumDias = (DataVencimento - DataContabilizacao).Days;

            fileInvoiceCsv.PaymentTerms = $"{NumDias} DIAS";
            fileInvoiceCsv.TermsDate = dataFechamentoContabilidade.ToString("yyyy/MM/dd");
            fileInvoiceCsv.GoodsReceivedDate = dataFechamentoContabilidade.ToString("yyyy/MM/dd");
            fileInvoiceCsv.InvoiceReceivedDate = dataFechamentoContabilidade.ToString("yyyy/MM/dd"); 
            fileInvoiceCsv.AccountingDate = dataFechamentoContabilidade.ToString("yyyy/MM/dd");

            fileInvoiceCsv.PaymentMethod = "";
            fileInvoiceCsv.PayGroup = "";
            fileInvoiceCsv.PayAlone = "";
            fileInvoiceCsv.DiscountableAmount = "";
            fileInvoiceCsv.PrepaymentNumber = "";
            fileInvoiceCsv.PrepaymentLineNumber = "";
            fileInvoiceCsv.PrepaymentApplicationAmount = "";
            fileInvoiceCsv.PrepaymentAccountingDate = "";
            fileInvoiceCsv.InvoiceIncludesPrepayment = "";
            fileInvoiceCsv.ConversionRateType = "";
            fileInvoiceCsv.ConversionDate = "";
            fileInvoiceCsv.ConversionRate = "";
            fileInvoiceCsv.LiabilityCombination = "";
            fileInvoiceCsv.DocumentCategoryCode = "";
            fileInvoiceCsv.VoucherNumber = "";
            fileInvoiceCsv.DeliveryChannelCode = "";
            fileInvoiceCsv.BankChargeBearer = "";
            fileInvoiceCsv.RemittoSupplier = "";
            fileInvoiceCsv.RemittoSupplierNumber = "";
            fileInvoiceCsv.RemittoAddressName = "";
            fileInvoiceCsv.PaymentPriority = "";
            fileInvoiceCsv.SettlementPriority = "";
            fileInvoiceCsv.UniqueRemittanceIdentifier = "";
            fileInvoiceCsv.UniqueRemittanceIdentifierCheckDigit = "";
            fileInvoiceCsv.PaymentReasonCode = "";
            fileInvoiceCsv.PaymentReasonComments = "";
            fileInvoiceCsv.RemittanceMessage1 = "";
            fileInvoiceCsv.RemittanceMessage2 = "";
            fileInvoiceCsv.RemittanceMessage3 = "";
            fileInvoiceCsv.WithholdingTaxGroup = "";
            fileInvoiceCsv.ShiptoLocation = "";
            fileInvoiceCsv.TaxationCountry = "";
            fileInvoiceCsv.DocumentSubType = "";
            fileInvoiceCsv.TaxInvoiceInternalSequenceNumber = "";
            fileInvoiceCsv.SupplierTaxInvoiceNumber = "";
            fileInvoiceCsv.TaxInvoiceRecordingDate = "";
            fileInvoiceCsv.SupplierTaxInvoiceDate = "";
            fileInvoiceCsv.SupplierTaxInvoiceConversionRate = "";
            fileInvoiceCsv.PortOfEntryCode = "";
            fileInvoiceCsv.ImportDocumentNumber = "";
            fileInvoiceCsv.ImportDocumentDate = "";
            fileInvoiceCsv.TaxControlAmount = "";
            fileInvoiceCsv.CalculateTaxDuringImport = "";
            fileInvoiceCsv.AddTaxToInvoiceAmount = "";
            fileInvoiceCsv.AttributeCategory = "";
            fileInvoiceCsv.Attribute1 = "";
            fileInvoiceCsv.Attribute2 = "";
            fileInvoiceCsv.Attribute3 = "";
            fileInvoiceCsv.Attribute4 = "";
            fileInvoiceCsv.Attribute5 = "";
            fileInvoiceCsv.Attribute6 = "";
            fileInvoiceCsv.Attribute7 = "";
            fileInvoiceCsv.Attribute8 = "";
            fileInvoiceCsv.Attribute9 = "";
            fileInvoiceCsv.Attribute10 = "";
            fileInvoiceCsv.Attribute11 = "";
            fileInvoiceCsv.Attribute12 = "";
            fileInvoiceCsv.Attribute13 = "";
            fileInvoiceCsv.Attribute14 = "";
            fileInvoiceCsv.Attribute15 = "";
            fileInvoiceCsv.AttributeNumber1 = "";
            fileInvoiceCsv.AttributeNumber2 = "";
            fileInvoiceCsv.AttributeNumber3 = "";
            fileInvoiceCsv.AttributeNumber4 = "";
            fileInvoiceCsv.AttributeNumber5 = "";
            fileInvoiceCsv.AttributeDate1 = "";
            fileInvoiceCsv.AttributeDate2 = "";
            fileInvoiceCsv.AttributeDate3 = "";
            fileInvoiceCsv.AttributeDate4 = "";
            fileInvoiceCsv.AttributeDate5 = "";
            fileInvoiceCsv.GlobalAttributeCategory = "";
            fileInvoiceCsv.GlobalAttribute1 = "";
            fileInvoiceCsv.GlobalAttribute2 = "";
            fileInvoiceCsv.GlobalAttribute3 = "";
            fileInvoiceCsv.GlobalAttribute4 = "";
            fileInvoiceCsv.GlobalAttribute5 = "";
            fileInvoiceCsv.GlobalAttribute6 = "";
            fileInvoiceCsv.GlobalAttribute7 = "";
            fileInvoiceCsv.GlobalAttribute8 = "";
            fileInvoiceCsv.GlobalAttribute9 = "";
            fileInvoiceCsv.GlobalAttribute10 = "";
            fileInvoiceCsv.GlobalAttribute11 = "";
            fileInvoiceCsv.GlobalAttribute12 = "";
            fileInvoiceCsv.GlobalAttribute13 = "";
            fileInvoiceCsv.GlobalAttribute14 = "";
            fileInvoiceCsv.GlobalAttribute15 = "";
            fileInvoiceCsv.GlobalAttribute16 = "";
            fileInvoiceCsv.GlobalAttribute17 = "";
            fileInvoiceCsv.GlobalAttribute18 = "";
            fileInvoiceCsv.GlobalAttribute19 = "";
            fileInvoiceCsv.GlobalAttribute20 = "";
            fileInvoiceCsv.GlobalAttributeNumber1 = "";
            fileInvoiceCsv.GlobalAttributeNumber2 = "";
            fileInvoiceCsv.GlobalAttributeNumber3 = "";
            fileInvoiceCsv.GlobalAttributeNumber4 = "";
            fileInvoiceCsv.GlobalAttributeNumber5 = "";
            fileInvoiceCsv.GlobalAttributeDate1 = "";
            fileInvoiceCsv.GlobalAttributeDate2 = "";
            fileInvoiceCsv.GlobalAttributeDate3 = "";
            fileInvoiceCsv.GlobalAttributeDate4 = "";
            fileInvoiceCsv.GlobalAttributeDate5 = "";
            fileInvoiceCsv.URLAttachments = "";

            return fileInvoiceCsv.ToString();
        }

       private string ParserInvoice(BaseAracFile baseAracFile)
        {
            DateTime dataFechamentoContabilidade = DateTime.ParseExact(baseAracFile.FECHA_CONTABILIZACION.Trim(), "YYYYMMdd", CultureInfo.InvariantCulture);

            FileInvoiceCsv fileInvoiceCsv = new FileInvoiceCsv();

            fileInvoiceCsv.InvoiceID = ""; // Sequencial 
            fileInvoiceCsv.BusinessUnit = ""; //Parâmetro do front
            fileInvoiceCsv.Source = appsetting.FileInvoiceSettings.Source; // linha 14
            fileInvoiceCsv.InvoiceNumber = baseAracFile.NUMERO_DE_DOCUMENTO;
            fileInvoiceCsv.InvoiceAmount = baseAracFile.NUMERO_DE_DOCUMENTO; // Verificar linha 16  AP_INVOICE_LINES_INTERFACE.AMOUNT
            fileInvoiceCsv.InvoiceDate = dataFechamentoContabilidade.ToString("yyyy/MM/DD");

            #region Procurement.Suppliers.GetSupplier - Linha 18,19 e 20

            fileInvoiceCsv.DocumentSubType = "ORA_BR_IATA";
            fileInvoiceCsv.SupplierName = "";
            fileInvoiceCsv.SupplierNumber = "";

            fileInvoiceCsv.SupplierSite = "";


            #endregion

            fileInvoiceCsv.InvoiceCurrency = baseAracFile.MONEDA;
            fileInvoiceCsv.PaymentCurrency = baseAracFile.MONEDA;

            if (baseAracFile.CODIGO_ARACS == "METV")
            {
                fileInvoiceCsv.Description = $"INCENTIVO VARIAVEL {baseAracFile.FECHA_CONTABILIZACION}";
            }
            else
            {
                fileInvoiceCsv.Description = $"FATURAS CREDORAS {baseAracFile.FECHA_CONTABILIZACION}";
            }

            fileInvoiceCsv.ImportSet = "";
            fileInvoiceCsv.InvoiceType = appsetting.FileInvoiceSettings.InvoiceType;
            fileInvoiceCsv.LegalEntity = "";
            fileInvoiceCsv.CustomerTaxRegistrationNumber = "";
            fileInvoiceCsv.CustomerRegistrationCode = "";
            fileInvoiceCsv.FirstPartyTaxRegistrationNumber = "";
            fileInvoiceCsv.SupplierTaxRegistrationNumber = "";

            DateTime DataVencimento = DateTime.Parse(baseAracFile.FECHA_VENCIMIENTO);
            DateTime DataContabilizacao = DateTime.Parse(baseAracFile.FECHA_CONTABILIZACION);
            int NumDias = (DataVencimento - DataContabilizacao).Days;

            fileInvoiceCsv.PaymentTerms = $"{NumDias} DIAS";
            fileInvoiceCsv.TermsDate = dataFechamentoContabilidade.ToString("yyyy/MM/dd");
            fileInvoiceCsv.GoodsReceivedDate = dataFechamentoContabilidade.ToString("yyyy/MM/dd");
            fileInvoiceCsv.InvoiceReceivedDate = dataFechamentoContabilidade.ToString("yyyy/MM/dd");
            fileInvoiceCsv.AccountingDate = dataFechamentoContabilidade.ToString("yyyy/MM/dd");

            fileInvoiceCsv.PaymentMethod = "";
            fileInvoiceCsv.PayGroup = "";
            fileInvoiceCsv.PayAlone = "";
            fileInvoiceCsv.DiscountableAmount = "";
            fileInvoiceCsv.PrepaymentNumber = "";
            fileInvoiceCsv.PrepaymentLineNumber = "";
            fileInvoiceCsv.PrepaymentApplicationAmount = "";
            fileInvoiceCsv.PrepaymentAccountingDate = "";
            fileInvoiceCsv.InvoiceIncludesPrepayment = "";
            fileInvoiceCsv.ConversionRateType = "";
            fileInvoiceCsv.ConversionDate = "";
            fileInvoiceCsv.ConversionRate = "";
            fileInvoiceCsv.LiabilityCombination = "";
            fileInvoiceCsv.DocumentCategoryCode = "";
            fileInvoiceCsv.VoucherNumber = "";
            fileInvoiceCsv.DeliveryChannelCode = "";
            fileInvoiceCsv.BankChargeBearer = "";
            fileInvoiceCsv.RemittoSupplier = "";
            fileInvoiceCsv.RemittoSupplierNumber = "";
            fileInvoiceCsv.RemittoAddressName = "";
            fileInvoiceCsv.PaymentPriority = "";
            fileInvoiceCsv.SettlementPriority = "";
            fileInvoiceCsv.UniqueRemittanceIdentifier = "";
            fileInvoiceCsv.UniqueRemittanceIdentifierCheckDigit = "";
            fileInvoiceCsv.PaymentReasonCode = "";
            fileInvoiceCsv.PaymentReasonComments = "";
            fileInvoiceCsv.RemittanceMessage1 = "";
            fileInvoiceCsv.RemittanceMessage2 = "";
            fileInvoiceCsv.RemittanceMessage3 = "";
            fileInvoiceCsv.WithholdingTaxGroup = "";
            fileInvoiceCsv.ShiptoLocation = "";
            fileInvoiceCsv.TaxationCountry = "";
            fileInvoiceCsv.DocumentSubType = "";
            fileInvoiceCsv.TaxInvoiceInternalSequenceNumber = "";
            fileInvoiceCsv.SupplierTaxInvoiceNumber = "";
            fileInvoiceCsv.TaxInvoiceRecordingDate = "";
            fileInvoiceCsv.SupplierTaxInvoiceDate = "";
            fileInvoiceCsv.SupplierTaxInvoiceConversionRate = "";
            fileInvoiceCsv.PortOfEntryCode = "";
            fileInvoiceCsv.ImportDocumentNumber = "";
            fileInvoiceCsv.ImportDocumentDate = "";
            fileInvoiceCsv.TaxControlAmount = "";
            fileInvoiceCsv.CalculateTaxDuringImport = "";
            fileInvoiceCsv.AddTaxToInvoiceAmount = "";
            fileInvoiceCsv.AttributeCategory = "";
            fileInvoiceCsv.Attribute1 = "";
            fileInvoiceCsv.Attribute2 = "";
            fileInvoiceCsv.Attribute3 = "";
            fileInvoiceCsv.Attribute4 = "";
            fileInvoiceCsv.Attribute5 = "";
            fileInvoiceCsv.Attribute6 = "";
            fileInvoiceCsv.Attribute7 = "";
            fileInvoiceCsv.Attribute8 = "";
            fileInvoiceCsv.Attribute9 = "";
            fileInvoiceCsv.Attribute10 = "";
            fileInvoiceCsv.Attribute11 = "";
            fileInvoiceCsv.Attribute12 = "";
            fileInvoiceCsv.Attribute13 = "";
            fileInvoiceCsv.Attribute14 = "";
            fileInvoiceCsv.Attribute15 = "";
            fileInvoiceCsv.AttributeNumber1 = "";
            fileInvoiceCsv.AttributeNumber2 = "";
            fileInvoiceCsv.AttributeNumber3 = "";
            fileInvoiceCsv.AttributeNumber4 = "";
            fileInvoiceCsv.AttributeNumber5 = "";
            fileInvoiceCsv.AttributeDate1 = "";
            fileInvoiceCsv.AttributeDate2 = "";
            fileInvoiceCsv.AttributeDate3 = "";
            fileInvoiceCsv.AttributeDate4 = "";
            fileInvoiceCsv.AttributeDate5 = "";
            fileInvoiceCsv.GlobalAttributeCategory = "";
            fileInvoiceCsv.GlobalAttribute1 = "";
            fileInvoiceCsv.GlobalAttribute2 = "";
            fileInvoiceCsv.GlobalAttribute3 = "";
            fileInvoiceCsv.GlobalAttribute4 = "";
            fileInvoiceCsv.GlobalAttribute5 = "";
            fileInvoiceCsv.GlobalAttribute6 = "";
            fileInvoiceCsv.GlobalAttribute7 = "";
            fileInvoiceCsv.GlobalAttribute8 = "";
            fileInvoiceCsv.GlobalAttribute9 = "";
            fileInvoiceCsv.GlobalAttribute10 = "";
            fileInvoiceCsv.GlobalAttribute11 = "";
            fileInvoiceCsv.GlobalAttribute12 = "";
            fileInvoiceCsv.GlobalAttribute13 = "";
            fileInvoiceCsv.GlobalAttribute14 = "";
            fileInvoiceCsv.GlobalAttribute15 = "";
            fileInvoiceCsv.GlobalAttribute16 = "";
            fileInvoiceCsv.GlobalAttribute17 = "";
            fileInvoiceCsv.GlobalAttribute18 = "";
            fileInvoiceCsv.GlobalAttribute19 = "";
            fileInvoiceCsv.GlobalAttribute20 = "";
            fileInvoiceCsv.GlobalAttributeNumber1 = "";
            fileInvoiceCsv.GlobalAttributeNumber2 = "";
            fileInvoiceCsv.GlobalAttributeNumber3 = "";
            fileInvoiceCsv.GlobalAttributeNumber4 = "";
            fileInvoiceCsv.GlobalAttributeNumber5 = "";
            fileInvoiceCsv.GlobalAttributeDate1 = "";
            fileInvoiceCsv.GlobalAttributeDate2 = "";
            fileInvoiceCsv.GlobalAttributeDate3 = "";
            fileInvoiceCsv.GlobalAttributeDate4 = "";
            fileInvoiceCsv.GlobalAttributeDate5 = "";
            fileInvoiceCsv.URLAttachments = "";

            return fileInvoiceCsv.ToString();
        }

        private string ParserInvoiceLine(BaseAracFile baseAracFile)
        {
            string company = string.Empty;

            DateTime dataFechamentoContabilidade = DateTime.ParseExact(baseAracFile.FECHA_CONTABILIZACION.Trim(), "YYYYMMdd", CultureInfo.InvariantCulture);

            FileLineCsv fileLineCsv = new FileLineCsv();
            fileLineCsv.InvoiceID = ""; //Linha 143 - Sequencial
            fileLineCsv.LineNumber = "";
            fileLineCsv.LineType = appsetting.FileInvoiceLineSettings.LineType;
            
            if(baseAracFile.INDICADOR_DC == "C")
            {
               fileLineCsv.Amount = ((Double.Parse(baseAracFile.IMPORTE) / 100) * -1).ToString();
            }
            else
            {
                fileLineCsv.Amount = (Double.Parse(baseAracFile.IMPORTE) / 100).ToString();
            }

            fileLineCsv.InvoiceQuantity = "";
            fileLineCsv.UnitPrice = "";
            fileLineCsv.UOM = "";
            fileLineCsv.Description = baseAracFile.CUENTA_CONTABLE;
            fileLineCsv.PONumber = "";
            fileLineCsv.POLineNumber = "";
            fileLineCsv.POScheduleNumber = "";
            fileLineCsv.PODistributionNumber = "";
            fileLineCsv.ItemDescription = "";
            fileLineCsv.POReleaseNumber = "";
            fileLineCsv.PurchasingCategory = "";
            fileLineCsv.ReceiptNumber = "";
            fileLineCsv.ReceiptLineNumber = "";
            fileLineCsv.ConsumptionAdviceNumber = "";
            fileLineCsv.ConsumptionAdviceLineNumber = "";
            fileLineCsv.PackingSlip = "";
            fileLineCsv.FinalMatch = "";


            switch(baseAracFile.CUENTA_CONTABLE)
            {
                case "51401001":
                    fileLineCsv.DistributionCombination = $"01.001.1151.{baseAracFile.CUENTA_CONTABLE}.0.00.00000.00000";
                    break;
                case "51401003":
                    fileLineCsv.DistributionCombination = $"01.001.1510.{baseAracFile.CUENTA_CONTABLE}.0.00.I VAR.00000";
                    break;
                default:
                    fileLineCsv.DistributionCombination = $"01.000.0000.{baseAracFile.CUENTA_CONTABLE}.0.00.00000.00000";
                    break;
            }

            fileLineCsv.DistributionSet = "";

            DateTime accountingDate = DateTime.ParseExact(baseAracFile.CUENTA_CONTABLE.Trim(), "YYYYMMdd", CultureInfo.InvariantCulture);

            fileLineCsv.AccountingDate = accountingDate.ToString("yyyy/MM/dd");
            fileLineCsv.OverlayAccountSegment = "";
            fileLineCsv.OverlayPrimaryBalancingSegment = "";
            fileLineCsv.OverlayCostCenterSegment = "";
            fileLineCsv.TaxClassificationCode = "";
            fileLineCsv.ShiptoLocation = appsetting.FileInvoiceLineSettings.ShiptoLocation;
            fileLineCsv.ShipfromLocation = "";
            fileLineCsv.LocationofFinalDischarge = "";
            fileLineCsv.TransactionBusinessCategory = "";
            fileLineCsv.ProductFiscalClassification = "";
            fileLineCsv.IntendedUse = "";
            fileLineCsv.UserDefinedFiscalClassification = "";
            fileLineCsv.ProductType = "";
            fileLineCsv.AssessableValue = "";
            fileLineCsv.ProductCategory = "";
            fileLineCsv.TaxControlAmount = "";
            fileLineCsv.TaxRegimeCode = "";
            fileLineCsv.Tax = "";
            fileLineCsv.TaxStatusCode = "";
            fileLineCsv.TaxJurisdictionCode = "";
            fileLineCsv.TaxRateCode = "";
            fileLineCsv.TaxRate = "";
            fileLineCsv.WithholdingTaxGroup = "";
            fileLineCsv.IncomeTaxType = "";
            fileLineCsv.IncomeTaxRegion = "";
            fileLineCsv.ProrateAcrossAllItemLines = "";
            fileLineCsv.LineGroupNumber = "";
            fileLineCsv.CostFactorName = "";
            fileLineCsv.StatisticalQuantity = "";
            fileLineCsv.TrackasAsset = "";
            fileLineCsv.AssetBookTypeCode = "";
            fileLineCsv.AssetCategoryID = "";
            fileLineCsv.SerialNumber = "";
            fileLineCsv.Manufacturer = "";
            fileLineCsv.ModelNumber = "";
            fileLineCsv.WarrantyNumber = "";
            fileLineCsv.PriceCorrectionLine = "";
            fileLineCsv.PriceCorrectionInvoiceNumber = "";
            fileLineCsv.PriceCorrectionInvoiceLineNumber = "";
            fileLineCsv.AttributeCategory = "";
            fileLineCsv.Attribute1 = "";
            fileLineCsv.Attribute2 = "";
            fileLineCsv.Attribute3 = "";
            fileLineCsv.Attribute4 = "";
            fileLineCsv.Attribute5 = "";
            fileLineCsv.Attribute6 = "";
            fileLineCsv.Attribute7 = "";
            fileLineCsv.Attribute8 = "";
            fileLineCsv.Attribute9 = "";
            fileLineCsv.Attribute10 = "";
            fileLineCsv.Attribute11 = "";
            fileLineCsv.Attribute12 = "";
            fileLineCsv.Attribute13 = "";
            fileLineCsv.Attribute14 = "";
            fileLineCsv.Attribute15 = "";
            fileLineCsv.AttributeNumber1 = "";
            fileLineCsv.AttributeNumber2 = "";
            fileLineCsv.AttributeNumber3 = "";
            fileLineCsv.AttributeNumber4 = "";
            fileLineCsv.AttributeNumber5 = "";
            fileLineCsv.AttributeDate1 = "";
            fileLineCsv.AttributeDate2 = "";
            fileLineCsv.AttributeDate3 = "";
            fileLineCsv.AttributeDate4 = "";
            fileLineCsv.AttributeDate5 = "";
            fileLineCsv.GlobalAttributeCategory = "";
            fileLineCsv.GlobalAttribute1 = "";
            fileLineCsv.GlobalAttribute2 = "";
            fileLineCsv.GlobalAttribute3 = "";
            fileLineCsv.GlobalAttribute4 = "";
            fileLineCsv.GlobalAttribute5 = "";
            fileLineCsv.GlobalAttribute6 = "";
            fileLineCsv.GlobalAttribute7 = "";
            fileLineCsv.GlobalAttribute8 = "";
            fileLineCsv.GlobalAttribute9 = "";
            fileLineCsv.GlobalAttribute10 = "";
            fileLineCsv.GlobalAttribute11 = "";
            fileLineCsv.GlobalAttribute12 = "";
            fileLineCsv.GlobalAttribute13 = "";
            fileLineCsv.GlobalAttribute14 = "";
            fileLineCsv.GlobalAttribute15 = "";
            fileLineCsv.GlobalAttribute16 = "";
            fileLineCsv.GlobalAttribute17 = "";
            fileLineCsv.GlobalAttribute18 = "";
            fileLineCsv.GlobalAttribute19 = "";
            fileLineCsv.GlobalAttribute20 = "";
            fileLineCsv.GlobalAttributeNumber1 = "";
            fileLineCsv.GlobalAttributeNumber2 = "";
            fileLineCsv.GlobalAttributeNumber3 = "";
            fileLineCsv.GlobalAttributeNumber4 = "";
            fileLineCsv.GlobalAttributeNumber5 = "";
            fileLineCsv.GlobalAttributeDate1 = "";
            fileLineCsv.GlobalAttributeDate2 = "";
            fileLineCsv.GlobalAttributeDate3 = "";
            fileLineCsv.GlobalAttributeDate4 = "";
            fileLineCsv.GlobalAttributeDate5 = "";
            fileLineCsv.ExpenditureItemDate = "";
            fileLineCsv.ProjectNumber = "";
            fileLineCsv.TaskNumber = "";
            fileLineCsv.ExpenditureType = "";
            fileLineCsv.ExpenditureOrganization = "";
            fileLineCsv.FiscalChargeType = "";
            fileLineCsv.ProjectName = "";
            fileLineCsv.TaskName = "";


            return fileLineCsv.ToString();
        }
    }
}

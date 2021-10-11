using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleINT096
{
    public class FileAccountReceivable : FileAccountFactory
    {
        public static AppSettings appsetting;
        public override string Parser(BaseAracFile baseAracFile)
        {
            #region Colunas do arquivo cs

            string company = string.Empty;

            DateTime dataFechamentoContabilidade = DateTime.ParseExact(baseAracFile.FECHA_CONTABILIZACION.Trim(), "YYYYMMdd", CultureInfo.InvariantCulture);

            FileCsv fileCsv = new FileCsv();

            fileCsv.BusinessUnitIdentifier = appsetting.FileAccountReceivableSettings.BusinessUnitIdentifier;
            fileCsv.BusinessUnitName = ""; //Parâmetro Front -campo empresa linha 7
            fileCsv.TransactionBatchSourceName = appsetting.FileAccountReceivableSettings.TransactionBatchSourceName; // verifcar linha 8 
            fileCsv.TransactionTypeName = "";
            fileCsv.PaymentTerms = $" {baseAracFile.FECHA_VENCIMIENTO} - {baseAracFile.FECHA_CONTABILIZACION} DD"; //linha 10
            fileCsv.TransactionDate = dataFechamentoContabilidade.ToString("dd/MM/yyyy"); //linha 11
            fileCsv.AccountingDate = dataFechamentoContabilidade.ToString("dd/MM/yyyy"); //linha 12
            fileCsv.TransactionNumber = baseAracFile.NUMERO_DE_DOCUMENTO; //linha 13
            fileCsv.OriginalSystemBilltoCustomerReference = appsetting.FileAccountReceivableSettings.OriginalSystemBilltoCustomerReference;
            fileCsv.OriginalSystemBilltoCustomerAddressReference = appsetting.FileAccountReceivableSettings.OriginalSystemBilltoCustomerAddressReference;
            fileCsv.OriginalSystemBilltoCustomerContactReference = appsetting.FileAccountReceivableSettings.OriginalSystemBilltoCustomerContactReference;
            fileCsv.OriginalSystemShiptoCustomerReference = appsetting.FileAccountReceivableSettings.OriginalSystemShiptoCustomerReference;
            fileCsv.OriginalSystemShiptoCustomerAddressReference = appsetting.FileAccountReceivableSettings.OriginalSystemShiptoCustomerAddressReference;
            fileCsv.OriginalSystemShiptoCustomerContactReference = appsetting.FileAccountReceivableSettings.OriginalSystemShiptoCustomerContactReference;
            fileCsv.OriginalSystemShiptoCustomerAccountReference = appsetting.FileAccountReceivableSettings.OriginalSystemShiptoCustomerAccountReference;
            fileCsv.OriginalSystemShiptoCustomerAccountAddressReference = appsetting.FileAccountReceivableSettings.OriginalSystemShiptoCustomerAccountAddressReference;
            fileCsv.OriginalSystemShiptoCustomerAccountContactReference = appsetting.FileAccountReceivableSettings.OriginalSystemShiptoCustomerAccountContactReference;
            fileCsv.OriginalSystemSoldtoCustomerReference = appsetting.FileAccountReceivableSettings.OriginalSystemSoldtoCustomerReference; 
            fileCsv.OriginalSystemSoldtoCustomerAccountReference = appsetting.FileAccountReceivableSettings.OriginalSystemSoldtoCustomerAccountReference;

            #region Receivables.GetRegisterCustomer

            fileCsv.DocumentSubType = "ORA_BR_IATA";
            fileCsv.DocumentNumber = baseAracFile.CLIENTE_PROVEEDOR;

            fileCsv.BilltoCustomerAccountNumber = "";
            fileCsv.BilltoCustomerSiteNumber = "";
            fileCsv.ShiptoCustomerAccountNumber = "";
            fileCsv.ShiptoCustomerSiteNumber = "";
            fileCsv.SoldtoCustomerAccountNumber = "";

            fileCsv.ReceiptMethodName = ""; //Linha 168

            #endregion


            fileCsv.TransactionLineType = appsetting.FileAccountReceivableSettings.TransactionLineType;

            if (baseAracFile.CUENTA_CONTABLE == "51401001" && company == "OU_AZUL_LINHAS_AEREAS")
            {
                fileCsv.TransactionLineDescription = "51401001-ARACS-01";
            }
            else if(baseAracFile.CUENTA_CONTABLE == "51401001" && company == "OU_AZUL_VIAGENS")
            {
                fileCsv.TransactionLineDescription = "51401001-ARACS-54";
            }
            else if(baseAracFile.CUENTA_CONTABLE == "51401003")
            {
                fileCsv.TransactionLineDescription = "51401003-ARACS";
            }
            else
            {
                fileCsv.TransactionLineDescription = baseAracFile.CUENTA_CONTABLE;
            }

            fileCsv.CurrencyCode = baseAracFile.MONEDA;

            fileCsv.BilltoContactPartyNumber = "";
            fileCsv.ShiptoContactPartyNumber = "";

            fileCsv.CurrencyConversionType = appsetting.FileAccountReceivableSettings.CurrencyConversionType;
            fileCsv.CurrencyConversionRate = appsetting.FileAccountReceivableSettings.CurrencyConversionRate;


            fileCsv.CurrencyConversionDate = appsetting.FileAccountReceivableSettings.CurrencyConversionDate;

            #region função

            double transactionAmount = 0;
            if (baseAracFile.INDICADOR_DC == "C") // Invertido?
            {
                transactionAmount = Double.Parse(baseAracFile.IMPORTE)/100;  //verificar
            }
            else
            {
                transactionAmount = (Double.Parse(baseAracFile.IMPORTE) / 100)*-1; //verificar
            }

            fileCsv.TransactionLineAmount = transactionAmount.ToString();
            fileCsv.UnitSellingPrice = transactionAmount.ToString();
            fileCsv.UnitStandardPrice = transactionAmount.ToString();
            #endregion


            fileCsv.TransactionLineQuantity = appsetting.FileAccountReceivableSettings.TransactionLineQuantity;
            fileCsv.CustomerOrderedQuantity = ""; //Verificar Linha 40
            
            fileCsv.LineTransactionsFlexfieldContext = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldContext; //Verificar linha 43
            fileCsv.LineTransactionsFlexfieldSegment1 =  baseAracFile.NUMERO_DE_DOCUMENTO; //linha 44
            fileCsv.LineTransactionsFlexfieldSegment2 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment2;
            fileCsv.LineTransactionsFlexfieldSegment3 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment3;
            fileCsv.LineTransactionsFlexfieldSegment4 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment4;
            fileCsv.LineTransactionsFlexfieldSegment5 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment5;
            fileCsv.LineTransactionsFlexfieldSegment6 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment6;
            fileCsv.LineTransactionsFlexfieldSegment7 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment7;
            fileCsv.LineTransactionsFlexfieldSegment8 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment8;
            fileCsv.LineTransactionsFlexfieldSegment9 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment9; 
            fileCsv.LineTransactionsFlexfieldSegment10 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment10;
            fileCsv.LineTransactionsFlexfieldSegment11 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment11;
            fileCsv.LineTransactionsFlexfieldSegment12 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment12;
            fileCsv.LineTransactionsFlexfieldSegment13 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment13;
            fileCsv.LineTransactionsFlexfieldSegment14 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment14;
            fileCsv.LineTransactionsFlexfieldSegment15 = appsetting.FileAccountReceivableSettings.LineTransactionsFlexfieldSegment15;
            fileCsv.PrimarySalespersonNumber = appsetting.FileAccountReceivableSettings.PrimarySalespersonNumber;
            fileCsv.TaxClassificationCode = appsetting.FileAccountReceivableSettings.TaxClassificationCode;
            fileCsv.LegalEntityIdentifier = appsetting.FileAccountReceivableSettings.LegalEntityIdentifier;
            fileCsv.AccountedAmountinLedgerCurrency = appsetting.FileAccountReceivableSettings.AccountedAmountinLedgerCurrency;
            fileCsv.SalesOrderNumber = appsetting.FileAccountReceivableSettings.SalesOrderNumber;
            fileCsv.SalesOrderDate = appsetting.FileAccountReceivableSettings.SalesOrderDate;

            fileCsv.ActualShipDate = baseAracFile.FECHA_CONTABILIZACION; //linha 65

            fileCsv.WarehouseCode = appsetting.FileAccountReceivableSettings.WarehouseCode;
            fileCsv.UnitofMeasureCode = appsetting.FileAccountReceivableSettings.UnitofMeasureCode;
            fileCsv.UnitofMeasureName = appsetting.FileAccountReceivableSettings.UnitofMeasureName;
            fileCsv.InvoicingRuleName = appsetting.FileAccountReceivableSettings.InvoicingRuleName;
            fileCsv.RevenueSchedulingRuleName = appsetting.FileAccountReceivableSettings.RevenueSchedulingRuleName;
            fileCsv.NumberofRevenuePeriods = appsetting.FileAccountReceivableSettings.NumberofRevenuePeriods;
            fileCsv.RevenueSchedulingRuleStartDate = appsetting.FileAccountReceivableSettings.RevenueSchedulingRuleStartDate;
            fileCsv.RevenueSchedulingRuleEndDate = appsetting.FileAccountReceivableSettings.RevenueSchedulingRuleEndDate; 
            fileCsv.ReasonCodeMeaning = appsetting.FileAccountReceivableSettings.ReasonCodeMeaning;
            fileCsv.LastPeriodtoCredit = appsetting.FileAccountReceivableSettings.LastPeriodtoCredit;
            fileCsv.TransactionBusinessCategoryCode = appsetting.FileAccountReceivableSettings.TransactionBusinessCategoryCode;
            fileCsv.ProductFiscalClassificationCode = appsetting.FileAccountReceivableSettings.ProductFiscalClassificationCode;
            fileCsv.ProductCategoryCode = appsetting.FileAccountReceivableSettings.ProductCategoryCode;
            fileCsv.ProductType = appsetting.FileAccountReceivableSettings.ProductType;
            fileCsv.LineIntendedUseCode = appsetting.FileAccountReceivableSettings.LineIntendedUseCode;
            fileCsv.AssessableValue = appsetting.FileAccountReceivableSettings.AssessableValue;

            fileCsv.DefaultTaxationCountry = appsetting.FileAccountReceivableSettings.DefaultTaxationCountry;
            fileCsv.UserDefinedFiscalClassification = appsetting.FileAccountReceivableSettings.UserDefinedFiscalClassification;
            fileCsv.TaxInvoiceNumber = appsetting.FileAccountReceivableSettings.TaxInvoiceNumber;
            fileCsv.TaxInvoiceDate = appsetting.FileAccountReceivableSettings.TaxInvoiceDate; 
            fileCsv.TaxRegimeCode = appsetting.FileAccountReceivableSettings.TaxRegimeCode;
            fileCsv.Tax = appsetting.FileAccountReceivableSettings.Tax;
            fileCsv.TaxStatusCode = appsetting.FileAccountReceivableSettings.TaxStatusCode;
            fileCsv.TaxRateCode = appsetting.FileAccountReceivableSettings.TaxRateCode;
            fileCsv.TaxJurisdictionCode = appsetting.FileAccountReceivableSettings.TaxJurisdictionCode;
            fileCsv.FirstPartyRegistrationNumber = appsetting.FileAccountReceivableSettings.FirstPartyRegistrationNumber;
            fileCsv.ThirdPartyRegistrationNumber = appsetting.FileAccountReceivableSettings.ThirdPartyRegistrationNumber;
            fileCsv.FinalDischargeLocation = appsetting.FileAccountReceivableSettings.FinalDischargeLocation;
            fileCsv.TaxableAmount = appsetting.FileAccountReceivableSettings.TaxableAmount;
            fileCsv.TaxableFlag = appsetting.FileAccountReceivableSettings.TaxableFlag;
            fileCsv.TaxExemptionFlag = appsetting.FileAccountReceivableSettings.TaxExemptionFlag; // linha 97
            fileCsv.TaxExemptionReasonCode = appsetting.FileAccountReceivableSettings.TaxExemptionReasonCode;
            fileCsv.TaxExemptionReasonCodeMeaning = appsetting.FileAccountReceivableSettings.TaxExemptionReasonCodeMeaning;
            fileCsv.TaxExemptionCertificateNumber = appsetting.FileAccountReceivableSettings.TaxExemptionCertificateNumber; 
            fileCsv.LineAmountIncludesTaxFlag = appsetting.FileAccountReceivableSettings.LineAmountIncludesTaxFlag;
            fileCsv.TaxPrecedence = appsetting.FileAccountReceivableSettings.TaxPrecedence;
            fileCsv.CreditMethodToBeUsedForLinesWithRevenueSchedulingRules = appsetting.FileAccountReceivableSettings.CreditMethodToBeUsedForLinesWithRevenueSchedulingRules;
            fileCsv.CreditMethodToBeUsedForTransactionsWithSplitPaymentTerms = appsetting.FileAccountReceivableSettings.CreditMethodToBeUsedForTransactionsWithSplitPaymentTerms;
            fileCsv.ReasonCode = appsetting.FileAccountReceivableSettings.ReasonCode;
            fileCsv.TaxRate = appsetting.FileAccountReceivableSettings.TaxRate;
            fileCsv.FOBPoint = appsetting.FileAccountReceivableSettings.FobPoint;
            fileCsv.Carrier = appsetting.FileAccountReceivableSettings.Carrier;
            fileCsv.ShippingReference = appsetting.FileAccountReceivableSettings.ShippingReference;
            fileCsv.SalesOrderLineNumber = appsetting.FileAccountReceivableSettings.SalesOrderLineNumber;
            fileCsv.SalesOrderSource = appsetting.FileAccountReceivableSettings.SalesOrderSource;
            fileCsv.SalesOrderRevisionNumber = appsetting.FileAccountReceivableSettings.SalesOrderRevisionNumber;
            fileCsv.PurchaseOrderNumber = appsetting.FileAccountReceivableSettings.PurchaseOrderNumber;
            fileCsv.PurchaseOrderRevisionNumber = appsetting.FileAccountReceivableSettings.PurchaseOrderRevisionNumber;
            fileCsv.PurchaseOrderDate = appsetting.FileAccountReceivableSettings.PurchaseOrderDate;
            fileCsv.AgreementName = appsetting.FileAccountReceivableSettings.AgreementName;

            #region Linha 117

            fileCsv.MemoLineName = "";

            if (baseAracFile.CUENTA_CONTABLE == "51401001" && company == "OU_AZUL_LINHAS_AEREAS")
            {
                fileCsv.TransactionLineDescription = "51401001-ARACS-01";
            }
            else if (baseAracFile.CUENTA_CONTABLE == "51401001" && company == "OU_AZUL_VIAGENS")
            {
                fileCsv.TransactionLineDescription = "51401001-ARACS-54";
            }
            else if (baseAracFile.CUENTA_CONTABLE == "51401003")
            {
                fileCsv.TransactionLineDescription = "51401003-ARACS";
            }
            else
            {
                fileCsv.TransactionLineDescription = baseAracFile.CUENTA_CONTABLE;
            }

            #endregion





            fileCsv.OriginalSystemBatchName = appsetting.FileAccountReceivableSettings.OriginalSystemBatchName;
            fileCsv.LinktoTransactionsFlexfieldContext = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldContext;
            fileCsv.LinktoTransactionsFlexfieldSegment1 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment1;
            fileCsv.LinktoTransactionsFlexfieldSegment2 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment2;
            fileCsv.LinktoTransactionsFlexfieldSegment3 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment3;
            fileCsv.LinktoTransactionsFlexfieldSegment4 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment4;
            fileCsv.LinktoTransactionsFlexfieldSegment5 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment5;
            fileCsv.LinktoTransactionsFlexfieldSegment6 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment6;
            fileCsv.LinktoTransactionsFlexfieldSegment7 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment7;
            fileCsv.LinktoTransactionsFlexfieldSegment8 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment8;
            fileCsv.LinktoTransactionsFlexfieldSegment9 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment9;
            fileCsv.LinktoTransactionsFlexfieldSegment10 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment10;
            fileCsv.LinktoTransactionsFlexfieldSegment11 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment11;
            fileCsv.LinktoTransactionsFlexfieldSegment12 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment12;
            fileCsv.LinktoTransactionsFlexfieldSegment13 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment13;
            fileCsv.LinktoTransactionsFlexfieldSegment14 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment14;
            fileCsv.LinktoTransactionsFlexfieldSegment15 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment15;
            fileCsv.ReferenceTransactionsFlexfieldContext = appsetting.FileAccountReceivableSettings.ReferenceTransactionsFlexfieldContext;
            fileCsv.ReferenceTransactionsFlexfieldSegment1 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment1;
            fileCsv.ReferenceTransactionsFlexfieldSegment2 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment2;
            fileCsv.ReferenceTransactionsFlexfieldSegment3 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment3;
            fileCsv.ReferenceTransactionsFlexfieldSegment4 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment4;
            fileCsv.ReferenceTransactionsFlexfieldSegment5 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment5;
            fileCsv.ReferenceTransactionsFlexfieldSegment6 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment6;
            fileCsv.ReferenceTransactionsFlexfieldSegment7 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment7;
            fileCsv.ReferenceTransactionsFlexfieldSegment8 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment8;
            fileCsv.ReferenceTransactionsFlexfieldSegment9 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment9;
            fileCsv.ReferenceTransactionsFlexfieldSegment10 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment10;
            fileCsv.ReferenceTransactionsFlexfieldSegment11 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment11;
            fileCsv.ReferenceTransactionsFlexfieldSegment12 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment12;
            fileCsv.ReferenceTransactionsFlexfieldSegment13 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment13;
            fileCsv.ReferenceTransactionsFlexfieldSegment14 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment14;
            fileCsv.ReferenceTransactionsFlexfieldSegment15 = appsetting.FileAccountReceivableSettings.LinktoTransactionsFlexfieldSegment15;
            fileCsv.LinkToParentLineContext = appsetting.FileAccountReceivableSettings.LinkToParentLineContext;
            fileCsv.LinkToParentLineSegment1 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment1;
            fileCsv.LinkToParentLineSegment2 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment2;
            fileCsv.LinkToParentLineSegment3 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment3;
            fileCsv.LinkToParentLineSegment4 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment4;
            fileCsv.LinkToParentLineSegment5 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment5;
            fileCsv.LinkToParentLineSegment6 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment6;
            fileCsv.LinkToParentLineSegment7 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment7;
            fileCsv.LinkToParentLineSegment8 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment8;
            fileCsv.LinkToParentLineSegment9 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment9;
            fileCsv.LinkToParentLineSegment10 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment10;
            fileCsv.LinkToParentLineSegment11 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment11;
            fileCsv.LinkToParentLineSegment12 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment12;
            fileCsv.LinkToParentLineSegment13 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment13;
            fileCsv.LinkToParentLineSegment14 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment14;
            fileCsv.LinkToParentLineSegment15 = appsetting.FileAccountReceivableSettings.LinkToParentLineSegment15;

            fileCsv.PrintingOption = appsetting.FileAccountReceivableSettings.PrintingOption;
            fileCsv.RelatedBatchSourceName = appsetting.FileAccountReceivableSettings.RelatedBatchSourceName;
            fileCsv.RelatedTransactionNumber = appsetting.FileAccountReceivableSettings.RelatedTransactionNumber;
            fileCsv.InventoryItemNumber = appsetting.FileAccountReceivableSettings.InventoryItemNumber;
            fileCsv.InventoryItemSegment2 = appsetting.FileAccountReceivableSettings.InventoryItemSegment2;
            fileCsv.InventoryItemSegment3 = appsetting.FileAccountReceivableSettings.InventoryItemSegment3;
            fileCsv.InventoryItemSegment4 = appsetting.FileAccountReceivableSettings.InventoryItemSegment4;
            fileCsv.InventoryItemSegment5 = appsetting.FileAccountReceivableSettings.InventoryItemSegment5;
            fileCsv.InventoryItemSegment6 = appsetting.FileAccountReceivableSettings.InventoryItemSegment6;
            fileCsv.InventoryItemSegment7 = appsetting.FileAccountReceivableSettings.InventoryItemSegment7;
            fileCsv.InventoryItemSegment8 = appsetting.FileAccountReceivableSettings.InventoryItemSegment8;
            fileCsv.InventoryItemSegment9 = appsetting.FileAccountReceivableSettings.InventoryItemSegment9;
            fileCsv.InventoryItemSegment10 = appsetting.FileAccountReceivableSettings.InventoryItemSegment10;
            fileCsv.InventoryItemSegment11 = appsetting.FileAccountReceivableSettings.InventoryItemSegment11;
            fileCsv.InventoryItemSegment12 = appsetting.FileAccountReceivableSettings.InventoryItemSegment12;
            fileCsv.InventoryItemSegment13 = appsetting.FileAccountReceivableSettings.InventoryItemSegment13;
            fileCsv.InventoryItemSegment14 = appsetting.FileAccountReceivableSettings.InventoryItemSegment14;
            fileCsv.InventoryItemSegment15 = appsetting.FileAccountReceivableSettings.InventoryItemSegment15;
            fileCsv.InventoryItemSegment16 = appsetting.FileAccountReceivableSettings.InventoryItemSegment16;
            fileCsv.InventoryItemSegment17 = appsetting.FileAccountReceivableSettings.InventoryItemSegment17;
            fileCsv.InventoryItemSegment18 = appsetting.FileAccountReceivableSettings.InventoryItemSegment18;
            fileCsv.InventoryItemSegment19 = appsetting.FileAccountReceivableSettings.InventoryItemSegment19;
            fileCsv.InventoryItemSegment20 = appsetting.FileAccountReceivableSettings.InventoryItemSegment20;
            fileCsv.BillToCustomerBankAccountName = appsetting.FileAccountReceivableSettings.BillToCustomerBankAccountName;
            fileCsv.ResetTransactionDateFlag = appsetting.FileAccountReceivableSettings.ResetTransactionDateFlag; 
            fileCsv.PaymentServerOrderNumber = appsetting.FileAccountReceivableSettings.PaymentServerOrderNumber;
            fileCsv.LastTransactiononDebitAuthorization = appsetting.FileAccountReceivableSettings.LastTransactiononDebitAuthorization;
            fileCsv.ApprovalCode = appsetting.FileAccountReceivableSettings.ApprovalCode;
            fileCsv.AddressVerificationCode = appsetting.FileAccountReceivableSettings.AddressVerificationCode;
            fileCsv.TransactionLineTranslatedDescription = appsetting.FileAccountReceivableSettings.TransactionLineTranslatedDescription;
            fileCsv.ConsolidatedBillingNumber = appsetting.FileAccountReceivableSettings.ConsolidatedBillingNumber;
            fileCsv.PromisedCommitmentAmount = appsetting.FileAccountReceivableSettings.PromisedCommitmentAmount;
            fileCsv.PaymentSetIdentifier = appsetting.FileAccountReceivableSettings.PaymentSetIdentifier;
            fileCsv.OriginalAccountingDate = appsetting.FileAccountReceivableSettings.OriginalAccountingDate;
            fileCsv.InvoicedLineAccountingLevel = appsetting.FileAccountReceivableSettings.InvoicedLineAccountingLevel;
            fileCsv.OverrideAutoAccountingFlag = appsetting.FileAccountReceivableSettings.OverrideAutoAccountingFlag;
            fileCsv.HistoricalFlag = appsetting.FileAccountReceivableSettings.OverrideAutoAccountingFlag;
            fileCsv.DeferralExclusionFlag = appsetting.FileAccountReceivableSettings.DeferralExclusionFlag;
            fileCsv.PaymentAttributes = appsetting.FileAccountReceivableSettings.PaymentAttributes;
            fileCsv.InvoiceBillingDate = appsetting.FileAccountReceivableSettings.InvoiceBillingDate;


            fileCsv.InvoiceLinesFlexfieldContext = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldContext; 
            fileCsv.InvoiceLinesFlexfieldSegment1 = baseAracFile.NUMERO_DE_DOCUMENTO; //210
            fileCsv.InvoiceLinesFlexfieldSegment2 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment2; 
            fileCsv.InvoiceLinesFlexfieldSegment3 = dataFechamentoContabilidade.ToString("yyyy-MM-dd"); //Linha 2012
            fileCsv.InvoiceLinesFlexfieldSegment4 =  //Verificar Linha 213
            fileCsv.InvoiceLinesFlexfieldSegment5 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment5;
            fileCsv.InvoiceLinesFlexfieldSegment6 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment6;
            fileCsv.InvoiceLinesFlexfieldSegment7 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment7;
            fileCsv.InvoiceLinesFlexfieldSegment8 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment8;
            fileCsv.InvoiceLinesFlexfieldSegment9 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment9;
            fileCsv.InvoiceLinesFlexfieldSegment10 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment10;
            fileCsv.InvoiceLinesFlexfieldSegment11 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment11;
            fileCsv.InvoiceLinesFlexfieldSegment12 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment12;
            fileCsv.InvoiceLinesFlexfieldSegment13 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment13;
            fileCsv.InvoiceLinesFlexfieldSegment14 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment14;
            fileCsv.InvoiceLinesFlexfieldSegment15 = appsetting.FileAccountReceivableSettings.InvoiceLinesFlexfieldSegment15;

            fileCsv.InvoiceTransactionsFlexfieldContext = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldContext;  
            fileCsv.InvoiceTransactionsFlexfieldSegment1 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment1;
            fileCsv.InvoiceTransactionsFlexfieldSegment2 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment2;
            fileCsv.InvoiceTransactionsFlexfieldSegment3 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment3;
            fileCsv.InvoiceTransactionsFlexfieldSegment4 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment4;
            fileCsv.InvoiceTransactionsFlexfieldSegment5 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment5;
            fileCsv.InvoiceTransactionsFlexfieldSegment6 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment6;
            fileCsv.InvoiceTransactionsFlexfieldSegment7 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment7;
            fileCsv.InvoiceTransactionsFlexfieldSegment8 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment8;
            fileCsv.InvoiceTransactionsFlexfieldSegment9 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment9;
            fileCsv.InvoiceTransactionsFlexfieldSegment10 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment10;
            fileCsv.InvoiceTransactionsFlexfieldSegment11 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment11;
            fileCsv.InvoiceTransactionsFlexfieldSegment12 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment12;
            fileCsv.InvoiceTransactionsFlexfieldSegment13 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment13;
            fileCsv.InvoiceTransactionsFlexfieldSegment14 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment14;
            fileCsv.InvoiceTransactionsFlexfieldSegment15 = appsetting.FileAccountReceivableSettings.InvoiceTransactionsFlexfieldSegment15;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldContext = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldContext;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment1 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment1; 
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment2 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment2;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment3 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment3;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment4 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment4;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment5 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment5;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment6 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment6;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment7 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment7;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment8 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment8;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment9 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment9;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment10 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment10;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment11 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment11;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment12 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment12;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment13 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment13;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment14 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment14;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment15 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment15;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment16 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment16;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment17 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment17;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment18 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment18;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment19 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment19;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment20 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment20;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment21 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment21;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment22 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment22;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment23 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment23;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment24 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment24;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment25 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment25;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment26 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment26;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment27 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment27;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment28 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment28;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment29 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment29;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldSegment30 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldSegment30;
            fileCsv.LineGlobalDescriptiveFlexfieldAttributeCategory = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldAttributeCategory;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment1 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment1;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment2 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment2;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment3 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment3;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment4 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment4;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment5 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment5;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment6 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment6;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment7 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment7;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment8 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment8;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment9 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment9;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment10 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment10;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment11 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment11;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment12 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment12;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment13 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment13;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment14 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment14;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment15 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment15;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment16 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment16;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment17 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment17;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment18 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment18;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment19 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment19;
            fileCsv.LineGlobalDescriptiveFlexfieldSegment20 = appsetting.FileAccountReceivableSettings.LineGlobalDescriptiveFlexfieldSegment20;
            fileCsv.Comments = appsetting.FileAccountReceivableSettings.Comments;
            fileCsv.NotesfromSource = appsetting.FileAccountReceivableSettings.NotesfromSource;
            fileCsv.CreditCardTokenNumber = appsetting.FileAccountReceivableSettings.CreditCardTokenNumber;
            fileCsv.CreditCardExpirationDate = appsetting.FileAccountReceivableSettings.CreditCardExpirationDate;
            fileCsv.FirstNameoftheCreditCardHolder = appsetting.FileAccountReceivableSettings.FirstNameoftheCreditCardHolder;
            fileCsv.LastNameoftheCreditCardHolder = appsetting.FileAccountReceivableSettings.LastNameoftheCreditCardHolder;
            fileCsv.CreditCardIssuerCode = appsetting.FileAccountReceivableSettings.CreditCardIssuerCode;
            fileCsv.MaskedCreditCardNumber = appsetting.FileAccountReceivableSettings.MaskedCreditCardNumber;
            fileCsv.CreditCardAuthorizationRequestIdentifier = appsetting.FileAccountReceivableSettings.CreditCardAuthorizationRequestIdentifier;
            fileCsv.CreditCardVoiceAuthorizationCode = appsetting.FileAccountReceivableSettings.CreditCardVoiceAuthorizationCode;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment1 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment1;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment2 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment2;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment3 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment3;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment4 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment4;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment5 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment5;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment6 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment6;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment7 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment7;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment8 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment8;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment9 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment9;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment10 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment10;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment11 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment11;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldNumberSegment12 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldNumberSegment12;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldDateSegment1 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldDateSegment1;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldDateSegment2 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldDateSegment2;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldDateSegment3 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldDateSegment3;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldDateSegment4 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldDateSegment4;
            fileCsv.ReceivablesTransactionRegionInformationFlexfieldDateSegment5 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionRegionInformationFlexfieldDateSegment5;
            fileCsv.ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment1 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment1;
            fileCsv.ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment2 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment2;
            fileCsv.ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment3 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment3;
            fileCsv.ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment4 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment4;
            fileCsv.ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment5 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionLineRegionInformationFlexfieldNumberSegment5;
            fileCsv.ReceivablesTransactionLineRegionInformationFlexfieldDateSegment1 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionLineRegionInformationFlexfieldDateSegment1;
            fileCsv.ReceivablesTransactionLineRegionInformationFlexfieldDateSegment2 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionLineRegionInformationFlexfieldDateSegment2;
            fileCsv.ReceivablesTransactionLineRegionInformationFlexfieldDateSegment3 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionLineRegionInformationFlexfieldDateSegment3;
            fileCsv.ReceivablesTransactionLineRegionInformationFlexfieldDateSegment4 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionLineRegionInformationFlexfieldDateSegment4;
            fileCsv.ReceivablesTransactionLineRegionInformationFlexfieldDateSegment5 = appsetting.FileAccountReceivableSettings.ReceivablesTransactionLineRegionInformationFlexfieldDateSegment5;
            fileCsv.FreightCharge = appsetting.FileAccountReceivableSettings.FreightCharge;
            fileCsv.InsuranceCharge = appsetting.FileAccountReceivableSettings.InsuranceCharge;
            fileCsv.PackingCharge = appsetting.FileAccountReceivableSettings.PackingCharge;
            fileCsv.MiscellaneousCharge = appsetting.FileAccountReceivableSettings.MiscellaneousCharge;
            fileCsv.CommercialDiscount = appsetting.FileAccountReceivableSettings.CommercialDiscount;
            fileCsv.EnforceChronologicalDocumentSequencing = appsetting.FileAccountReceivableSettings.EnforceChronologicalDocumentSequencing;

            #endregion

            return fileCsv.ToString();

        }
    }
}

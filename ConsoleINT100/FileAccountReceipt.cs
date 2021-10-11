using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleINT100
{
    public class FileAccountReceipt : FileAccountFactory
    {
        public override BaseAracFile Parser(FileSource fileSource)
        {
            #region Colunas do arquivo cs

            BaseAracFile baseAracFile = new BaseAracFile();

            baseAracFile.ReceiptType = "MISC";
            string CardType = string.Empty;


            switch(fileSource.NOME_FORNECEDOR.Trim())
            {
                case "AMERICAN EXPRESS":
                      CardType = "A";
                    break;
                case "ELO CIELO DEBITO":
                      CardType = "C";
                    break;
                case "CIELO VISA":
                      CardType = "C";
                    break;
                case "VISA CIELO":
                      CardType = "C";
                    break;
                case "REDESHOP CIELO":
                      CardType = "C";
                    break;
                case "ELO CIELO CREDITO":
                      CardType = "C";
                    break;
                case "CIELO MASTERCARD":
                      CardType = "C";
                    break;
                case "VISA ELECTRON CIELO":
                      CardType = "C";
                    break;
                case "CIELO VISA ELECTRON":
                      CardType = "C";
                    break;
                case "CIELO REDESHOP":
                      CardType = "C";
                    break;
                case "DINERS CIELO":
                      CardType = "C";
                    break;
                case "BANESCARD CIELO":
                      CardType = "C";
                    break;
                case "MASTERCARD GETNET":
                      CardType = "G";
                    break;
                case "MAESTRO GETNET":
                      CardType = "G";
                    break;
                case "VISA GETNET":
                      CardType = "G";
                    break;
                case "VISA ELECTRON GETNET":
                      CardType = "G";
                    break;
                case "HIPERCARD":
                      CardType = "H";
                    break;
                case "REDESHOP REDECARD":
                      CardType = "R";
                    break;
                case "MASTERCARD REDECARD":
                      CardType = "R";
                    break;
                case "REDECARD DEBITO":
                      CardType = "R";
                    break;
                case "REDECARD CREDITO":
                      CardType = "R";
                    break;
                case "VISA REDECARD":
                      CardType = "R";
                    break;
                case "DINNERS REDECARD":
                      CardType = "R";
                    break;
                case "ELECTRON REDECARD":
                      CardType = "R";
                    break;
                default:
                      CardType = "X";
                    break;
            }

            DateTime dataFechamentoContabilidade = DateTime.ParseExact(fileSource.FECHA_CONTABILIZACION.Trim(), "yyyyMMdd", CultureInfo.InvariantCulture);
            
            baseAracFile.ReceiptNumber = $"{CardType}_{fileSource.CLIENTE_PROVEEDOR.Trim()}_{fileSource.NUMERO_ARACS.Trim()}_{fileSource.AERONAVE.Trim()}_{fileSource.CUENTA_CONTABLE.Trim()}";
            baseAracFile.BusinessUnit =  string.Empty; //Parâmetro do Frontend - campo Empresa 
            baseAracFile.ReceiptMethod = string.Empty; //Campo METODO_REC do parâmetro onde EMPRESA = Parâmetro do Frontend - campo Empresa e CONTA_CORRENTE = REG_ARACS_AR.CONTA_CORRENTE
            baseAracFile.ReceiptDate = dataFechamentoContabilidade.ToString("YYYY-MM-DD");
            baseAracFile.Amount = fileSource.IMPORTE.Trim();
            baseAracFile.Currency = fileSource.MONEDA.Trim();
            baseAracFile.CustomerName = string.Empty;
            baseAracFile.CustomerSite = string.Empty;
            baseAracFile.CustomerAccountNumber = string.Empty;
            baseAracFile.AccountingDate = dataFechamentoContabilidade.ToString("YYYY-MM-DD");
            baseAracFile.RemittanceBankAccountNumber = string.Empty;
            baseAracFile.Comments = $"CODIGO ARACS: {fileSource.CODIGO_ARACS.Trim()}  NUMERO ARACS: {fileSource.NUMERO_ARACS.Trim()} DATA GL: {fileSource.FECHA_CONTABILIZACION.Trim()} TIPO LANCTO: {fileSource.AERONAVE.Trim()} {fileSource.CENTRO_DE_COSTO.Trim()}";
            baseAracFile.OrgId = string.Empty;
            baseAracFile.ExchangeRateType = string.Empty;
            baseAracFile.ExchangeDate = string.Empty;
            baseAracFile.ExchangeRate = string.Empty;

            #endregion

            return baseAracFile;

        }
    }
}

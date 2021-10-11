using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleParserZip
{
    public class FileAccountSales : FileAccountFactory
    {
        public override string Parser(FileSource fileSource)
        {
            #region Colunas do arquivo cs

            BaseAracFile baseAracFile = new BaseAracFile();

            baseAracFile.StatusCode = "NEW";
            baseAracFile.LegendId = string.Empty; //Definir
            baseAracFile.EffectiveDateofTransaction = fileSource.FECHA_CONTABILIZACION;
            baseAracFile.JournalSource = "ARACS";
            baseAracFile.JournalCategory = "Cartao Credito";
            baseAracFile.CurrencyCode = fileSource.MONEDA;
            baseAracFile.JournalEntryCreationDate = $"{DateTime.Now.ToString("yyyy/MM/dd")}";
            baseAracFile.ActualFlag = "A";
            baseAracFile.Segment1 = string.Empty; //Definir
            baseAracFile.Segment4 = fileSource.CUENTA_CONTABLE;

            #region Condição para p Segmento 2 e 3 a partir do segmento 4
           
                string[] paramters = { "TCPR", "TCCR" };
               if(baseAracFile.Segment4.Substring(0, 1) == "1" || baseAracFile.Segment4.Substring(0, 1) == "2")
                {
                    baseAracFile.Segment2 = "000";
                    baseAracFile.Segment3 = "0000";
                }
               else if(baseAracFile.Segment4.Substring(0, 8) == "51401001" && fileSource.CENTRO_DE_COSTO.Substring(0, 3) == "AZV" &&
                    paramters.Contains(fileSource.CODIGO_ARACS.Substring(0, 4)))
                {
                    baseAracFile.Segment2 = "001";
                    baseAracFile.Segment3 = "1240";
                }
                else if (baseAracFile.Segment4.Substring(0, 1) == "4" || baseAracFile.Segment4.Substring(0, 1) == "5")
                {
                    baseAracFile.Segment2 = "001";
                    baseAracFile.Segment3 = "1151";
                }

            #endregion

            baseAracFile.Segment5 = "0";
            baseAracFile.Segment6 = "00";
            baseAracFile.Segment7 = "ARACS";
            baseAracFile.Segment8 = "00000";
            baseAracFile.Segment9 = "";
            baseAracFile.Segment10 = "";
            baseAracFile.Segment11 = "";
            baseAracFile.Segment12 = "";
            baseAracFile.Segment13 = "";
            baseAracFile.Segment14 = "";
            baseAracFile.Segment15 = "";
            baseAracFile.Segment16 = "";
            baseAracFile.Segment17 = "";
            baseAracFile.Segment18 = "";
            baseAracFile.Segment19 = "";
            baseAracFile.Segment20 = "";
            baseAracFile.Segment21 = "";
            baseAracFile.Segment22 = "";
            baseAracFile.Segment23 = "";
            baseAracFile.Segment24 = "";
            baseAracFile.Segment25 = "";
            baseAracFile.Segment26 = "";
            baseAracFile.Segment27 = "";
            baseAracFile.Segment28 = "";
            baseAracFile.Segment29 = "";
            baseAracFile.Segment30 = "";
            baseAracFile.EnteredDebitAmount = fileSource.INDICADOR_DC == "D" ? Convert.ToString((Convert.ToDouble(fileSource.IMPORTE) / 100)) : null;
            baseAracFile.EnteredCreditAmount = fileSource.INDICADOR_DC == "C" ? Convert.ToString((Convert.ToDouble(fileSource.IMPORTE) / 100)) : null;
            baseAracFile.ConvertedDebitAmount = fileSource.INDICADOR_DC == "D" ? Convert.ToString((Convert.ToDouble(fileSource.IMPORTE) / 100)) : null;
            baseAracFile.ConvertedCreditAmount = fileSource.INDICADOR_DC == "C" ? Convert.ToString((Convert.ToDouble(fileSource.IMPORTE) / 100)) : null; ;
            baseAracFile.Reference1 = $"{fileSource.CLIENTE_PROVEEDOR}{fileSource.NUMERO_ARACS} {fileSource.AERONAVE} {fileSource.LEGENDA_CABECALHO}";
            baseAracFile.Reference2 = "";
            baseAracFile.Reference3 = "";
            baseAracFile.Reference4 = $"{fileSource.CLIENTE_PROVEEDOR}{fileSource.NUMERO_ARACS} {fileSource.AERONAVE} {fileSource.LEGENDA_CABECALHO}";
            baseAracFile.Reference5 = "";
            baseAracFile.Reference6 = $"{fileSource.CLIENTE_PROVEEDOR}{fileSource.NUMERO_ARACS} {fileSource.AERONAVE} {fileSource.LEGENDA_CABECALHO}";
            baseAracFile.Reference7 = "";
            baseAracFile.Reference8 = "";
            baseAracFile.Reference9 = "";
            baseAracFile.Reference10 = $"{fileSource.CLIENTE_PROVEEDOR}{fileSource.NUMERO_ARACS} {fileSource.AERONAVE} {fileSource.LEGENDA_CABECALHO}";
            baseAracFile.Referencecolumn1 = "";
            baseAracFile.Referencecolumn2 = "";
            baseAracFile.Referencecolumn3 = "";
            baseAracFile.Referencecolumn4 = "";
            baseAracFile.Referencecolumn5 = "";
            baseAracFile.Referencecolumn6 = "";
            baseAracFile.Referencecolumn7 = "";
            baseAracFile.Referencecolumn8 = "";
            baseAracFile.Referencecolumn9 = "";
            baseAracFile.Referencecolumn10 = "";
            baseAracFile.StatisticalAmount = "";
            baseAracFile.CurrencyConversionType = "";
            baseAracFile.CurrencyConversionDate = "";
            baseAracFile.CurrencyConversionRate = "";
            baseAracFile.InterfaceGroupIdentifier = "";
            baseAracFile.ContextfieldforJournalEntryLineDFF = "";
            baseAracFile.Attribute1 = "";
            baseAracFile.Attribute2 = "";
            baseAracFile.Attribute3 = "";
            baseAracFile.Attribute4 = "";
            baseAracFile.Attribute5 = "";
            baseAracFile.Attribute6 = "";
            baseAracFile.Attribute7 = "";
            baseAracFile.Attribute8 = "";
            baseAracFile.Attribute9 = "";
            baseAracFile.Attribute10 = "";
            baseAracFile.Attribute11 = "";
            baseAracFile.Attribute12 = "";
            baseAracFile.Attribute13 = "";
            baseAracFile.Attribute14 = "";
            baseAracFile.Attribute15 = "";
            baseAracFile.Attribute16 = "";
            baseAracFile.Attribute17 = "";
            baseAracFile.Attribute18 = "";
            baseAracFile.Attribute19 = "";
            baseAracFile.Attribute20 = "";
            baseAracFile.ContextfieldforCapturedInformationDFF = "";
            baseAracFile.AverageJournalFlag = "";
            baseAracFile.ClearingCompany = "";
            baseAracFile.LedgerName = "";
            baseAracFile.ReconciliationReference = "";
            baseAracFile.PeriodName = Convert.ToDateTime(fileSource.FECHA_CONTABILIZACION).ToString("MMM-yy");

            #endregion

            return baseAracFile.ToString();

        }
    }
}

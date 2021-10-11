using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleParserZip
{
    //CONTABILIZAÇÃO RECEITA
    public  class FileAccountRevenue : FileAccountFactory
    {
        public override string Parser(FileSource fileSource)
        {
            #region Colunas do arquivo cs

            BaseAracFile baseAracFile = new BaseAracFile();

            baseAracFile.StatusCode = "NEW";
            baseAracFile.LegendId = string.Empty; //Definir
            baseAracFile.EffectiveDateofTransaction = fileSource.FECHA_CONTABILIZACION;
            baseAracFile.JournalSource = "ARACS";
            baseAracFile.JournalCategory = fileSource.CODIGO_ARACS == "ARAC" ? "Receita Vendida" : "Receita Voada";
            baseAracFile.CurrencyCode = fileSource.MONEDA;
            baseAracFile.JournalEntryCreationDate = $"{DateTime.Now.ToString("yyyy/MM/dd")}";
            baseAracFile.ActualFlag = "A";
            baseAracFile.Segment1 = string.Empty; //Definir
            baseAracFile.Segment4 = fileSource.CUENTA_CONTABLE;

               #region Condição para p Segmento 2 e 3 a partir do segmento 4

                    if (fileSource.CODIGO_ARACS == "ARAC")
                    {
                        if (String.IsNullOrEmpty(fileSource.CENTRO_DE_COSTO))
                        {
                            baseAracFile.Segment2 = "001";
                            //l_count_cc="0";
                            //    BEGIN
                            //SELECT COUNT(0)
                            //  INTO l_count_cc
                            //  FROM fnd_flex_value_sets vlset
                            //     , fnd_flex_values flvl
                            // WHERE vlset.flex_value_set_id = flvl.flex_value_set_id
                            //   AND flvl.flex_value = SUBSTR(reg_aracs.centro_de_costo, 1, 4)
                            //   AND vlset.flex_value_set_name = 'PLANO_CORPORATIVO_CENTRO_CUSTO';

                            //    IF l_count_cc > 0 THEN
                            //       SEGMENT3 := SUBSTR(reg_aracs.centro_de_costo, 1, 4);
                            //    ELSE
                            //       SEGMENT3 := '9000';
                            //    END IF;
                            //    EXCEPTION
                            //      WHEN OTHERS THEN
                            //    SEGMENT3:= '9000';
                            //    END;
                        }
                        else
                        {
                            if (baseAracFile.Segment4.Substring(0, 1) == "1" || baseAracFile.Segment4.Substring(0, 1) == "2")
                            {
                                baseAracFile.Segment2 = "000";
                                baseAracFile.Segment3 = "0000";
                            }
                            else if (baseAracFile.Segment4.Substring(0, 1) == "4")
                            {
                                baseAracFile.Segment2 = "001";
                                baseAracFile.Segment3 = "9000";
                            }
                            //else if ( V_SEGMENTO_4 =="'51401008")
                            //{
                            //    baseAracFile.Segment2 = "001";
                            //    baseAracFile.Segment3 = "1510";
                            //}
                            else if (baseAracFile.Segment4 == "51105002")
                            {
                                baseAracFile.Segment2 = "001";
                                baseAracFile.Segment3 = "9000";
                            }
                            //else if (V_SEGMENTO_4.Substring(0, 1) == "5")
                            //{
                            //    baseAracFile.Segment2 = "001";
                            //    baseAracFile.Segment3 = "1510";
                            //}
                        }

                    }
                    else
                    {
                        if (baseAracFile.Segment4.Substring(0, 1) == "1" || baseAracFile.Segment4.Substring(0, 1) == "2")
                        {
                            baseAracFile.Segment2 = "000";
                            baseAracFile.Segment3 = "0000";
                        }
                        //else if (V_SEGMENTO_4.Substring(0, 1) == "4" || baseAracFile.Segment4.Substring(0, 1) == "5")
                        //{
                        //    baseAracFile.Segment2 = "001";
                        //    baseAracFile.Segment3 = "9000";
                        //}
                    }

             #endregion
            baseAracFile.Segment5 = "0";
            baseAracFile.Segment6 = "00";
            baseAracFile.Segment7 = string.IsNullOrEmpty(fileSource.TIPO_DE_SERVICIO) ? "00000" : fileSource.TIPO_DE_SERVICIO;
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
            baseAracFile.Reference1 = $"{fileSource.NUMERO_ARACS}_{fileSource.NUMERO_DE_DOCUMENTO}";
            baseAracFile.Reference2 = "";
            baseAracFile.Reference3 = "";
            baseAracFile.Reference4 = fileSource.NOME_FORNECEDOR;
            baseAracFile.Reference5 = "";
            baseAracFile.Reference6 = fileSource.NOME_FORNECEDOR;
            baseAracFile.Reference7 = "";
            baseAracFile.Reference8 = "";
            baseAracFile.Reference9 = "";
            baseAracFile.Reference10 = fileSource.CODIGO_ARACS == "ARAC" ? $"VENDAS {fileSource.CODIGO_ARACS}" : $"VOADOS {fileSource.FECHA_CONTABILIZACION}";
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

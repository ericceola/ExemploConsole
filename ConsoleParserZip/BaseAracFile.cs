using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleParserZip
{
    public class BaseAracFile
    {
       public string StatusCode { get; set; }
     public string LegendId { get; set; }
     public string EffectiveDateofTransaction { get; set; }
     public string JournalSource { get; set; }
     public string JournalCategory { get; set; }
     public string CurrencyCode { get; set; }
     public string JournalEntryCreationDate { get; set; }
     public string ActualFlag { get; set; }
     public  string Segment1 { get; set; }
     public  string Segment2 { get; set; }
     public  string Segment3 { get; set; }
     public  string Segment4 { get; set; }
     public  string Segment5 { get; set; }
     public  string Segment6 { get; set; }
     public  string Segment7 { get; set; }
     public  string Segment8 { get; set; }
     public  string Segment9 { get; set; }
     public  string Segment10 { get; set; }
     public  string Segment11 { get; set; }
     public  string Segment12 { get; set; }
     public  string Segment13 { get; set; }
     public  string Segment14 { get; set; }
     public  string Segment15 { get; set; }
     public  string Segment16 { get; set; }
     public  string Segment17 { get; set; }
     public  string Segment18 { get; set; }
     public  string Segment19 { get; set; }
     public  string Segment20 { get; set; }
     public  string Segment21 { get; set; }
     public  string Segment22 { get; set; }
     public  string Segment23 { get; set; }
     public  string Segment24 { get; set; }
     public  string Segment25 { get; set; }
     public  string Segment26 { get; set; }
     public  string Segment27 { get; set; }
     public  string Segment28 { get; set; }
     public  string Segment29 { get; set; }
     public  string Segment30 { get; set; }
     public string EnteredDebitAmount { get; set; }
     public string EnteredCreditAmount { get; set; }
     public string ConvertedDebitAmount { get; set; }
     public string ConvertedCreditAmount { get; set; }
     public string Reference1 { get; set; }
     public   string Reference2 { get; set; }
     public  string Reference3 { get; set; }
     public  string Reference4 { get; set; }
     public string Reference5 { get; set; }
     public string Reference6 { get; set; }
     public string Reference7 { get; set; }
     public string Reference8 { get; set; }
     public string Reference9 { get; set; }
     public string Reference10 { get; set; }
      public string Referencecolumn1 { get; set; }
      public string Referencecolumn2 { get; set; }
      public string Referencecolumn3 { get; set; }
      public string Referencecolumn4 { get; set; }
      public string Referencecolumn5 { get; set; }
      public string Referencecolumn6 { get; set; }
      public string Referencecolumn7 { get; set; }
      public string Referencecolumn8 { get; set; }
      public string Referencecolumn9 { get; set; }
      public string Referencecolumn10 { get; set; }
      public string StatisticalAmount { get; set; }
      public string CurrencyConversionType { get; set; }
      public string CurrencyConversionDate { get; set; }
      public string CurrencyConversionRate { get; set; }
      public string InterfaceGroupIdentifier { get; set; }
      public string ContextfieldforJournalEntryLineDFF { get; set; }
      public string Attribute1 { get; set; }
      public string Attribute2 { get; set; }
      public string Attribute3 { get; set; }
      public string Attribute4 { get; set; }
      public string Attribute5 { get; set; }
      public string Attribute6 { get; set; }
      public string Attribute7 { get; set; }
      public string Attribute8 { get; set; }
      public string Attribute9 { get; set; }
      public string Attribute10  { get; set; }
      public string Attribute11 { get; set; }
      public string Attribute12 { get; set; }
      public string Attribute13 { get; set; }
      public string Attribute14  { get; set; }
      public string Attribute15  { get; set; }
      public string Attribute16  { get; set; }
      public string Attribute17  { get; set; }
      public string Attribute18  { get; set; }
      public string Attribute19  { get; set; }
      public string Attribute20  { get; set; }
      public string ContextfieldforCapturedInformationDFF { get; set; }
      public string AverageJournalFlag { get; set; }
      public string ClearingCompany { get; set; }
      public string LedgerName { get; set; }
      public string ReconciliationReference { get; set; }
      public  string PeriodName { get; set; }


        public override string ToString()
        {
            return $"{StatusCode},{LegendId},{EffectiveDateofTransaction},{JournalSource}," +
                $"{JournalCategory},{CurrencyCode},{JournalEntryCreationDate},{ActualFlag}," +
                $"{Segment1},{Segment2},{Segment3},{Segment4},{Segment5},{Segment6},{Segment7}," +
                $"{Segment8},{Segment9},{Segment10},{Segment11},{Segment12},{Segment13},{Segment14}," +
                $"{Segment15},{Segment16},{Segment17},{Segment18},{Segment19},{Segment20},{Segment21}," +
                $"{Segment22},{Segment23},{Segment24},{Segment25},{Segment26},{Segment27},{Segment28}," +
                $"{Segment29},{Segment30},{EnteredDebitAmount},{EnteredCreditAmount},{ConvertedDebitAmount}," +
                $"{ConvertedCreditAmount},{Reference1},{Reference2},{Reference3},{Reference4},{Reference5}" +
                $"{Reference6},{Reference7},{Reference8},{Reference9},{Reference10},{Referencecolumn1},{Referencecolumn2}," +
                $"{Referencecolumn3},{Referencecolumn4},{Referencecolumn5},{Referencecolumn6},{Referencecolumn7}," +
                $"{Referencecolumn8},{Referencecolumn9},{Referencecolumn10},{StatisticalAmount},{CurrencyConversionType}," +
                $"{CurrencyConversionDate},{CurrencyConversionRate},{InterfaceGroupIdentifier},{ContextfieldforJournalEntryLineDFF}," +
                $"{Attribute1},{Attribute2},{Attribute3},{Attribute4},{Attribute5},{Attribute6},{Attribute7},{Attribute8},{Attribute9}," +
                $"{Attribute10},{Attribute11},{Attribute12},{Attribute13},{Attribute14},{Attribute15},{Attribute16},{Attribute17},{Attribute18}," +
                $"{Attribute19},{Attribute20},{ContextfieldforCapturedInformationDFF},{AverageJournalFlag},{ClearingCompany},{LedgerName}," +
                $"{ReconciliationReference},{PeriodName}";








        }
    } 
}

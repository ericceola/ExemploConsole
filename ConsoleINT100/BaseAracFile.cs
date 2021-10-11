using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleINT100
{
    public class BaseAracFile
    {
        public string ReceiptType { get; set; }
        public string ReceiptNumber { get; set; }
        public string BusinessUnit { get; set; }
        public string ReceiptMethod { get; set; }
        public string ReceiptDate { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSite { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string AccountingDate { get; set; }
        public string RemittanceBankAccountNumber { get; set; }
        public string Comments { get; set; }
        public string OrgId { get; set; }
        public string ExchangeRateType { get; set; }
        public string ExchangeDate { get; set; }
        public string ExchangeRate { get; set; }

        public override string ToString()
        {
            return $" {ReceiptType},{ReceiptNumber},{BusinessUnit},{ReceiptMethod}," +
                   $"{Amount},{Currency},{CustomerName},{CustomerSite}," +
                   $"{CustomerAccountNumber},{AccountingDate},{RemittanceBankAccountNumber},{OrgId}," +
                   $"{ExchangeRateType},{ExchangeDate},{ExchangeRate}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PArserExcelConsole
{
    public  class InvoiceRequest
    {
        public string DocumentType { get; set; }

        public string DocumentNumber { get; set; }

        public string InvoiceNumber { get; set; }

        public string InvoiceAmount { get; set; }

        public string InvoiceDate { get; set; }

        public string BusinessUnit { get; set; }

        public string Description { get; set; }

        public string InvoiceSource { get; set; }

        public string PayGroup { get; set; }

        public List<InvoiceDffRequest> InvoiceDff { get; set; }

        public List<InvoiceInstallmentRequest> InvoiceInstallments { get; set; }

        public List<InvoiceLineRequest> InvoiceLines { get; set; }

    }


    public class InvoiceDffRequest
    {
        public string __FLEX_Context { get; set; }

        public string __FLEX_Context_DisplayValue { get; set; }

        public string laclsBrInputMethodBcode { get; set; }

        public string laclsBrBarcodeNum { get; set; }
    }

    public class InvoiceInstallmentRequest
    {
        public string InstallmentNumber { get; set; }

        public string DueDate { get; set; }

        public string GrossAmount { get; set; }
    }

    public class InvoiceLineRequest
    {
        public string LineNumber { get; set; }

        public string LineAmount { get; set; }

        public string LineType { get; set; }

        public string Description { get; set; }

        public string DistributionCombination { get; set; }
    }
}

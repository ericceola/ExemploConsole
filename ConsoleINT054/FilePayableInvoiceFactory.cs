using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleINT054
{
    public abstract class FilePayableInvoiceFactory
    {
        public abstract string Parser(BaseAracFile baseAracFile);

        public static FilePayableInvoiceFactory FileParser(FileParserType type)
        {
            if (type == FileParserType.PayableInvoice)
            {
                return new FilePayableInvoice();
            }


            throw new ApplicationException("Arquivo parser não existe!!!");
        }
    }
}

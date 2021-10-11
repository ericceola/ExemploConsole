using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleParserZip
{
    public abstract class FileAccountFactory
    {

        public abstract string Parser(FileSource fileSource);

        public static FileAccountFactory FileParser(FileParserType type)
        {
            if(type == FileParserType.FileAccountRevenue)
            {
                return new FileAccountRevenue();
            }
            else if(type == FileParserType.FileAccountSales)
            {
                return new FileAccountSales();
            }

            throw new ApplicationException("Arquivo parser não existe.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleINT100
{
    public abstract class FileAccountFactory
    {
        public abstract BaseAracFile Parser(FileSource fileSource);

        public static FileAccountFactory FileParser(FileParserType type)
        {
            if (type == FileParserType.FileAccountReceipt)
            {
                return new FileAccountReceipt();
            }

            throw new ApplicationException("Arquivo parser não existe.");
        }
    }
}

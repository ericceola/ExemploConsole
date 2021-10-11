using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleINT096
{
    public abstract class FileAccountFactory
    {

        public abstract string Parser(BaseAracFile baseAracFile);

        public static FileAccountFactory FileParser(FileParserType type)
        {
            if (type == FileParserType.AccountReceivable)
            {
                return new FileAccountReceivable();
            }
            

            throw new ApplicationException("Arquivo parser não existe.");
        }
    }
}

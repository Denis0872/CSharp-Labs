using System;
using System.Collections;
    using System.IO;
    using Ctype = System.Char;

namespace Lab9
{
   public class SourceFile
    {
    
        public SourceFile(string filename)
        {
      
            FileInfo source = new FileInfo(filename);
            StreamReader reader = source.OpenText();

            try
            {
            int count = (int)source.Length;
            char[] contents = new char[count];
            reader.Read(contents, 0, count);

            }
            finally
            {
                reader.Close();
            }

        }
 }

}

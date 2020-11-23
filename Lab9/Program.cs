using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InnerMain(args);
            }
            catch (System.Exception caught)
            {
                Console.WriteLine(caught);
            }
            Console.ReadKey();
        }

        public static void InnerMain(string[] args)
        {
            SourceFile source = new SourceFile(args[0]);
            HTMLTokenVisitor visitor = new HTMLTokenVisitor();
            source = Accept(visitor);
        }

        private static SourceFile Accept(HTMLTokenVisitor visitor)
        {
            throw new NotImplementedException();
        }
        
    }
}

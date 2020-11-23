using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class HTMLTokenVisitor: NullTokenVisitor
    {
        public override void Visit(ILineStartToken line)
        {
            Console.Write(line.Namber()); 
        }

    }
}

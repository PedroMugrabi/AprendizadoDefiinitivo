using System;
using System.Collections.Generic;
using System.Text;
using Teste0;

namespace Teste0
{
    internal class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using Teste1;

namespace Teste1
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

﻿using System;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianchef = new ItalianChef();
            italianchef.MakeSpecialDish();
        }
    }
}

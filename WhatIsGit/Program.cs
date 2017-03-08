using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Catalog.PrintCatalog());
            Console.WriteLine(Product.PrintProduct());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Link.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var Client = new ExternalWebService.WSLoginClient();
            var result = Client.Validate("PyTy", "Chocolat*123");
            System.Console.WriteLine(result.UserId);
            System.Console.ReadKey();
        }
    }
}

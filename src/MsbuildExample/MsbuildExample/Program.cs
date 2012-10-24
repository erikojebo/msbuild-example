using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace MsbuildExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connection string: " + ConfigurationManager.ConnectionStrings["DefaultConnectionString"]);
            Console.WriteLine("SomeSetting: " + ConfigurationManager.AppSettings["SomeSetting"]);
        }
    }
}

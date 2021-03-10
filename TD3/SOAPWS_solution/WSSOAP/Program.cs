using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSSOAP.ServiceReference1;

namespace WSSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorSoapClient calculator = new CalculatorSoapClient();
            Console.WriteLine(calculator.Add(3, 12));
            Console.ReadLine();
        }
    }
}

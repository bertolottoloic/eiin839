using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSSOAP.ServiceReference2;

namespace WSSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            IMathsOperations calculator = new MathsOperationsClient();
            Console.WriteLine(calculator.Add(3, 12));
            Console.ReadLine();
        }
    }
}

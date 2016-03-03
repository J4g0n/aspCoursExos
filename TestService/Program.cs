using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 7;
            char type = 'f';
            string result = "";

            ServiceMeteoConsole.ServiceMeteoClient service = 
                new ServiceMeteoConsole.ServiceMeteoClient();
            result = service.ConversionTemperature(temp, type);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

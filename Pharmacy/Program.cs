using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Prescripion prescripion = new Prescripion("3492039489");
            prescripion.enterAccessNumberAndPhoneNumber(3213, 948932843);


            Console.ReadKey();

        }
    }
}

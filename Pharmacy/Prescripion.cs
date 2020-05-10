using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Prescripion
    {
        int accessNumber;
        int phoneNumber;
        string pesel;
        string numberRx;

        public Prescripion()
        {
        }

        public Prescripion(string numberRx)
        {
            this.numberRx = numberRx;
            numberRxValidation(numberRx);
        }

        public Prescripion(int accessNumber, int phoneNumber)
        {
            this.accessNumber = accessNumber;
            this.phoneNumber = phoneNumber;
        }

        public Prescripion(int accessNumber, int phoneNumber, string pesel, string numberRx)
        {
            this.accessNumber = accessNumber;
            this.phoneNumber = phoneNumber;
            this.pesel = pesel;
            this.numberRx = numberRx;
        }

        /// <summary>
        /// Check numberRx validation
        /// </summary>
        /// <param name="numberRx">Prescripion number</param>
        /// <returns>Rx number if correct throw 1, else throw 0</returns>

        public int numberRxValidation(string numberRx)
        {
            if (string.IsNullOrEmpty(numberRx))
            {
                Console.WriteLine("Number is null");
                return 0;
            }
            if (numberRx.Length != 10)
            {
                Console.WriteLine("Incorect number");
                return 0;
            }
            Console.WriteLine("Correct number");
            return 1;
        }

        /// <summary>
        /// Check pesel validation
        /// </summary>
        /// <param name="pesel">pesel</param>
        /// <returns>Pesel if correct throw 1, else throw 0</returns>

        public int peselValidation(string pesel)
        {
            if (string.IsNullOrEmpty(pesel))
            {
                Console.WriteLine("Number is null");
                return 0;
            }
            if (pesel.Length != 11)
            {
                Console.WriteLine("Incorrect number");
                return 0;
            }

            return 1;
        }

        /// <summary>
        /// Enter Access Number and Phone Number
        /// </summary>
        /// <param name="accessNumber">accessNumber</param>
        /// <param name="phoneNumber">phoneNumber</param>
        /// <returns>If correct return rx number, else return "Incorrect data"</returns>
        /// 
        public string enterAccessNumberAndPhoneNumber(int accessNumber, int phoneNumber)
        {
            if (accessNumber == 0 || phoneNumber == 0)
            {
                Console.WriteLine("Incorrect data");
                return "Incorrect data";
            }
            if (Convert.ToString(accessNumber).Length != 4)
            {
                Console.WriteLine("Incorrect accesNumber");
                return "Incorrect accesNumber";
            }
            if(Convert.ToString(phoneNumber).Length != 9)
            {
                Console.WriteLine("Incorrect phoneNumber");
                return "Incorrect phoneNumber";
            }
            Console.WriteLine("Rx Number: " + numberRx);
            return numberRx;

        }




    }
}

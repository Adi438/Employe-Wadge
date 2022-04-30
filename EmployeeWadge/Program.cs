using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWadge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Full_TIME = 2;
            int PART_TIME = 1;
            int EMP_EATE_PER_HOUR = 20;

            int emphrs = 0;
            int empWage= 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
           switch (empcheck)
            {
                case PART_TIME:
                    emphrs = 4;
                    break;
                case Full_TIME:
                    emphrs = 8;
                    break;
                    default:
                    emphrs = 0;
                    break;
            }
            empWage = emphrs * EMP_EATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }



    }
}


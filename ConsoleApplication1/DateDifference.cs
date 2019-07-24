using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days, months, years;
            string Dob;
            Console.WriteLine("enter the date of birth in YYYY/MM/DD format : ");
            Dob = Console.ReadLine();        
            try
            {
                DateTime Dob1 = Convert.ToDateTime(Dob);
                DateTime CurrentDate = DateTime.Now;
                if (Dob1.Year > CurrentDate.Year)
                {
                    Console.WriteLine("Please enter a proper date ");
                }
                if (CurrentDate.Year > Dob1.Year)
                {
                    years = CurrentDate.Year - Dob1.Year;
                }
                else
                {
                    years = Dob1.Year - CurrentDate.Year;
                }
                if (CurrentDate.Month > Dob1.Month)
                {
                    months = CurrentDate.Month - Dob1.Month;
                }
                else
                {
                    months = Dob1.Month - CurrentDate.Month;
                }
                if (CurrentDate.Day > Dob1.Day)
                {
                    days = CurrentDate.Day - Dob1.Day;
                }
                else
                {
                    days = Dob1.Day - CurrentDate.Day;
                }

                Console.WriteLine("The Difference is {0} days {1} months {2} years", days, months, years);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a proper date ");
            }

                Console.ReadLine();
        }
    }
}


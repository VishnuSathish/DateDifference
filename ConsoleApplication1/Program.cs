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
            DateTime Dob1;
         
            try
            {
                Dob1 = Convert.ToDateTime(Dob);
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

                Console.WriteLine("{0} days {1} months {2} years", days, months, years);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a proper date ");
            }

                Console.ReadLine();
        }
    }
}

/*if (dob1.Month == 1 || dob1.Month == 3 || dob1.Month == 5 || dob1.Month == 7 || dob1.Month == 8 || dob1.Month == 10 || dob1.Month == 12)
           {
               if (dob1.Day > 31)
               {
                   Console.WriteLine("Please enter a proper date ");
               }
           }
           if (dob1.Month == 4 || dob1.Month == 6 || dob1.Month == 9 || dob1.Month == 12)
           {
               if (dob1.Day > 30)
               {
                   Console.WriteLine("Please enter a proper date ");
               }
           }
           if (dob1.Month == 2)
           {
               if (dob1.Day > 28)
               {
                   Console.WriteLine("Please enter a proper date ");
               }
           }
           */

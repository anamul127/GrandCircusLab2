using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDates2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first date in MM/DD/YYYY format.");
            String date1 = Console.ReadLine();
            //storing user's input as date1

            Console.WriteLine("Please enter second date in MM/DD/YYYY format.");
            String date2 = Console.ReadLine();
            //storing user's input as date2



            DateTime dateOne = DateTime.Parse(date1);
            DateTime dateTwo = DateTime.Parse(date2);
            //takes string and converts it to time

            TimeSpan elapse;
            if (dateOne > dateTwo)
            {
                elapse = dateOne - dateTwo;
            }
            else
            {
                elapse = dateTwo - dateOne;
            }
            //always returns a positive answer

            int years = (int)elapse.TotalDays / 365;
            int months = years * 12;
            //conversion

            Console.WriteLine("Years:" + years.ToString());
            Console.WriteLine("Months:" + months.ToString());
            Console.WriteLine("Days:" + elapse.TotalDays.ToString());
            Console.WriteLine("Hours:" + elapse.TotalHours.ToString());
            Console.WriteLine("Minutes:" + elapse.TotalMinutes.ToString());
            Console.ReadLine();
            //allows user to view results
        }
    }
}

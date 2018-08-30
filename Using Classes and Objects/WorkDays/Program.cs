using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDays
{
    class Program
    {
        static readonly DateTime[] holidays =
   {
        new DateTime(2018, 7, 12), new DateTime(2018, 7, 16), new DateTime(2018, 7, 17),
        new DateTime(2018, 7, 22), new DateTime(2018, 7, 23), new DateTime(2018, 7, 24),
        new DateTime(2018, 7, 26), new DateTime(2018, 7, 30), new DateTime(2018, 7, 31),
        new DateTime(2018, 8, 6), new DateTime(2018, 8, 13), new DateTime(2018, 8, 20),
        new DateTime(2018, 8, 27), new DateTime(2018, 9, 3), new DateTime(2018, 9, 10)
    };

        static void Main(string[] args)
        {
            DateTime dateNow = new DateTime(2018, 8, 30);
            DateTime dateFuture = new DateTime(2018, 9, 30);

            Console.WriteLine("Checking work days from {0:dd/MM/yyyy} to {1:dd/MM/yyyy}...\n",
                dateNow, dateFuture);

            Console.WriteLine("Total work days: {0}\n", GetNumberOfWorkDays(dateNow, dateFuture));
        }
        static int GetNumberOfWorkDays(DateTime dateNow, DateTime dateFuture)
        {
            int numberOfWorkDays = 0;

            if (dateNow > dateFuture)
            {
                DateTime swap = dateNow;
                dateNow = dateFuture;
                dateFuture = swap;
            }

            while (dateNow <= dateFuture)
            {
                if (!holidays.Contains(dateNow) && dateNow.DayOfWeek != DayOfWeek.Saturday &&
                    dateNow.DayOfWeek != DayOfWeek.Sunday)
                {
                    numberOfWorkDays++;
                }

                dateNow = dateNow.AddDays(1);
            }

            return numberOfWorkDays;
        }
    }
}

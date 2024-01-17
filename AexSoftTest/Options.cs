using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AexSoftTest
{
    public class Options
    {
        public DateTime BeginDate { get; set; }
        public decimal SumAmount { get; set; }
    }
    public class OptionsSetter
    {
        public Options SetOptions()
        {
            Options options = null;

            while (options == null)
            {
                Console.Write("Specify begin date (yyyy-MM-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime beginDate))
                {
                    Console.Write("Specify the sum of orders: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal sumAmount))
                    {
                        options = new() { BeginDate = beginDate, SumAmount = sumAmount };
                    }
                    else
                    {
                        Console.WriteLine("Incorrect format.");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect format. the required format yyyy-MM-dd");
                }
            }

            return options;
        }
    }
}



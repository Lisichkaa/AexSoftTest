using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AexSoftTest.Models;

namespace AexSoftTest
{
    public class Printer
    {
        public void PrintResult(List<CustomerViewModel> data)
        {
            if (data != null && data.Count > 0)
            {
                foreach (var item in data)
                {
                    Console.WriteLine($"Customer: {item.CustomerName}, Manager: {item.ManagerName}, Amount: {item.Amount}");
                }
            }
            else
            {
                Console.WriteLine("Match isn't found");
            }

        }
    }
}

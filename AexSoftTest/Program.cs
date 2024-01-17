using AexSoftTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AexSoftTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext dataBase = new DataBaseContext();

            DbHandler handler = new(dataBase);

            OptionsSetter optionsSetter = new();
            Options options = optionsSetter.SetOptions();

            Printer printer = new();

            List<CustomerViewModel> result = handler.GetCustomers(options.BeginDate, options.SumAmount);

            printer.PrintResult(result);

            Console.ReadLine();
        }
    }
}
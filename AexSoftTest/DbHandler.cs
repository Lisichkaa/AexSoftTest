using AexSoftTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AexSoftTest
{
   
    public class DbHandler
    {
        private readonly DataBaseContext _dataBase;

        public DbHandler(DataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }

        public List<CustomerViewModel>? GetCustomers(DateTime beginDate, decimal sumAmount)
        {
            var result = _dataBase.Customers
           .Where(customer => customer.Orders.Any(order => order.Date >= beginDate))
           .Select(customer => new CustomerViewModel
           {
               CustomerName = customer.Name,
               ManagerName = customer.Manager.Name,
               Amount = customer.Orders
                   .Sum(order => (int)order.Amount)
           })
           .Where(viewModel => viewModel.Amount > sumAmount)
           .ToList();

            return result;
        }
    }
}
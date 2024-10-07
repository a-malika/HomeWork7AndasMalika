using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class StockExchangeObserver : IObserver
    {
        public void Update(string currency, double value)
        {
            Console.WriteLine($"The exchange received a rate update: {currency} = {value}.");
        }
    }
}

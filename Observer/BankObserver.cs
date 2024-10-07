using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class BankObserver : IObserver
    {
        public void Update(string currency, double value)
        {
            Console.WriteLine($"The bank received an update of rates: {currency} = {value}.");
        }
    }
}

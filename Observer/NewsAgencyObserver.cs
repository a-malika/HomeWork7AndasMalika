using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class NewsAgencyObserver : IObserver
    {
        public void Update(string currency, double value)
        {
            Console.WriteLine($"News agency reports: {currency} = {value}.");
        }
    }
}

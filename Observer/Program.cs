using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CurrencyExchange exchange = new CurrencyExchange();
            BankObserver observer1 = new BankObserver();
            NewsAgencyObserver observer2 = new NewsAgencyObserver();
            StockExchangeObserver observer3 = new StockExchangeObserver();
            exchange.RegisterObserver(observer1);
            exchange.RegisterObserver(observer2);
            exchange.RegisterObserver(observer3);
            exchange.UpdateExchangeRate("EUR / KZT", 531.33);
            exchange.UpdateExchangeRate("USD / KZT", 481.84);
            exchange.UpdateExchangeRate("CAD / KZT", 355.52);
            exchange.UpdateExchangeRate("CNY / KZT", 68.66);
            exchange.UpdateExchangeRate("RUB / KZT", 5.07);
        }
    }
}

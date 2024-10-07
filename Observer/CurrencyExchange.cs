using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class CurrencyExchange : ISubject
    {
        private List<IObserver> observers;
        private Dictionary<string, double> exchangeRate;
        public CurrencyExchange()
        {
            observers = new List<IObserver>();
            exchangeRate = new Dictionary<string, double>();
        }
        public void UpdateExchangeRate(string currency, double value)
        {
            if (value >= 0)
            {
                exchangeRate[currency] = value;
                NotifyObserver(currency, value);
            }
            else
            {
                Console.WriteLine("Cannot do action. Wrong value.");
            }
        }
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine("Observer registered.");
        }
        public void UnegisterObserver(IObserver observer)
        {
            if (observers.Remove(observer))
            {
                Console.WriteLine("Observer unregistered.");
            }
            else Console.WriteLine("Cannot do action. Observer is not registered.");
        }
        public void NotifyObserver(string currency, double value)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(currency, value);
            }
        }
    }
}

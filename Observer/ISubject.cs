using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void UnegisterObserver(IObserver observer);
        void NotifyObserver(string currency, double value);
    }
}

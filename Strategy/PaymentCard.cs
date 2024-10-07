using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class PaymentCard : IPaymentStrategy
    {
        public void Pay (double cost)
        {
            Console.WriteLine($"Paying {cost} by credit card.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    public class PaymentContext
    {
        private IPaymentStrategy paymentStrategy;
        public PaymentContext(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }
        public void SetPaymentMethod(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }
        public void Pay(double cost)
        {
            paymentStrategy.Pay(cost);
        }
    }
}

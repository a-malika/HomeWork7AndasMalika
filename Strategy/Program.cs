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
            PaymentContext payment = null;
            Console.WriteLine("Choose type of payment: (1 - credit card, 2 - cripto, 3 - PayPal)");
            int typeDelivery = Convert.ToInt32(Console.ReadLine());
            if (typeDelivery == 1)
            {
                payment = new PaymentContext(new PaymentCard());
            }
            else if (typeDelivery == 2)
            {
                payment = new PaymentContext(new PaymentCripto());
            }
            else if (typeDelivery == 3)
            {
                payment = new PaymentContext(new PaymentPayPal());
            }
            else
            {
                throw new Exception("Not supported type of payment");
            }
            Console.WriteLine("Amount to be paid: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            payment.Pay(amount);
        }
    }
}

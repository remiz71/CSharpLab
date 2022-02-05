using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab
{
    public delegate double MoneyConvertDelegate(double value);
    internal class Money
    {
        private string CurrencyCode { get; set; }
        private double Amount { get; set; }

        public Money(double amount, string currencyCode)
        {
            Amount = amount;
            CurrencyCode = currencyCode;
        }
        public override string ToString()
        {
            return $"У Вас {Amount} {CurrencyCode}";
        }
        public  void Convert (MoneyConvertDelegate del)
        {
            foreach (MoneyConvertDelegate value in del.GetInvocationList())
            {

                Console.WriteLine("Пересчитываю ...");
                value(Amount);

            }
        }
    }
}

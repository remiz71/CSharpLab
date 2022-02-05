using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money curr = new Money(7567, "rub");
            Money dol = new Money(2.57, "$");
            MoneyConvertDelegate del = null;
            del += delegate (double amount)
            {
                Console.WriteLine($"{amount} руб = {amount * 0.013} $");
                return amount;
            };
            del += delegate (double amount)
              {
                  Console.WriteLine($"{amount} руб = {amount * 0.012} евро");
                  return amount;
              };
            del += delegate (double amount)
              {
                  Console.WriteLine($"{amount} руб = {amount * 0.32} гондурасских лемпир");
                  return amount;
              }; 
            del += (double amount) =>
              {
                  Console.WriteLine($"{amount} руб = {amount * 0.000007} унций золота");
                  return amount;
              };

            curr.Convert(del);
            

        }
    }
}

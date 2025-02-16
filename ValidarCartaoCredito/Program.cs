using System;
using System.Text.RegularExpressions;

namespace ValidarCartaoCredito
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Digite o número do cartão de crédito:");
         string cardNumber = Console.ReadLine();

         if (IsValidCardNumber(cardNumber))
         {
            string cardBrand = GetCardBrand(cardNumber);
            Console.WriteLine($"A bandeira do cartão é: {cardBrand}");
         }
         else
         {
            Console.WriteLine("Número de cartão inválido.");
         }
      }

      static bool IsValidCardNumber(string cardNumber)
      {
         // Remove espaços e traços do número do cartão
         cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

         int sum = 0;
         bool alternate = false;
         for (int i = cardNumber.Length - 1; i >= 0; i--)
         {
            int n = int.Parse(cardNumber[i].ToString());
            if (alternate)
            {
               n *= 2;
               if (n > 9)
               {
                  n -= 9;
               }
            }
            sum += n;
            alternate = !alternate;
         }
         return (sum % 10 == 0);
      }

      static string GetCardBrand(string cardNumber)
      {
         // Remove espaços e traços do número do cartão
         cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

         // Expressões regulares para identificar as bandeiras dos cartões
         if (Regex.IsMatch(cardNumber, @"^4[0-9]{12}(?:[0-9]{3})?$") || Regex.IsMatch(cardNumber, @"^4[0-9]{15}$"))
            return "Visa";
         if (Regex.IsMatch(cardNumber, @"^5[1-5][0-9]{14}$"))
            return "MasterCard";
         if (Regex.IsMatch(cardNumber, @"^3[47][0-9]{13}$"))
            return "American Express";
         if (Regex.IsMatch(cardNumber, @"^3(?:0[0-5]|[68][0-9])[0-9]{11}$"))
            return "Diners Club";
         if (Regex.IsMatch(cardNumber, @"^6(?:011|5[0-9]{2})[0-9]{12}$"))
            return "Discover";
         if (Regex.IsMatch(cardNumber, @"^(?:2131|1800|35\d{3})\d{11}$"))
            return "JCB";
         if (Regex.IsMatch(cardNumber, @"^(2014|2149)\d{11}$"))
            return "EnRoute";
         if (Regex.IsMatch(cardNumber, @"^8699[0-9]{11}$"))
            return "Voyager";
         if (Regex.IsMatch(cardNumber, @"^(606282|3841)[0-9]{10,11}$"))
            return "HiperCard";
         if (Regex.IsMatch(cardNumber, @"^50[0-9]{14,17}$"))
            return "Aura";

         return "Bandeira desconhecida";
      }
   }
}

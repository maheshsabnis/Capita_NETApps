using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Event.Logic
{
    /// <summary>
    /// Notifier class, this will be retriving the Transaction Details from Banking class 
    /// </summary>
    internal class Notifier
    {
        Banking bank;

        public Notifier(Banking b)
        {
            bank = b;
            // 1. Subscribe to the Events from Banking 
            // so that the client will be provided with Notification
            bank.OverBalance += Bank_OverBalance; // C# 3.0+ Syntax
            bank.UnderBalance += new TransactionHandler(Bank_UnderBalance);
        }

        private void Bank_OverBalance(decimal trAmt)
        {
            decimal taxableAmount = trAmt - 100000;
            decimal tax = taxableAmount * Convert.ToDecimal(0.12);
            Console.WriteLine($"Dear Account Hoslder, your NetBalance is Rs. {trAmt}/- wheich is Rs. {taxableAmount}/- more than Rs. 100000/-, so please Pay tax of Rs. {tax}/-");
        }

        private void Bank_UnderBalance(decimal trAmt)
        {
            decimal lessbanalce = 5000 - trAmt;
            Console.WriteLine($"You Netbalce is Rs.{trAmt}/- which is Rs.{lessbanalce}/- than Rs. 5000/- sp please maintain min balance");
        }



    }
}

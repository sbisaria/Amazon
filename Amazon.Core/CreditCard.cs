using System;

namespace Amazon.Core
{
    public class CreditCard
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpirayDate { get; set; }
        public int Cvv { get; set; }
    }
}
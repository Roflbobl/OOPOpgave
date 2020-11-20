using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensOpgave
{
    class InsertCashTransaction : Transaction
    {
        public InsertCashTransaction(User user, Decimal amount)
        {
            User1 = user;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Type: Indbetaling {Id} {Amount} {User1} {Date}";
        }

        public override void Execute()
        {
            User1.Balance += Amount;
        }
    }
}

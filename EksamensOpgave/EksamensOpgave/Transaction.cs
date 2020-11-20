using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensOpgave
{
    class Transaction
    {
        public Transaction() { }
        public Transaction(User user)
        {
            User1 = user;
        }

        private int _id = IdCounter++;
        private User _user;
        private DateTime _date;
        private decimal _amount;

        private static int IdCounter = 1;

        public int Id
        {
            get { return _id; }
        }

        public User User1
        {
            get { return _user; }
            set
            {
                if(value == null)
                    throw new ArgumentException("Brugeren må ikke være null");
                _user = value;
            }
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                //Skal måske ikke bruges. Tal med de andre
                //if(value < DateTime.Now)
                //    throw new ArgumentException("Tidspunktet for transactionen må ikke gå tilbage i tid");
                _date = value;
            }
        }

        public decimal Amount
        {
            get { return _amount; }
            set
            {
                _amount = value; 
            }
        }

        public override string ToString()
        {
            return $"{Id} {User1} {Amount} {Date}";
        }

        public virtual void Execute() 
        { 
           /* if(Amount >= 0)
            {
                InsertCashTransaction Transaction = new InsertCashTransaction(User1, Amount);
                Transaction.Execute();
            }
            else
            {
                BuyTransaction Transaction = new BuyTransaction(User1, Amount);
                Transaction.Execute();
            } */
        }
    }
}

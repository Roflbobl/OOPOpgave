using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensOpgave
{
    class BuyTransaction : Transaction
    {
        public BuyTransaction(User user, Decimal amount, Product product)
        {
            User1 = user;
            Amount = amount;
            Product = product;
        }

        private Product _product;

        public Product Product
        {
            get { return _product; }
            set
            {
                _product = value;
            }
        }
        public override string ToString()
        {
            return $"Type: Indbetaling {Id} {Amount} {User1} {Date}";
        }

        public override void Execute()
        {
            if (Product.CanBeBoughtOnCredit == false & (User1.Balance + Amount) < 0)
                throw new InsufficientCreditsException(User1, Product);
            else if (!Product.Active)
                throw new ProductNotActiveException(Product);

            User1.Balance += this.Amount;
        }
    }
}

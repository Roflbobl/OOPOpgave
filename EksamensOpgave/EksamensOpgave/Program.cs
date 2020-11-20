using System;

namespace EksamensOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();

            void Test(User user, decimal balance)
            {
                Console.WriteLine("din balance er:" + user.Username + " " + balance);
            }

            u.UserBalanceNotificationMethod += Test;
            u.Balance = 0;
            u.Email = "rolfm@gmail.com";
            u.FirstName = "rolf";
            u.LastName = "andersen";
            u.Username = "roflbobl";

            Product p = new Product();
            p.Active = true;
            p.CanBeBoughtOnCredit = false;
            p.Name = "cola";
            p.Price = 5;

            BuyTransaction t = new BuyTransaction(u, -p.Price, p);
            t.Date = DateTime.Now;
            t.Execute();

            Console.WriteLine("Final: " + u.Balance);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensOpgave
{
    class LineSystem
    {
        public void BuyProduct(User user, Product product)
        {

        }
        public void AddCreditsToAccount(User user, Decimal amount)
        {

        }
        public void ExecuteTransaction(Transaction transaction)
        {

        }
        public Product GetProductById(int Id)
        {
            return null;
        } 
        public List<User> GetUsers(Func<User, bool> predicate)
        {
            return null;
        }
        public User GetUserByUsername(string username)
        {
            return null;
        }
        public List<Transaction> GetTransactions(User user, int count)
        {
            return null;
        } 
        public List<Product> ActiveProducts()
        {
            return null;
        }

    }
}

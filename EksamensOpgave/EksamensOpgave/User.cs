using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EksamensOpgave
{
    class User : IComparable
    {
        public User()
        {

        }

        private int _id = IdCounter++;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _username;
        private decimal _balance;

        private static int IdCounter = 0;
        private static List<string> UsedUsernames = new List<string>();

        public delegate void UserBalanceNotification(User user, decimal balance);
        public UserBalanceNotification UserBalanceNotificationMethod;

        public int Id
        {
            get { return _id; }
        }
        public string FirstName 
        {
            get { return _firstName; } 
            set 
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentException("Fornavnet må ikke være tomt eller null");
                _firstName = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Efternavn må ikke være tomt eller null");
                _lastName = value;
            }
        }
        public string Username 
        {
            get { return _username; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Brugernavn må ikke være tomt eller null");

                if (UsedUsernames.Contains(value))
                    throw new ArgumentException("Brugernavnet er allerede i brug. Vælg et nyt");

                Regex regexUsername = new Regex("^[a-z-0-9_]*$");
                Match regexMatch = regexUsername.Match(value);

                if (regexMatch.Success)
                {
                    _username = value;
                    UsedUsernames.Add(value);
                }
                else
                    throw new ArgumentException("Brugernavnet består af ugyldige tegn");
            }
        }
        public string Email 
        { 
            get { return _email; }
            set
            {
                Regex regexEmail = new Regex("^[\\w\\.-]*@[\\w](?=.*[\\.])[\\w\\.-]*[\\w]$");
                Match regexMatch = regexEmail.Match(value);

                if (regexMatch.Success)
                    _email = value;
                else
                    throw new ArgumentException("Emailen er ikke valid");
            }
        }
        public decimal Balance 
        { 
            get { return _balance; }
            set
            {
                _balance = value;

                if(value < 50)
                    UserBalanceNotificationMethod(this, _balance);
            }
        }

        public int CompareTo(object obj)
        {
            User other = (User)obj;
            return this.Id.CompareTo(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            else
            {
                User u = (User)obj;
                return  (Id == u.Id) && (FirstName == u.FirstName) 
                        && (LastName == u.LastName) && (Username == u.Username) 
                        && (Email == u.Email) && (Balance == u.Balance);
            }
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Email})"; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensOpgave
{
    class User : IComparable
    {

        private string _firstName;
        private string _lastName;
        private string _email;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public int CompareTo(object obj)
        {
            return ID.CompareTo(obj);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            throw new NotImplementedException();
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{_firstName} {_lastName} {_email}"; 
        }
    }
}

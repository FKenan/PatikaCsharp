using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    internal class User
    {
        private static List<User> users = new List<User>();
        internal static List<User> Users { get => users; }

        private string userName;
        private string firstName;
        private string lastName;

        public string UserName { get => userName; set => userName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public User(string userName, string firstName, string lastName)
        {
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            users.Add(this);
        }

       

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTest
{
    // class = noun
    public class User
    {
        private readonly string _userId; // <-- private field (adjective)
        public string Name { get; set; } // property (adjective)
        public string Email { get; private set; }



        // private backing field
        private string _lastName;
        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        public string GetLastName()
        {
            return _lastName;
        }


        // empty constructor
        public User() { }


        // full constructor
        public User(string userId, string Name, string Email)
        {
            _userId = userId;
        }

        // method (verb)
        public string getUserId()
        {
            return _userId;
        }
    }
}

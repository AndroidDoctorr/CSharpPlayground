using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTest
{
    // classes go in namespaces
    public class Monster
    {
        // properties and methods go inside classes

        // health is private, because we don't want the health to be overwritten unexpectedly

        private int _health;

        // constructor
        public Monster()
        {
            _health = 100;
        }

        public void TakeDamage(int damageAmt) // integer parameter
        {
            Console.WriteLine($"Monster takes {damageAmt} damage");

            _health -= damageAmt;
        }

        public int ShowHealth() // no parameters
        {
            return _health;
        }
    }
}

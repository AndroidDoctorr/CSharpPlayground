using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RandomTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            User userOne = new User();
            userOne.Name = "Steve";

            // this is private now so I can't set it
            // userOne.Email = "sfdgfdgh";


            User userTwo = new User("12345ASDF", "Nick", "something@somewhere.com");

            Console.WriteLine(userOne.getUserId());

            Console.WriteLine(userTwo.Email);
        }

        [TestMethod]
        public void MonsterTest()
        {
            Monster monster = new Monster();

            monster.TakeDamage(15);

            Console.WriteLine(monster.ShowHealth());
        }
    }
}

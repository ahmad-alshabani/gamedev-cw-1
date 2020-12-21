using System;

namespace CW_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Ahmad";
            string superPower1 = "Iron Sheild";
            string superPower2 = "Night vision";
            double speed = 1.65;
            int age = 15;

            string heroName = "Kratos";
            int heroHeight = 188;
            int heroAge = 35;
            string heroSuperPower1 = "Blades of Athena";
            string heroSuperPower2 = "Wrath of Valhalla";

            int ageDifference = heroAge - age;

            Console.WriteLine("My name is {4}, and my superpowers are {3} and {2}. My age is {1} and my speed is {0} ", speed, age, superPower2, superPower1, characterName);
            Console.WriteLine("And my name is {0}, and my superpowers are {1} and {2}. I am {3} years old, and I am standing at {4}cm. ", heroName, superPower1, superPower2, heroAge, heroHeight);
            Console.WriteLine("The age difference between the two character is {0}" ,ageDifference);
            if (heroSuperPower1 != superPower1) Console.WriteLine("There is a character that is stronger than the other one");
        }
    }
}

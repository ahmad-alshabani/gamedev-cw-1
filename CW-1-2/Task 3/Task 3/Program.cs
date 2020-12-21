using System;

namespace Task_3
{
    class Program
    {
        static double playerSpeed = 50;
        static void Main(string[] args)
        {
            SetSpeed(2.5);
            GetSpeed();
        }

        static void SetSpeed(double speed)
        {
            playerSpeed = speed;
        }
        static void GetSpeed()
        {
            Console.WriteLine("The current player speed is {0}", playerSpeed);
        }
    }
}

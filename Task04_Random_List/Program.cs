using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList testList = new RandomList();
            testList.Add("Kiril");
            testList.Add("Petar");
            testList.Add("Ivan");
            testList.Add("Lili");
            testList.Add("Sophy");
            testList.Add("Alex");
            testList.Add("John");
            testList.Add("Perla");
            testList.Add("Jane");

            for (int i = 1; i <= 5; i++)
            {
                testList.RandomString();
            }

            // Console.WriteLine("Hello World!");
        }
    }
}

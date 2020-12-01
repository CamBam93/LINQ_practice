using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameList = new List<string>();
            gameList.Add("Halo");
            gameList.Add("Kingdom Hearts");
            gameList.Add("Skyrim");
            gameList.Add("OverWatch");
            gameList.Add("PUBG");
            gameList.Add("Tekken 7");

            var nameL = gameList.OrderBy(l => l.Length);
            foreach(var i in nameL)
            {
                Console.WriteLine(i);
            }
        }
    }
}

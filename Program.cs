using System;

namespace exploring_variables
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Exploring Variables");

            //Variables
            string heroPrefix = "Pearl"; //I'm doing my warriorsona Pearlstar, leader of...someClan
            string heroSuffix = "star";
            string heroName = heroPrefix + heroSuffix;

            //Begin Code Instructions
            Console.WriteLine("Behold, the leader of PigeonClan - "+ heroName + "!");
        }
    }
}
using System;

namespace exploring_variables
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Exploring Variables\n");

            /*
             * | VARIABLES | 
             * 
             *  |Names| 
             *      - Hero: heroPrefix, heroSuffix, heroRank, heroName
             *      - Boss: bossRank, bossName
             *      - Minions: minionRank, minion1Name, minion2Name
             *  |Stats|
             *      - Hero: heroHealth, heroStrength
             *      - Boss: bossHealth, bossStrength
             *      - Minions: minion1Health, minion2Health, 
             *                 minion1Strength, minion2Strength
             */

            // |Names|
            string heroPrefix = "Pearl"; //I'm doing my warriorsona Pearlstar, leader of...someClan
            string heroSuffix = "star"; //init to -star, bc hero is a leader, but who knows what'll happen
            string heroRank = "Leader of PigeonClan";
            string heroName;
            string bossRank;
            string bossName;
            string minionRank;
            string minion1Name;
            string minion2Name;

            // |Stats|
            int heroHealth;
            int heroStrength;
            int bossHealth;
            int bossStrength;
            int minion1Health;
            int minion1Strength;
            int minion2Health;
            int minion2Strength;


            //Begin Code Instructions
            heroName = heroPrefix + heroSuffix; //no space, it's warrior cats
            Console.WriteLine("Behold "+ heroName + ", " + heroRank + "!");

        }
    }
}
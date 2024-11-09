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
            string heroName = "EMPTY";
            string bossRank = "Leader of BatClan";
            string bossName = "EMPTY";
            string minionRank = "BatClan Warrior";
            string minion1Name = "EMPTY";
            string minion2Name = "EMPTY";

            // |Stats|
            int heroHealth = 24;
            int heroStrength = 36; //health mid, strength high
            int bossHealth = 44;
            int bossStrength = 20; //health very high, strength mid
            int minion1Health = 16;
            int minion1Strength = 12; //mid stats
            int minion2Health = 20;
            int minion2Strength = 8; //health higher mid, stength low


            //Begin Code Instructions
            
            //Names
            heroName = heroPrefix + heroSuffix;
            bossName = "Fruitstar";
            minion1Name = "Whitenose";
            minion2Name = "Caveflower";

            //Introduce Characters
            Console.Write("\"Oh make way for " + heroName + ", the apprentice named " + heroRank + "!\"\n");
            Console.WriteLine("mocks " + bossName + ", the " + bossRank + ".");
            Console.WriteLine(bossName + " is accompanied by " + minionRank + "s: " + 
                minion1Name + " and " + minion2Name + ".");

        }
    } 
}
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
             *      - Minions: minion1Rank, minion1Name, 
             *                 minion2Rank, minion2Name
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
            string heroName = ""; //init to empty string
            string bossRank = "Leader of BatClan";
            string bossName = "Fruitstar";
            string minion1Rank = "BatClan Warrior";
            string minion1Name = "Whitenose";
            string minion2Rank = "BatClan Warrior";
            string minion2Name = "Caveflower";

            // |Stats|
            int heroHealth = 24;
            int heroStrength = 36; //health mid, strength high
            int bossHealth = 48;
            int bossStrength = 20; //health very high, strength mid
            int minion1Health = 16;
            int minion1Strength = 12; //mid stats
            int minion2Health = 20;
            int minion2Strength = 8; //health higher mid, stength low


            //Begin Code Instructions
            heroName = heroPrefix + heroSuffix; //no space, it's warrior cats
            Console.WriteLine("Behold "+ heroName + ", " + heroRank + "!");

        }
    }
}
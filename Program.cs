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
            double heroHealth = 6.0;
            double heroStrength = 9.0;

            double bossHealth = 11.0;
            double bossStrength = 5.0; //health very high, strength mid

            double minion1Health = 4.0;
            double minion1Strength = 3.0; //mid stats
            double minion2Health = 6.5;
            double minion2Strength = 1.0; //health higher mid, stength low


            //Begin Code Instructions

            //Names
            heroName = heroPrefix + heroSuffix;
            bossName = "Fruitstar";
            minion1Name = "Whitenose";
            minion2Name = "Caveflower";

            //Initiate battle
            Console.WriteLine(bossName + ", the " + bossRank + ", is accompanied by " + minionRank + "s: " +
                minion1Name + " and " + minion2Name + ".");
            Console.WriteLine(heroName + ", the " + heroRank + ", stands their ground...\n");

            //View stats
            Console.WriteLine("PREPARE FOR BATTLE:\n");
            Console.WriteLine(heroName + ": " + heroHealth + "HP " + heroStrength + "ATK");
            Console.WriteLine(heroRank + " - \"Brutal fighter that can take a hit\"\n");

            Console.WriteLine(bossName + ": " + bossHealth + "HP " + bossStrength + "ATK");
            Console.WriteLine(bossRank + " - \"Persuasive tank that packs a punch\"\n");

            Console.WriteLine(minion1Name + ": " + minion1Health + "HP " + minion1Strength + "ATK");
            Console.WriteLine(minionRank + " - \"Loyal, well-balanced soldier\"\n");

            Console.WriteLine(minion2Name + ": " + minion2Health + "HP " + minion2Strength + "ATK");
            Console.WriteLine(minionRank + " - \"Durable, but scared of blood\"\n");





        }
    }
}
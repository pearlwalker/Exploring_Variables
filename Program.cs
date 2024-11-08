﻿using System;

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

            //FIGHT!
            Console.WriteLine("FIGHT!\n");
            
            heroHealth -= (bossStrength / 2);
            Console.WriteLine(bossName + " charges " + heroName + " and hits for " + bossStrength / 2 + " damage!");
            Console.WriteLine(heroName + " has " + heroHealth + " HP\n");
            Console.WriteLine(heroName + " has condition: bleeding");
            Console.WriteLine(bossName + " has status: initiative");
            Console.WriteLine(minion1Name + " has status: inspired");
            Console.WriteLine(minion2Name + " has status: inspired\n"+ minion2Name +" has condition: anxiety\n");

            Console.WriteLine(heroName + " catches " + bossName + " off guard with a counterattack, and hits for " + heroStrength + " damage!");
            Console.WriteLine(heroName + " has condition: bleeding - minus 0.5HP");
            heroHealth -= 0.5;
            bossHealth -= heroStrength;
            Console.WriteLine(heroName + " has " + heroHealth + " HP");
            Console.WriteLine(bossName + " has " + bossHealth + " HP\n");
            Console.WriteLine(minion2Name + " has condition: anxiety - " + minion2Name + " runs away!\n");

            Console.WriteLine(minion1Name + " chases after " + minion2Name + ", leaving " 
                + bossName + " alone...");
            Console.WriteLine(bossName + " turns back to " + heroName + 
                ", who bites their neck for " + heroStrength*1000 + " damage!\n");
            Console.WriteLine(heroName + " KILLED the remaining opponent " + bossName);
            Console.WriteLine(heroName + " wins! Viva la PigeonClan!");





        }
    }
}
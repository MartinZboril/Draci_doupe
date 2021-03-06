﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Classes
{
    public class Enemies
    {
        List<int> Enemy_ID = new List<int>();
        List<string> Enemy_Name = new List<string>();
        List<int> Enemy_Lives = new List<int>();
        List<int> Enemy_AttackStrength = new List<int>();
        List<int> Enemy_Defense = new List<int>();
        List<int> Enemy_Experience = new List<int>();
        List<string> Enemy_Images = new List<string>();

        public Enemies()
        {
            Enemy_ID.Add(1);
            Enemy_ID.Add(2);
            Enemy_ID.Add(3);
            Enemy_ID.Add(4);
            Enemy_ID.Add(5);
            Enemy_ID.Add(6);
            Enemy_ID.Add(7);
            Enemy_ID.Add(8);
            Enemy_ID.Add(9);
            Enemy_ID.Add(10);

            Enemy_Name.Add("Barbaři");
            Enemy_Name.Add("Medvěd");
            Enemy_Name.Add("Velitel");
            Enemy_Name.Add("Kapitán pirátů");
            Enemy_Name.Add("Poslové zla");
            Enemy_Name.Add("Slon");
            Enemy_Name.Add("Klíčník");
            Enemy_Name.Add("Velitel armády");
            Enemy_Name.Add("Velitel města");
            Enemy_Name.Add("Faraón");

            Enemy_Lives.Add(50);
            Enemy_Lives.Add(60);
            Enemy_Lives.Add(80);
            Enemy_Lives.Add(90);
            Enemy_Lives.Add(120);
            Enemy_Lives.Add(55);
            Enemy_Lives.Add(70);
            Enemy_Lives.Add(80);
            Enemy_Lives.Add(100);
            Enemy_Lives.Add(125);

            Enemy_AttackStrength.Add(30);
            Enemy_AttackStrength.Add(40);
            Enemy_AttackStrength.Add(45);
            Enemy_AttackStrength.Add(25);
            Enemy_AttackStrength.Add(35);
            Enemy_AttackStrength.Add(20);
            Enemy_AttackStrength.Add(50);
            Enemy_AttackStrength.Add(50);
            Enemy_AttackStrength.Add(10);
            Enemy_AttackStrength.Add(10);

            Enemy_Defense.Add(20);
            Enemy_Defense.Add(20);
            Enemy_Defense.Add(40);
            Enemy_Defense.Add(45);
            Enemy_Defense.Add(60);
            Enemy_Defense.Add(70);
            Enemy_Defense.Add(70);
            Enemy_Defense.Add(60);
            Enemy_Defense.Add(80);
            Enemy_Defense.Add(80);

            Enemy_Experience.Add(100);
            Enemy_Experience.Add(100);
            Enemy_Experience.Add(200);
            Enemy_Experience.Add(200);
            Enemy_Experience.Add(200);
            Enemy_Experience.Add(200);
            Enemy_Experience.Add(200);
            Enemy_Experience.Add(200);
            Enemy_Experience.Add(200);
            Enemy_Experience.Add(200);

            Enemy_Images.Add("Images/Barbarians.jpg");
            Enemy_Images.Add("Images/Bear.png");
            Enemy_Images.Add("Images/Boss.png");
            Enemy_Images.Add("Images/Pirate.png");
            Enemy_Images.Add("Images/Ninja.png");
            Enemy_Images.Add("Images/Elephant.png");
            Enemy_Images.Add("Images/Guard1.png");
            Enemy_Images.Add("Images/Guard3.png");
            Enemy_Images.Add("Images/Guard2.png");
            Enemy_Images.Add("Images/Pharaoh.png");
        }
        /// <summary>
        /// Metoda pro získání jména nepřítele z kolekce
        /// </summary>
        /// <param name="num">ID nepřítele</param>
        /// <returns>Nepřítelovo jméno</returns>
        public string GetEnemyName(int num)
        {
            string name = Enemy_Name[num];
            return name;
        }
        /// <summary>
        /// Metoda pro získání životů nepřítele
        /// </summary>
        /// <param name="num">ID nepřítele</param>
        /// <returns>Nepřítelovi životy</returns>
        public int GetEnemyLives(int num)
        {
            int lives = Enemy_Lives[num];
            return lives;
        }
        /// <summary>
        /// Metoda pro získání síly útoku nepřítele
        /// </summary>
        /// <param name="num">ID nepřítele</param>
        /// <returns>Nepřítelovu sílu útoku</returns>
        public int GetEnemyAttackStrength(int num)
        {
            int attack = Enemy_AttackStrength[num];
            return attack;
        }
        /// <summary>
        /// Metoda pro získání obrany nepřítele
        /// </summary>
        /// <param name="num">ID nepřítele</param>
        /// <returns>Nepřítelova obrana</returns>
        public int GetEnemyDefense(int num)
        {
            int defense = Enemy_Defense[num];
            return defense;
        }
        /// <summary>
        /// Metoda pro získání zkušeností za poražení nepřítele
        /// </summary>
        /// <param name="num">ID nepřítele</param>
        /// <returns>Nepřítelova zkušenost za poražení</returns>
        public int GetEnemyExperience(int num)
        {
            int experience = Enemy_Experience[num];
            return experience;
        }
        /// <summary>
        /// Metoda pro získání obrázku nepřítele
        /// </summary>
        /// <param name="num">ID nepřítele</param>
        /// <returns>Nepřítelův obrázek</returns>
        public string GetEnemyImage(int num)
        {
            string image = Enemy_Images[num];
            return image;
        }
    }
}
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

        public Enemies()
        {
            Enemy_ID.Add(1);
            Enemy_ID.Add(2);
            Enemy_ID.Add(3);

            Enemy_Name.Add("Nepřátelská karavana");
            Enemy_Name.Add("Horské zvíře");
            Enemy_Name.Add("Jeskynní lidé");

            Enemy_Lives.Add(100);
            Enemy_Lives.Add(130);
            Enemy_Lives.Add(180);

            Enemy_AttackStrength.Add(10);
            Enemy_AttackStrength.Add(35);
            Enemy_AttackStrength.Add(40);

            Enemy_Defense.Add(5);
            Enemy_Defense.Add(10);
            Enemy_Defense.Add(7);
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
    }
}
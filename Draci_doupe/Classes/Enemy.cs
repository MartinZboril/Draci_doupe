﻿using Draci_doupe.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draci_doupe.Classes;

namespace Draci_doupe
{
    public class Enemy
    {
        Enemies enemies = new Enemies();
        //List<int> n = 0;
        public Enemy()
        {

        }
        public Enemy(string name, double lives, int attack, double defense)
        {
            _enemyid = 0;
            _enemyname = name;
            _enemylives = lives;
            _enemyattackstrength = attack;
            _enemydefense = defense;
        }
        public Enemy(int n)
        {
            _enemyid = n;
            _enemyname = enemies.GetEnemyName(n);
            _enemylives = enemies.GetEnemyLives(n);
            _enemyattackstrength = enemies.GetEnemyAttackStrength(n);
            _enemydefense = enemies.GetEnemyDefense(n);
        }
        private int _enemyid;
        public int EnemyId
        {
            get { return _enemyid; }
            set { _enemyid = value; }
        }
        private string _enemyname;
        public string EnemyName
        {
            get { return _enemyname; }
            set { _enemyname = value; }
        }
        private double _enemylives;
        public double EnemyLives
        {
            get { return _enemylives; }
            set { _enemylives = value; }
        }
        private int _enemyattackstrength;
        public int EnemyAttackStrength
        {
            get { return _enemyattackstrength; }
            set { _enemyattackstrength = value; }
        }
        private double _enemydefense;
        public double EnemyDefense
        {
            get { return _enemydefense; }
            set { _enemydefense = value; }
        }
        /// <summary>
        /// Útok nepřítele, klasický
        /// </summary>
        /// <param name="enemy">Nepřítel na kterého se útočí</param>
        /// <param name="attack">Síla útoku</param>
        public void AttackEnemy(Enemy enemy, int attack)
        {
            int _attackStrenght = attack;
            IAttackBehavior attackBehavior = new BasicAttackBehavior();
            attackBehavior.Attack(enemy, _attackStrenght);
        }
        /// <summary>
        /// Útok nepřítele, jako šermíř
        /// </summary>
        /// <param name="enemy">Nepřítel na kterého se útočí</param>
        /// <param name="attack">Síla útoku</param>
        public void FighterAttackEnemy(Enemy enemy, int attack)
        {
            int _attackStrenght = attack;
            IAttackBehavior attackBehavior = new FighterAttackBehavior();
            attackBehavior.Attack(enemy, _attackStrenght);
        }
        /// <summary>
        /// Útok nepřítele, lučištník
        /// </summary>
        /// <param name="enemy">Nepřítel na kterého se útočí</param>
        /// <param name="attack">Síla útoku</param>
        public void ArcherAttackEnemy(Enemy enemy, int attack)
        {
            int _attackStrenght = attack;
            IAttackBehavior attackBehavior = new ArcherAttackBehavior();
            attackBehavior.Attack(enemy, _attackStrenght);
        }
    }
}
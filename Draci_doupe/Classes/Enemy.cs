using Draci_doupe.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draci_doupe.Classes;
using Draci_doupe.Interface;

namespace Draci_doupe
{
    public class Enemy : IPerson
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
            _enemyexperience = enemies.GetEnemyExperience(n);
            _image = enemies.GetEnemyImage(n);
        }
        private int _enemyid;
        public int ID
        {
            get { return _enemyid; }
            set { _enemyid = value; }
        }
        private string _enemyname;
        public string Name
        {
            get { return _enemyname; }
            set { _enemyname = value; }
        }
        private double _enemylives;
        public double Lives
        {
            get { return _enemylives; }
            set { _enemylives = value; }
        }
        private int _enemyattackstrength;
        public int Attack
        {
            get { return _enemyattackstrength; }
            set { _enemyattackstrength = value; }
        }
        private double _enemydefense;
        public double Defense
        {
            get { return _enemydefense; }
            set { _enemydefense = value; }
        }
        private int _enemyexperience;
        public int EnemyExperience
        {
            get { return _enemyexperience; }
            set { _enemyexperience = value; }
        }
        private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        private double _currentAttack;
        public double CurrentAttack
        {
            get { return _currentAttack; }
            set { _currentAttack = value; }
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
            _currentAttack = attackBehavior.Attack(enemy, _attackStrenght);
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
            _currentAttack = attackBehavior.Attack(enemy, _attackStrenght);
        }
    }
}

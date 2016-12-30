using Draci_doupe.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public class Enemy
    {
        List<int> Enemy_ID = new List<int>();
        List<string> Enemy_Name = new List<string>();
        List<int> Enemy_Lives = new List<int>();
        List<int> Enemy_AttackStrength = new List<int>();
        public Enemy()
        {

        }
        public Enemy(string name, int lives)
        {
            _enemyid = 0;
            _enemyname = name;
            _enemylives = lives;
            _enemyattackstrength = 10;
        }
        public Enemy(int n)
        {
            Enemy_ID.Add(1);
            Enemy_ID.Add(2);
            Enemy_ID.Add(3);

            Enemy_Name.Add("Nepřátelská karavana");
            Enemy_Name.Add("Horské zvíře");
            Enemy_Name.Add("Jeskynní lidé");

            Enemy_Lives.Add(50);
            Enemy_Lives.Add(130);
            Enemy_Lives.Add(180);

            Enemy_AttackStrength.Add(5);
            Enemy_AttackStrength.Add(35);
            Enemy_AttackStrength.Add(40);

            _enemyid = Enemy_ID[n];
            _enemyname = Enemy_Name[n];
            _enemylives = Enemy_Lives[n];
            _enemyattackstrength = Enemy_AttackStrength[n];
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
        private int _enemylives;
        public int EnemyLives
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

        public void AttackEnemy(Enemy enemy, int attack)
        {
            int _attackStrenght = attack;
            IAttackBehavior attackBehavior = new BasicAttackBehavior();
            attackBehavior.Attack(enemy, _attackStrenght);
        }
    }
}

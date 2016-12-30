using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Attack
{
    public class BasicAttackBehavior : IAttackBehavior
    {
        public void Attack(Enemy enemy, int attackStrenght)
        {
            enemy.EnemyLives = enemy.EnemyLives - attackStrenght;
        }
    }
}

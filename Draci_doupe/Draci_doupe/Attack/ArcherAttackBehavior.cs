using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Attack
{
    class ArcherAttackBehavior : IAttackBehavior
    {
        /// <summary>
        /// Metoda pro útok lučištníka 
        /// </summary>
        /// <param name="enemy">Nepřítel</param>
        /// <param name="attackStrenght">Síla útoku</param>
        public void Attack(Enemy enemy, int attackStrenght)
        {
            enemy.EnemyLives -= (attackStrenght * 3) - ((enemy.EnemyDefense / 100) * enemy.EnemyLives);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Attack
{
    class DiceAttackBehavior : IAttackBehavior
    {
        /// <summary>
        /// Metoda pro útok speciální 
        /// </summary>
        /// <param name="enemy">Nepřítel</param>
        /// <param name="attackStrenght">Síla útoku</param>
        public void Attack(Enemy enemy, int attackStrenght)
        {
            enemy.EnemyLives -= (attackStrenght*10) - ((enemy.EnemyDefense / 100) * enemy.EnemyLives);
        }
    }
}

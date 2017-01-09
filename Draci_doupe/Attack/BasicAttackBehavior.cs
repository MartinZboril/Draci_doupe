using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Attack
{
    public class BasicAttackBehavior : IAttackBehavior
    {
        /// <summary>
        /// Metoda pro útok klasický 
        /// </summary>
        /// <param name="enemy">Nepřítel</param>
        /// <param name="attackStrenght">Síla útoku</param>
        public void Attack(Enemy enemy, int attackStrenght)
        {
            enemy.EnemyLives -= attackStrenght - ((enemy.EnemyDefense/100)*enemy.EnemyLives);
        }
    }
}

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
            if ((attackStrenght - enemy.EnemyDefense) > 0)
            {
                double LivesMinus = attackStrenght;
                enemy.EnemyLives -= LivesMinus;
            }
            else
            {
                double LivesMinus = attackStrenght/2;
                enemy.EnemyLives -= LivesMinus;
            }
        }
    }
}

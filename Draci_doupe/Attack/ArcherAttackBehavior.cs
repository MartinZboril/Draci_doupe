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
            if (((attackStrenght * 5) - enemy.Defense) > 0)
            {
                double LivesMinus = attackStrenght * 5;
                enemy.Lives -= LivesMinus;
            }
            else
            {
                double LivesMinus = attackStrenght / 2;
                enemy.Lives -= LivesMinus;
            }
        }
    }
}

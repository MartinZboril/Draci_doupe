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
        /// <returns>Síla útoku</returns>
        public double Attack(Enemy enemy, int attackStrenght)
        {
            double LivesMinus = 0;
            if (((attackStrenght * 2) - enemy.Defense) > 0)
            {
                LivesMinus = attackStrenght * 5;
                enemy.Lives -= LivesMinus;
            }
            else
            {
                LivesMinus = (attackStrenght*2) / 2;
                enemy.Lives -= LivesMinus;
            }
            return LivesMinus;
        }
    }
}

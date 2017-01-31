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
        /// <returns>Síla útoku</returns> 
        public double Attack(Enemy enemy, int attackStrenght)
        {
            double LivesMinus = 0;
            if ((attackStrenght - enemy.Defense) > 0)
            {
                LivesMinus = attackStrenght;
                enemy.Lives -= LivesMinus;
            }
            else
            {
                LivesMinus = attackStrenght/2;
                enemy.Lives -= LivesMinus;
            }
            return LivesMinus;
        }
    }
}

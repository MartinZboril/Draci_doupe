using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draci_doupe.Interface;
using Draci_doupe.Attack;

namespace Draci_doupe.Classes 
{
    class Dice
    {
        /// <summary>
        /// Útok nepřítele, tzv. náhodný
        /// </summary>
        /// <param name="enemy">Nepřítel na kterého se útočí</param>
        /// <param name="attack">Síla útoku</param
        /// <returns>Síla útoku</returns>
        public double DiceAttackEnemy(Enemy enemy, int attack)
        {
            double num = 0;
            bool start = GetRandomNumber();
            if (start)
            {          
            int _attackStrenght = attack;
            IAttackBehavior attackBehavior = new DiceAttackBehavior();
            num = attackBehavior.Attack(enemy, _attackStrenght);
            }
            return num;
        }
        
        /// <summary>
        /// Metoda pro získání náhodného čísla, které když se bude rovnat 5, tak se spoustí tzv. speciální útok
        /// </summary>
        /// <returns></returns>
        public bool GetRandomNumber()
        {
            bool start = false;
            Random rnd = new Random();
            int random = rnd.Next(0,11);
            if (random == 5)
            {
                start = true;
            }
            return start;
        }
    }
}

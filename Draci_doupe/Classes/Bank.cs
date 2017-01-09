using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Classes
{
    public class Bank
    {
        public Bank()
        {

        }
        public Bank(string num)
        {
            List<string> money = GetMoneyNum(num);
            GetMoney(money[0]);
        }
        private int _money;
        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }
        /// <summary>
        /// Metoda pro rozdělení stringu, pro získání čísla
        /// </summary>
        /// <param name="name">string pro rozdělení</param>
        /// <returns>Počet peněz</returns>
        List<string> GetMoneyNum(string name)
        {
            List<string> money = name.Split(' ').ToList<string>();
            return money;
        }
        /// <summary>
        /// Metoda pro ziskani info kolik je penez
        /// </summary>
        /// <param name="num">Počet peněz pro přidání</param>
        public void GetMoney(string num)
        {
            int number = int.Parse(num);
            _money += number;
        }
    }
}

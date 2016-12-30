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

        List<string> GetMoneyNum(string name)
        {
            List<string> money = name.Split(' ').ToList<string>();
            return money;
        }
        public void GetMoney(string num)
        {
            int number = int.Parse(num);
            _money += number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    class Person
    {
        public Person()
        {
            _name = "Martin";
            _level = 0;
            _attack = 20;
            _defense = 0;
            _helper = "Neni";
            _helper1 = "Neni";
            _lives = 110;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
        private string _helper;
        public string Helper
        {
            get { return _helper; }
            set { _helper = value; }
        }
        private string _helper1;
        public string Helper1
        {
            get { return _helper1; }
            set { _helper1 = value; }
        }
        private double _lives;
        public double Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }
        private double _defense;
        public double Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }
        private int _attack;
        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }
        private int _experience;
        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }
        /// <summary>
        /// Metoda pro přidání pomocníka
        /// </summary>
        /// <param name="hero">Hrdina pro přidání</param>
        /// <returns>Výsledek přidání</returns>
        public string GetHelper(string hero)
        {
            string Result;
            if (_helper.Equals("Neni"))
            {
                _helper = hero;               
            } else
            {
                _helper1 = hero;
            }
            Result = "1/2";
            return Result;       
        }
        /// <summary>
        /// Metoda pro přidání zkušeností
        /// </summary>
        /// <param name="xp">Počet bodů zkušeností</param>
        public void AddExperience(int xp)
        {
            _experience += xp;
        }
        /// <summary>
        /// Metoda pro zjištění zda-li je spolubojovník průzkumník
        /// </summary>
        /// <param name="helper">Pomocník</param>
        /// <param name="helper1">Pomocník</param>
        /// <returns>T nebo F</returns>
        public bool Scout(string helper, string helper1)
        {
            bool scout = false;
            if (helper.Equals("Průzkumník") || helper1.Equals("Průzkumník"))
            {
                scout = true;
            }
            return scout;
        }
        /// <summary>
        /// Metoda pro zjištění zda-li je spolubojovník léčitel
        /// </summary>
        /// <param name="helper">Pomocník</param>
        /// <param name="helper1">Pomocník</param>
        /// <returns>T nebo F</returns>
        public bool Healer(string helper, string helper1)
        {
            bool healer = false;
            if (helper.Equals("Léčitel") || helper1.Equals("Léčitel"))
            {
                healer = true;
            }
            return healer;
        }
        /// <summary>
        /// Metoda pro zjištění zda-li spolubojovník je šermíř
        /// </summary>
        /// <param name="helper">Pomocník</param>
        /// <param name="helper1">Pomocník</param>
        /// <returns>Hodnotu zda-li skrýt nebo odkrýt tlačítko pro šermíře</returns>
        public System.Windows.Visibility Fighter(string helper, string helper1)
        {
            System.Windows.Visibility text = System.Windows.Visibility.Hidden;
            if (helper.Equals("Šermíř") || helper1.Equals("Šermíř"))
            {
                text = System.Windows.Visibility.Visible;
            }
            return text;
        }
        /// <summary>
        /// Metoda pro zjištění zda-li spolubojovník je lučištník
        /// </summary>
        /// <param name="helper">Pomocník</param>
        /// <param name="helper1">Pomocník</param>
        /// <returns>Hodnotu zda-li skrýt nebo odkrýt tlačítko pro lučištníka</returns>
        public System.Windows.Visibility Archer(string helper, string helper1)
        {
            System.Windows.Visibility text = System.Windows.Visibility.Hidden;
            if (helper.Equals("Lučištník") || helper1.Equals("Lučištník"))
            {
                text = System.Windows.Visibility.Visible;
            }
            return text;
        }
    }
}

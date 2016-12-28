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
            _level = 1;
            _helper = "Neni";
            _helper1 = "Neni";
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
    }
}

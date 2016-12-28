using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public class Inventory
    {
        public Inventory()
        {

        }
        public Inventory(int id, string name)
        {
            _itemid = id;
            _itemname = name;
        }
        private int _itemid;
        public int ItemId
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
        private string _itemname;
        public string ItemName
        {
            get { return _itemname; }
            set { _itemname = value; }
        }
        public string GetItem => ItemName;
    }
}

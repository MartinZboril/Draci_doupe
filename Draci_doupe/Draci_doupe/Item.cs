using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe
{
    public class Item
    {
        List<int> Item_ID = new List<int>();
        List<string> Item_Name = new List<string>();
        public Item()
        {

        }
        public Item(int n)
        {
            Item_ID.Add(0);
            Item_ID.Add(1);
            Item_ID.Add(2);
            Item_ID.Add(3);

            Item_Name.Add("Nic");
            Item_Name.Add("Meč");
            Item_Name.Add("Štít");
            Item_Name.Add("500 kamínku");

            _itemid = Item_ID[n];
            _itemname = Item_Name[n];
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
    }
}

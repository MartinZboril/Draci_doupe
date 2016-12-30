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
        List<string> Item_Type = new List<string>();
        public Item()
        {

        }
        public Item(int n)
        {
            Item_ID.Add(0);
            Item_ID.Add(1);
            Item_ID.Add(2);
            Item_ID.Add(3);
            Item_ID.Add(4);
            Item_ID.Add(5);
            Item_ID.Add(6);

            Item_Name.Add("Nic");
            Item_Name.Add("Meč");
            Item_Name.Add("Štít");
            Item_Name.Add("500 kamínků");
            Item_Name.Add("Kožich");
            Item_Name.Add("Vino");
            Item_Name.Add("Pivo");

            Item_Type.Add("Nic");
            Item_Type.Add("Předmět");
            Item_Type.Add("Předmět");
            Item_Type.Add("Peníze");
            Item_Type.Add("Předmět");
            Item_Type.Add("Pití");
            Item_Type.Add("Pití");

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
        private string _itemtype;
        public string ItemType
        {
            get { return _itemtype; }
            set { _itemtype = value; }
        }
        public List<int> GetItemsId()
        {
            return Item_ID;
        }
        public List<string> GetItemsName()
        {
            return Item_Name;
        }
        public List<string> GetItemsType()
        {
            return Item_Type;
        }
    }
}

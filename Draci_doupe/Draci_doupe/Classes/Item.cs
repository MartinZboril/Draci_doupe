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
        List<int> Item_Price = new List<int>();
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

            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);

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
        private int _itemprice;
        public int ItemPrice
        {
            get { return _itemprice; }
            set { _itemprice = value; }
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
        public List<int> GetItemsPrice()
        {
            return Item_Price;
        }
        public int GetItemId(string item)
        {
            int Id = 0;
            for (int i = 0; i < Item_Name.Count; i++)
            {
                if (item.Equals(Item_Name[i]))
                {
                    Id = Item_ID[i];
                }               
            }
            return Id;
        }
        public int GetItemPrice(string item)
        {
            int Price = 0;
            for (int i = 0; i < Item_Name.Count; i++)
            {
                if (item.Equals(Item_Name[i]))
                {
                    Price = Item_Price[i];
                }
            }
            return Price;
        }
    }
}

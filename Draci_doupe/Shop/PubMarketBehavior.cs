using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draci_doupe.Interface;

namespace Draci_doupe.Shop
{
    public class PubMarketBehavior : IMarketBehavior
    {
        public PubMarketBehavior()
        {

        }
        public PubMarketBehavior(int Id, string Name, string Type, int Price)
        {
            _itemid = Id;
            _itemname = Name;
            _itemtype = Type;
            _itemprice = Price;
        }
        List<int> Item_ID = new List<int>();
        List<string> Item_Name = new List<string>();
        List<int> Item_Price = new List<int>();
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

        public void MarketItems(List<int> Id, List<string> Name, List<string> Type, List<int> Price)
        {
            
            //List<PubMarketBehavior> items = new List<PubMarketBehavior>();
            for (int i = 0; i < Id.Count; i++) {
                if (Type[i].Equals("Pití"))
                {
                    //items.Add(new PubMarketBehavior(Id[i], Name[i], Type[i]));
                    Item_ID.Add(Id[i]);
                    Item_Name.Add(Name[i]);
                    Item_Price.Add(Price[i]);
                }
                
            }
        }
        public List<int> GetID()
        {
            return Item_ID;
        }
        public List<string> GetName()
        {
            return Item_Name;
        }
        public List<int> GetPrice()
        {
            return Item_Price;
        }
    }
}

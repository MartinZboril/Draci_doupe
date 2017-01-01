using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Draci_doupe.Shop;
using Draci_doupe.Interface;

namespace Draci_doupe.Classes
{
    public class Market
    {   

        List<string> Market_type = new List<string>();
        List<int> MarketItemID = new List<int>();
        public List<string> MarketItemName = new List<string>();
        public List<int> MarketItemPrice = new List<int>();
        public Market()
        {

        }
        public Market(int num)
        {
            Market_type.Add("Hospoda");
            Market_type.Add("Obchod");

            _markettype = Market_type[num];
        }

        private string _markettype;
        public string MarketType
        {
            get { return _markettype; }
            set { _markettype = value; }
        }
        public void AddItemToMarket(int number, string item, int price)
        {
            MarketItemID.Add(number);
            MarketItemName.Add(item);
            MarketItemPrice.Add(price);
        }
        public void MarketItems(List<int> Id, List<string> Name, List<string> Type, List<int> Price)
        {
            IMarketBehavior marketBehavior = new PubMarketBehavior();
            marketBehavior.MarketItems(Id, Name, Type, Price);
            List<int> MarketItemId = marketBehavior.GetID();
            List<string> MarketItemName = marketBehavior.GetName();
            List<int> MarketItemPrice = marketBehavior.GetPrice();

            for (int i = 0; i < MarketItemId.Count; i++)
            {
                AddItemToMarket(MarketItemId[i], MarketItemName[i], MarketItemPrice[i]);
            }
        }
    }
}

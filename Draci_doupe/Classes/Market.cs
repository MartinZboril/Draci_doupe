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
            Market_type.Add("Jeskynní lidé");

            _markettype = Market_type[num];
        }

        private string _markettype;
        public string MarketType
        {
            get { return _markettype; }
            set { _markettype = value; }
        }
        /// <summary>
        /// Metoda pro přidání věcí do obchodu
        /// </summary>
        /// <param name="number">ID věci</param>
        /// <param name="item">Název věci</param>
        /// <param name="price">Cena věci</param>
        public void AddItemToMarket(int number, string item, int price)
        {
            MarketItemID.Add(number);
            MarketItemName.Add(item);
            MarketItemPrice.Add(price);
        }
        /// <summary>
        /// Metoda pro získání určitého zboží(věcí) do nabídky marketu
        /// </summary>
        /// <param name="Id">Kolekce ID věcí</param>
        /// <param name="Name">Kolekce názvu věcí</param>
        /// <param name="Type">Kolekce typu věcí</param>
        /// <param name="Price">Kolekce cen věcí</param>
        public void MarketItems(List<int> Id, List<string> Name, List<string> Type, List<int> Price, string MarketType)
        {
            if (MarketType.Equals("Hospoda"))
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
            } else if(MarketType.Equals("Jeskynní lidé"))
            {
                IMarketBehavior marketBehavior = new CavePeopleShop();
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
}

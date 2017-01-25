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
        List<string> Item_BonusType = new List<string>();
        List<int> Item_Bonus = new List<int>();
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
            Item_ID.Add(7);
            Item_ID.Add(8);
            Item_ID.Add(9);
            Item_ID.Add(10);
            Item_ID.Add(11);
            Item_ID.Add(12);
            Item_ID.Add(13);
            Item_ID.Add(14);
            Item_ID.Add(15);
            Item_ID.Add(16);
            Item_ID.Add(17);
            Item_ID.Add(18);
            Item_ID.Add(19);
            Item_ID.Add(20);
            Item_ID.Add(21);
            Item_ID.Add(22);
            Item_ID.Add(23);
            Item_ID.Add(24);

            Item_Name.Add("Nic");
            Item_Name.Add("Meč +20 síly útoku");
            Item_Name.Add("Štít +10 obrany");
            Item_Name.Add("250 kamínků");
            Item_Name.Add("Kožich +20 obrany");
            Item_Name.Add("Vino +30 životů");
            Item_Name.Add("Pivo +10 životů");
            Item_Name.Add("Maso +40 životů");
            Item_Name.Add("Meč velitele +15 síly útoku");
            Item_Name.Add("Náhrdelník síly +10 síly útoku");
            Item_Name.Add("Náhrdelník obrany +10 obrany");
            Item_Name.Add("Štít +20 obrany");
            Item_Name.Add("Pytel s jídlem +45 životů");
            Item_Name.Add("Kapitánův kloubouk +15 obrany");
            Item_Name.Add("Meč zlého bojovníka +25 síly útoku");
            Item_Name.Add("Štít ze slonoviny +10 obrany");
            Item_Name.Add("Chrániče nohou +10 obrany");
            Item_Name.Add("Elixír síly +15 síly útoku");
            Item_Name.Add("Elixír obrany +20 obrany");
            Item_Name.Add("Helma ze železa +25 obrany");
            Item_Name.Add("Helma ze slonoviny +20 obrany");
            Item_Name.Add("Meč hrdlořezů +30 útoku");
            Item_Name.Add("Brnění ze slonoviny +25 obrany");
            Item_Name.Add("Balíček jídla +10 životů");
            Item_Name.Add("Kůže +10 obrany");

            Item_Type.Add("Nic");
            Item_Type.Add("Předmět");
            Item_Type.Add("Předmět");
            Item_Type.Add("Peníze");
            Item_Type.Add("Předmět");
            Item_Type.Add("Pití");
            Item_Type.Add("Pití");
            Item_Type.Add("Jídlo");
            Item_Type.Add("Bonus");
            Item_Type.Add("Jeskynní předměty");
            Item_Type.Add("Jeskynní předměty");
            Item_Type.Add("Jeskynní předměty");
            Item_Type.Add("Bonus");
            Item_Type.Add("Bonus");
            Item_Type.Add("Bonus");
            Item_Type.Add("Bonus");
            Item_Type.Add("Předměty domorodců");
            Item_Type.Add("Předměty domorodců");
            Item_Type.Add("Předměty domorodců");
            Item_Type.Add("Předměty domorodců");
            Item_Type.Add("Předměty Egypta");
            Item_Type.Add("Předměty Egypta");
            Item_Type.Add("Předměty Egypta");
            Item_Type.Add("Předměty Egypta");
            Item_Type.Add("Předmět");

            Item_BonusType.Add("Nic");
            Item_BonusType.Add("Útok");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Nic");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Životy");
            Item_BonusType.Add("Životy");
            Item_BonusType.Add("Životy");
            Item_BonusType.Add("Útok");
            Item_BonusType.Add("Útok");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Životy");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Útok");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Útok");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Útok");
            Item_BonusType.Add("Obrana");
            Item_BonusType.Add("Životy");
            Item_BonusType.Add("Obrana");

            Item_Bonus.Add(0);
            Item_Bonus.Add(20);
            Item_Bonus.Add(10);
            Item_Bonus.Add(0);
            Item_Bonus.Add(20);
            Item_Bonus.Add(30);
            Item_Bonus.Add(10);
            Item_Bonus.Add(40);
            Item_Bonus.Add(15);
            Item_Bonus.Add(10);
            Item_Bonus.Add(10);
            Item_Bonus.Add(20);
            Item_Bonus.Add(45);
            Item_Bonus.Add(15);
            Item_Bonus.Add(25);
            Item_Bonus.Add(10);
            Item_Bonus.Add(10);
            Item_Bonus.Add(15);
            Item_Bonus.Add(20);
            Item_Bonus.Add(25);
            Item_Bonus.Add(20);
            Item_Bonus.Add(30);
            Item_Bonus.Add(25);
            Item_Bonus.Add(10);
            Item_Bonus.Add(10);

            Item_Price.Add(0);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(0);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(80);
            Item_Price.Add(0);
            Item_Price.Add(0);
            Item_Price.Add(0);
            Item_Price.Add(0);
            Item_Price.Add(55);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(70);
            Item_Price.Add(50);
            Item_Price.Add(75);
            Item_Price.Add(45);
            Item_Price.Add(30);
            Item_Price.Add(0);

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
        /// <summary>
        /// Metoda pro získání ID věci
        /// </summary>
        /// <returns>ID věcí</returns>
        public List<int> GetItemsId()
        {
            return Item_ID;
        }
        /// <summary>
        /// Metoda pro získání jmen věci
        /// </summary>
        /// <returns>Jména věcí</returns>
        public List<string> GetItemsName()
        {
            return Item_Name;
        }
        /// <summary>
        /// Metoda pro získání druhu věci
        /// </summary>
        /// <returns>Typ věcí</returns>
        public List<string> GetItemsType()
        {
            return Item_Type;
        }
        /// <summary>
        /// Metoda pro získání ceny věci
        /// </summary>
        /// <returns>Cenu věcí</returns>
        public List<int> GetItemsPrice()
        {
            return Item_Price;
        }
        /// <summary>
        /// Metoda pro získání ID věci
        /// </summary>
        /// <param name="item">Název věci</param>
        /// <returns>ID věci</returns>
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
        /// <summary>
        /// Metoda pro získání ceny věci
        /// </summary>
        /// <param name="item">Název věci</param>
        /// <returns>Cenu věci</returns>
        public int GetItemPrice(string item, int money)
        {
            int Price = 0;
            for (int i = 0; i < Item_Name.Count; i++)
            {
                if (item.Equals(Item_Name[i]))
                 {
                    if (money >= Item_Price[i])
                    {
                        Price = Item_Price[i];
                    }
                }
            }
            return Price;
        }
        /// <summary>
        /// Metoda pro získání bonusu věci
        /// </summary>
        /// <param name="item">Název věci</param>
        /// <returns>Bonus věci</returns>
        public int GetItemBonus(int item)
        {
            int Bonus = 0;
            for (int i = 0; i < Item_ID.Count; i++)
            {
                if (item.Equals(Item_ID[i]))
                {
                    Bonus = Item_Bonus[i];
                }
            }
            return Bonus;
        }
        /// <summary>
        /// Metoda pro získání typu bonusu věci
        /// </summary>
        /// <param name="item">Název věci</param>
        /// <returns>Typ bonusu věci</returns>
        public string GetItemBonusType(int item)
        {
            string BonusType = "";
            for (int i = 0; i < Item_ID.Count; i++)
            {
                if (item.Equals(Item_ID[i]))
                {
                    BonusType = Item_BonusType[i];
                }
            }
            return BonusType;
        }
    }
}

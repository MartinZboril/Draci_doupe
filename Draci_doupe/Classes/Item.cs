﻿using System;
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

            Item_Name.Add("Nic");
            Item_Name.Add("Meč - 20 síly útoku");
            Item_Name.Add("Štít - 10 obrany");
            Item_Name.Add("500 kamínků");
            Item_Name.Add("Kožich - 20 obrany");
            Item_Name.Add("Vino - 30 životů");
            Item_Name.Add("Pivo - 10 životů");
            Item_Name.Add("Maso - 40 životů");
            Item_Name.Add("Meč velitele - 40 síly útoku");
            Item_Name.Add("Náhrdelník síly - 40 síly útoku");
            Item_Name.Add("Náhrdelník obrany - 40 obrany");
            Item_Name.Add("Štít - 50 síly útoku");

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
            Item_BonusType.Add("Útok");
            Item_BonusType.Add("Obrana");

            Item_Bonus.Add(0);
            Item_Bonus.Add(20);
            Item_Bonus.Add(10);
            Item_Bonus.Add(0);
            Item_Bonus.Add(20);
            Item_Bonus.Add(30);
            Item_Bonus.Add(10);
            Item_Bonus.Add(40);
            Item_Bonus.Add(40);
            Item_Bonus.Add(40);
            Item_Bonus.Add(40);
            Item_Bonus.Add(50);

            Item_Price.Add(0);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(50);
            Item_Price.Add(0);
            Item_Price.Add(20);
            Item_Price.Add(20);
            Item_Price.Add(30);

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
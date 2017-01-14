using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Draci_doupe
{
    public class Inventory
    {
        List<int> itemid = new List<int>();
        List<string> itemname = new List<string>();
        public Inventory()
        {

        }
        /// <summary>
        /// Metoda pro přidání itemu do inventáře
        /// </summary>
        /// <param name="id">ID věci</param>
        /// <param name="item">Název věci</param>
        public void AddItem(int id, string item)
        {

            itemid.Add(id);
            itemname.Add(item);
        }
        /// <summary>
        /// Metoda pro přidání itemu do inventáře při nákupu
        /// </summary>
        /// <param name="id">ID věci</param>
        /// <param name="item">Název věci</param>
        /// <param name="money">Peníze</param>
        /// <param name="price">Cena věci</param>
        public void AddItemMarket(int id, string item, int money, int price)
        {
            if (money >= price)
            {
                    itemid.Add(id);
                    itemname.Add(item);
            }

        }
        /// <summary>
        /// Metoda pro získání kolekce se jmény věcí v inventáři
        /// </summary>
        /// <returns>Kolekce jmen věcí</returns>
        public List<string> GetCollection()
        {
            return itemname;
        }
        /// <summary>
        /// Metoda pro získání kolekce ID věcí
        /// </summary>
        /// <returns>Kolekce ID věcí</returns>
        public List<int> GetCollectionID()
        {
            return itemid;
        }

        public void Remove(int id)
        {
            string name = "";
            for (int i = 0; i < itemid.Count(); i++)
            {
                if (id == itemid[i])
                {
                    name = itemname[i];
                }
            }

            itemid.Remove(id);
            itemname.Remove(name);
        }
    }
}

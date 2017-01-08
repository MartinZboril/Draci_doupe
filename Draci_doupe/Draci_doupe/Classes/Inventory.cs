using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

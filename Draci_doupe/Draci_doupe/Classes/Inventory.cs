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
        public void AddItem(int id, string item)
        {
            itemid.Add(id);
            itemname.Add(item);
        }
        public List<string> GetCollection()
        {
            return itemname;
        }
    }
}

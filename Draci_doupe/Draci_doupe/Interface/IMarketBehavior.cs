using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Interface
{
    interface IMarketBehavior
    {
        int ItemId { get; set; }
        string ItemName { get; set; }
        string ItemType { get; set; }

        void MarketItems(List<int> Id, List<string> Name, List<string> Type);
        List<int> GetID();
        List<string> GetName();
    }
}

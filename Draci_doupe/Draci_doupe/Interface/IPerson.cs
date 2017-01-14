using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Interface
{
    interface IPerson
    {
        int ID { get; set; }
        string Name { get; set; }
        double Defense { get; set; }
        double Lives { get; set; }
        int Attack { get; set; }
    }
}

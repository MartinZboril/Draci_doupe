using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draci_doupe.Interface
{
    interface IProgressBarValue
    {
        int Maximum { get; set; }
        int Minimum { get; set; }
        int Progress { get; set; }
    }
}

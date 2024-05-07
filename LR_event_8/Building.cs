using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_event_8
{
    public abstract class Building
    {
        public string Heating { get; set; }
        public abstract void TurnOnHeating();
    }
}

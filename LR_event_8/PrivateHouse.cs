using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_event_8
{
    internal class PrivateHouse : Building
    {

        public override void TurnOnHeating()
        {
            Heating = "Boiler is working";
        }
    }
}

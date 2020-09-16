using BrokeProtocol.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace DamageTriggers
{
    public class Plugin : BrokeProtocol.API.Plugin // Notice the Plugin here
    {
        public Plugin()
        {
            Info = new PluginInfo("DamageTriggers", "yes");
        }
    }
}





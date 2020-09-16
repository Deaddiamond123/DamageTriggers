using BrokeProtocol.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary4
{
    public class Plugin : BrokeProtocol.API.Plugin // Notice the Plugin here
    {
        public Plugin()
        {
            Info = new PluginInfo("ExamplePlugin", "er");
        }
    }
}





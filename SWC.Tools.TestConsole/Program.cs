﻿using System.Linq;
using SWC.Tools.Common.Layout;
using SWC.Tools.Common.Networking;
using SWC.Tools.Common.Networking.Json.CommandArgs;
using SWC.Tools.Common.Configuration;

namespace SWC.Tools.TestConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var mgr = new MessageManager(ConfigKeys.AndroidServerUrl);

        }
    }
}
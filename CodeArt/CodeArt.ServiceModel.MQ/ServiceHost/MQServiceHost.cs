using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.IO;
using System.Text;

using CodeArt;
using CodeArt.DTO;
using CodeArt.Log;
using CodeArt.Concurrent;
using CodeArt.EasyMQ.RPC;
using CodeArt.AppSetting;
using CodeArt.Util;

namespace CodeArt.ServiceModel
{
    public static class MQServiceHost
    {
        internal static bool IsEnabled
        {
            get;
            set;
        }


        public static void Start(Action initialize = null, bool autoClose = true)
        {
            IsEnabled = false;

            RPCEvents.ServerOpened += OnServerOpened;
            RPCEvents.ServerError += OnServerError;
            RPCEvents.ServerClosed += OnServerClosed;

            AppInitializer.Initialize();

            if (initialize != null)
                initialize();

            AppInitializer.Initialized();

            if (autoClose) Console.WriteLine(MQ.Strings.CloseServiceHost);

            IsEnabled = true;

            if (autoClose)
            {
                Console.ReadLine();
                Stop();
            }
        }


        public static void StartOnly(Action initialize = null)
        {
            Start(initialize, false);
        }

        public static void Stop()
        {
            AppInitializer.Cleanup();
            IsEnabled = false;
        }

        private static void OnServerError(object sender, RPCEvents.ServerErrorArgs arg)
        {
            Console.WriteLine(arg.Exception.GetCompleteMessage());
        }

        private static void OnServerOpened(object sender, RPCEvents.ServerOpenedArgs arg)
        {
            Console.WriteLine(string.Format(MQ.Strings.ServiceIsOpen, arg.MethodName));
        }

        private static void OnServerClosed(object sender, RPCEvents.ServerClosedArgs arg)
        {
            Console.WriteLine(string.Format(MQ.Strings.ServiceIsClose, arg.MethodName));
        }

    }
}

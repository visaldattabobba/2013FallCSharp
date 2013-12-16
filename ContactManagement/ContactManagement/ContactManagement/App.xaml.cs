using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace ContactManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //private static StoreDB storeDB = new StoreDB();
        //public static StoreDB StoreDB { get { return storeDB; } }
        private static Store_Entity  storeEntity = new Store_Entity();
        public static Store_Entity StoreEntity { get { return storeEntity; } }
        internal static Messenger Messenger
        {
            get { return _messenger; }
        }

        readonly static Messenger _messenger = new Messenger();

        // }
    }
}

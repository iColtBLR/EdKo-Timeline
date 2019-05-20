﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EdKo.TimeLine
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // The boostrapper will create the Shell instance, so the App.xaml does not have a StartupUri.
            TimeLineBootstraper bootstrapper = new TimeLineBootstraper();
            bootstrapper.Run();
        }
    }
}

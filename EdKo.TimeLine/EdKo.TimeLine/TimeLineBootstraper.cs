using Microsoft.Practices.ServiceLocation;
using Prism.Modularity;
using Prism.Unity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimeLine.Infrastucture.Modularity;

namespace EdKo.TimeLine
{
    public class TimeLineBootstraper : UnityBootstrapper
    {
        protected IModuleCatalog _catalog;

        protected override IModuleCatalog CreateModuleCatalog()
        {
            _catalog = new TimeLineModuleCatalog();
            return _catalog;
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();
            Container.RegisterInstance(_catalog, new ContainerControlledLifetimeManager());
        }

        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }
        //kek
        //protected override void InitializeShell()
        //{
        //   // base.InitializeShell();

        //    Application.Current.MainWindow = (Window)this.Shell;
        //    Application.Current.MainWindow.Show();
        //}
    }
}

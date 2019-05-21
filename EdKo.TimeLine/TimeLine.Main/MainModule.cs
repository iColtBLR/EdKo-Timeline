using Prism.Modularity;
using Microsoft.Practices.Unity;
using TimeLine.Infrastucture;
using TimeLine.Main.Views.Main;
using TimeLine.Main.Views.Navigation;

namespace TimeLine.Main
{
    [Module(ModuleName = ModuleNameLinks.MainModule)]
    public class MainModule : ModuleBase
    {
        public override void Initialize()
        {
            ConfigureContainers();
            ConfigureServices();
	        ShowNavigationMenu();
			ShowMainView();
        }

        public void ConfigureContainers()
        {
            Container.RegisterType<MainViewModel>();
            Container.RegisterType<IMainView, MainView>();

	        Container.RegisterType<NavigationViewModel>();
	        Container.RegisterType<INavigationView, NavigationView>();
		}

        public void ConfigureServices()
        {

        }

        //TODO: Navigation
        public void ShowMainView()
        {

            //var region = RegionManager.Regions[RegionNameLink.LeftRegion];
            //var view = Container.Resolve<MainView>();
            //region.Add(view, "MainView");
            //view.ViewModel.Initialize();

            //region.Activate(view);
            var view = Container.Resolve<IMainView>();
            RegionManager.RegisterViewWithRegion(RegionNameLink.MainRegion, () => view);
        }

		public void ShowNavigationMenu() {
			var view = Container.Resolve<INavigationView>();
			RegionManager.RegisterViewWithRegion(RegionNameLink.HeaderRegion, () => view);
		}
	}
}
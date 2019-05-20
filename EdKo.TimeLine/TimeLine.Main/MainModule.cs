using Prism.Modularity;
using Microsoft.Practices.Unity;
using TimeLine.Infrastucture;
using TimeLine.Main.Views.Main;

namespace TimeLine.Main
{
    [Module(ModuleName = ModuleNameLinks.MainModule)]
    public class MainModule : ModuleBase
    {
        public override void Initialize()
        {
            ConfigureContainers();
            ConfigureServices();
            ShowMainView();
        }

        public void ConfigureContainers()
        {
            Container.RegisterType<MainViewModel>();
            Container.RegisterType<IMainView, MainView>();
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
            var view = Container.Resolve<MainView>();
            RegionManager.RegisterViewWithRegion(RegionNameLink.LeftRegion, () => view);
        }
    }
}
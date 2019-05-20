using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace TimeLine.Infrastucture
{
    public abstract class ModuleBase : IModule
    {
        [Dependency]
        public IUnityContainer Container
        {
            get; set;
        }

        [Dependency]
        public IRegionManager RegionManager
        {
            get; set;
        }

        public abstract void Initialize();

    }
}

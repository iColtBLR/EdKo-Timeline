using Prism.Modularity;
using TimeLine.Infrastucture;

namespace TimeLine.Board
{
    [Module(ModuleName = ModuleNameLinks.BoardModule)]
    public class BoardModule : ModuleBase
    {
        public override void Initialize()
        {
            ConfigureContainers();
            ConfigureServices();
        }

        public void ConfigureContainers()
        {
            // Container.RegisterType<>();
        }

        public void ConfigureServices()
        {

        }
    }
}

using Prism.Events;
using TimeLine.Infrastucture.ViewComponents;

namespace TimeLine.Main.Views.Main
{
    public class MainViewModel : ViewModelBase
    {
        private IEventAggregator _aggregator;

        public MainViewModel(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public void Initialize()
        {

        }
    }
}

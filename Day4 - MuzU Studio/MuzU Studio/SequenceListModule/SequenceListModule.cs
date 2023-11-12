using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SequenceList.Views;

namespace SequenceList;

public class SequenceListModule : IModule
{

    public void OnInitialized(IContainerProvider containerProvider)
    {
        var regionManager = containerProvider.Resolve<IRegionManager>();
        regionManager.RegisterViewWithRegion("SequenceListRegion", typeof(SequenceListView));
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        
    }
}
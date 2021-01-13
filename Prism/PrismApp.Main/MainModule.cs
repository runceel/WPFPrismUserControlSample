using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismApp.Main.ViewModels;
using PrismApp.Main.Views;

namespace PrismApp.Main
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
        }
    }
}
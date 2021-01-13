using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace PrismApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly IRegionManager _regionManager;

        private DelegateCommand _addCommand;

        public DelegateCommand AddCommand =>
            _addCommand ?? (_addCommand = new DelegateCommand(ExecuteAddCommand));

        private Random Random { get; } = new Random();
        private void ExecuteAddCommand()
        {
            _regionManager.RequestNavigate("ContentRegion", "ViewA", new NavigationParameters
            {
                { "x", Random.Next(500) },
                { "y", Random.Next(500) },
                { "message", DateTime.Now.ToString() },
            });
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
    }
}

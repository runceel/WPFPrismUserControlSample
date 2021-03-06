﻿using Prism.Mvvm;
using Prism.Regions;
using System.Diagnostics;

namespace PrismApp.Main.ViewModels
{
    public class ViewAViewModel : BindableBase, INavigationAware
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private int _x;
        public int X
        {
            get { return _x; }
            set { SetProperty(ref _x, value); }
        }

        private int _y;
        public int Y
        {
            get { return _y; }
            set { SetProperty(ref _y, value); }
        }

        public ViewAViewModel()
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // パラメーターから表示位置や表示する内容を取得してプロパティに保持
            if (navigationContext.Parameters.TryGetValue<int>("x", out var x))
            {
                X = x;
            }

            if (navigationContext.Parameters.TryGetValue<int>("y", out var y))
            {
                Y = y;
            }

            if (navigationContext.Parameters.TryGetValue<string>("message", out var message))
            {
                Message = message;
            }
        }

        // ここで true を返すとナビゲーション時に View が再利用されるので断固拒否
        public bool IsNavigationTarget(NavigationContext navigationContext) => false;

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}

using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;

namespace PureWpf
{
    public class MainWindowViewModel : BindableBase
    {

        public ObservableCollection<Item> Items { get; } = new();

        private DelegateCommand _addCommand;
        public DelegateCommand AddCommand => _addCommand ??= new(AddExecute);

        // 表示位置をランダムにするための Random クラス
        private Random Random { get; } = new();
        private void AddExecute() =>
            // ランダムな位置に、とりあえず現在時間の文字列を出すようなデータを作る
            Items.Add(new(Random.Next(500), Random.Next(500), DateTime.Now.ToString()));
    }
}

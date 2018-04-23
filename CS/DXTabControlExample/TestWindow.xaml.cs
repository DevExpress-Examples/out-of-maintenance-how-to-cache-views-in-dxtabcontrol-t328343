using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DXTabControlExample
{
    /// <summary>
    /// Interaction logic for TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow(TabContentCacheMode tabCacheMode)
        {
            InitializeComponent();
            tabControl.TabContentCacheMode = tabCacheMode;
            ObservableCollection<Item> items = new ObservableCollection<Item>();
            for (int i = 0; i < 15; i++)
            {
                items.Add(new Item() { Name = "Item" + i });
            }
            tabControl.ItemsSource = items;
        }
    }

    public class Item
    {
        public string Name
        {
            get;
            set;
        }
    }
}

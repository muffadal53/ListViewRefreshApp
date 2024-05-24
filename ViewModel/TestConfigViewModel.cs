using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using ListViewRefreshApp.Models;
using Microsoft.Maui.Controls;


namespace ListViewRefreshApp.ViewModel
{
    public class TestConfigViewModel : ObservableObject
    {
        private ObservableCollection<TestConfigModel> mytestconfiglist = new ObservableCollection<TestConfigModel>();

        public ObservableCollection<TestConfigModel> TestConfigList
        {
            get { return mytestconfiglist; }
            set { mytestconfiglist = value; }
        }

        public bool ListRefreshing { get; set; }

        public ICommand RefreshCommand { get; set; }

        public TestConfigViewModel()
        {
            LoadFromSource();
            ListRefreshing = false;
            RefreshCommand = new Command(RefreshListItems);
        }

        private void RefreshListItems()
        {            
            try
            {
                TestConfigList.Clear();
                ReloadFromSource();
            }
            finally
            {
                ListRefreshing = false;
            }

        }

        public void LoadFromSource()
        {
            for (int i = 1; i <= 50; i++)
            {
                TestConfigList.Add(new TestConfigModel() { Name = "Item" + i.ToString() });
            }
        }

        public void ReloadFromSource()
        {
            for (int i = 1; i <= 100; i++)
            {
                TestConfigList.Add(new TestConfigModel() { Name = "Item" + i.ToString() });
            }
        }
    }
}

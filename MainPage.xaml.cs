using ListViewRefreshApp.ViewModel;

namespace ListViewRefreshApp
{
    public partial class MainPage : ContentPage
    {        
        private readonly TestConfigViewModel _viewModel;

        public MainPage()
        {
            _viewModel = new TestConfigViewModel();
            this.BindingContext = _viewModel;
            InitializeComponent();
        }       
    }
}

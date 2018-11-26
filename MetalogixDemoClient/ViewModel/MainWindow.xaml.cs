using System.Windows;
using MetalogixDemoClient.ViewModel;

namespace MetalogixDemoClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void cbCompanyType_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

         //;
         //   cbCompanyType.DataContext = ViewModelLocator.GetMain;
         
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            var vm = (MainViewModel)DataContext;
            vm.ShowDetailsCommand.Execute(txtCompanyId.Text+"|"+txtCountryCode.Text);
        }
    }
}
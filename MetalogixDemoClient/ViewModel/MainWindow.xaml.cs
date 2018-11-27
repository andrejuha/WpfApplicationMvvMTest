using System.Windows;
using MetalogixDemoClient.ViewModel;
using MetalogixDemoClient.Model;

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
            int companyIdInt;
            int countryCodeInt;
            var vm = (MainViewModel)DataContext;

           
            int.TryParse(txtCompanyId.Text,out companyIdInt);
            int.TryParse(txtCompanyId.Text, out countryCodeInt);
            FindParams findParams = new FindParams() { CompanyId = companyIdInt, CountryCode = countryCodeInt };
            vm.FindCompanyCommand.Execute(findParams);
        }

        private void txtCompanyId_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            //if (txtCompanyId.Text == "Enter Text")
            //    txtCompanyId.Text = "";
        }

        private void txtCompanyId_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //if (txtCompanyId.Text == "Enter Text")
            //    txtCompanyId.Text = "";
        }
    }
}
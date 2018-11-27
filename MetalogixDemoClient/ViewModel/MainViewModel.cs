using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MetalogixDemoClient.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MetalogixDemoClient.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase 
    {
        private readonly IDataService _dataService;

        private ObservableCollection<CompanyTypeItem> _combodata;
        public ObservableCollection<CompanyTypeItem> comboData
        {
            get
           {
                if (_combodata == null)
                    _combodata = new ObservableCollection<CompanyTypeItem>();
                //else
                //    RefreshComboCommand();
                _combodata.Add(new CompanyTypeItem() { Name = "sss", Description = "ddd" });
                

                return _combodata;
            }
            set
           {
                if (value != _combodata)
                    _combodata = value;
            }
        }

        private ObservableCollection<CompanyItem> _companyItemData;
        public ObservableCollection<CompanyItem> CompanyItemData
        {
            get
            {
                if (_companyItemData == null)
                    _companyItemData = new ObservableCollection<CompanyItem>();
                //else
                //    RefreshComboCommand();
                _companyItemData.Add(new CompanyItem() { Name = "testcompany", CompanyTypeEnum= CompanyTypeEnum.Industry, ContryCode=100, Id=1 });


                return _companyItemData;
            }
            set
            {
                if (value != _companyItemData)
                    _companyItemData = value;
            }
        }


        private RelayCommand _refreshComboCommand;

        public RelayCommand RefreshComboCommand
        {
            get
            {
                return _refreshComboCommand
                    ?? (_refreshComboCommand = new RelayCommand(
                                          async () =>
                                          {
                                              await GetAllType();
                                          }));
            }
        }

         private RelayCommand<FindParams> _findCompanyCommand;

        public RelayCommand<FindParams> FindCompanyCommand
        {
            get
            {
                return _findCompanyCommand
                    ?? (_findCompanyCommand = new RelayCommand<FindParams>(
                                          async fparams =>
                                          {
                                              await GetAllCompanies(); ;
                                          }));
            }
        }

        private async Task GetAllType()
        {
            _combodata.Clear();

            var friends = await _dataService.GetAllTypeData();

            foreach (var friend in friends)
            {
                comboData.Add(friend);
            }
        }

        private async Task GetAllCompanies()
        {
            _combodata.Clear();

            var friends = await _dataService.GetAllCompanies();

            foreach (var friend in friends)
            {
                _companyItemData.Add(friend);
            }
        }

        /// <summary>
        /// The <see cref="CompanyIdInput" /> property's name.
        /// </summary>
        public const string CompanyIdInpuePropertyName = "CompanyIdInput";

        private string _companyIdInput = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string CompanyIdInput
        {
            get
            {
                return _companyIdInput;
            }
            set
            {
                Set(ref _companyIdInput, value);
            }
        }

        /// <summary>
        /// The <see cref="CountryCodeInput" /> property's name.
        /// </summary>
        public const string CountryCodeInputPropertyName = "CountryCodeInput";

        private string _countryCodeInput = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string CountryCodeInput
        {
            get
            {
                return _countryCodeInput;
            }
            set
            {
                Set(ref _countryCodeInput, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                   
                    //comboData =CompanyTypeEnum.GetValues(typeof(CompanyTypeEnum)).;
                    //WelcomeTitle = item.Title;
                });
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //je v base
        //public virtual void RaisePropertyChanged(string propertyName)
        //{
        //    var handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

            ////public override void Cleanup()
            ////{
            ////    // Clean up if needed

            ////    base.Cleanup();
            ////}
        }
    }
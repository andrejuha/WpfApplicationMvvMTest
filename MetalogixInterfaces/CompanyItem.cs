using System;
using MetalogixDemoService;
using System.ComponentModel;

namespace MetalogixDemoClient.Model
{
    public class CompanyItem : INotifyPropertyChanged
    {
        public CompanyItem()
        {

        }
        public CompanyItem(int Id, string Name, int CountryCode, CompanyTypeEnum CompanyType)
        {
            this.Id = Id;
            this.Name = Name;
            this.ContryCode = ContryCode;
            this.CompanyTypeEnum = CompanyType;
        }
      
        

        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                if (_Name == value)
                {
                    return;
                }

                _Name = value;
                RaisePropertyChanged("Name");
            }
        }

        private int _Id;
        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                if (_Id == value)
                {
                    return;
                }

                _Id = value;
                RaisePropertyChanged("Id");
            }
        }

        private int _countryCode;

        public int ContryCode
        {
            get
            {
                return _countryCode;
            }

            set
            {
                if (_countryCode == value)
                {
                    return;
                }

                _countryCode = value;
                RaisePropertyChanged("ContryCode");
            }
        }
       
        public CompanyTypeEnum CompanyTypeEnum { get; set; }

        public CompanyTypeItem CompanyTypeItem { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler!=null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        //int ICompanyItem.CompanyTypeEnum
        //{
        //    get
        //    {
        //        return (int)CompanyTypeEnum;
        //    }

        //    set
        //    {
        //        CompanyTypeEnum=(CompanyTypeEnum)value;
        //    }
        //}

        //ICompanyTypeItem ICompanyItem.CompanyTypeItem
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }

        //    set
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //int ICompanyItem.ContryCode
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //int ICompanyItem.Id
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //string ICompanyItem.Name
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }



    public enum CompanyTypeEnum
    {
        Industry=0,
        Navy=1,
        Telco=2,
        Other=3


    }
}
using FranceVacancies.Common;
using FV10112018.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FV10112018.ViewModel
{
    class CityViewModel : INotifyPropertyChanged
    {
       // private ObservableCollection<FrCity> _cities;
       // private ObservableCollection<Apartment> _apr;
        //private ObservableCollection<Apartment> _apr1;
        private FrCity _selectedFrCity;
        public AparCatalogSingle AparCatalogSingle { get; set; }

   //     private ICommand _selectedCityCommand;
    //    private ICommand _citySelectCommand;

        //public ICommand SelectedCityCommand
        //{
        //    get
        //    {
        //        if (_selectedCityCommand == null)
        //            _selectedCityCommand = new RelayArgCommand<FrCity>(SetSelectedFrCity);
        //        return _selectedCityCommand;
        //    }
        //    set
        //    {
        //        _selectedCityCommand = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public ICommand CitySelectedCommand
        //{
        //    get { return _citySelectCommand; } // ?? (_citySelectCommand = new RelayCommand(KeepSelectedCity)); }
        //    set
        //    {
        //        _selectedCityCommand = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public void KeepSelectedCity()
        //{
        //    int i = 0;
        //}

        public void SetSelectedFrCity(FrCity ev)
        {
            AparCatalogSingle.SetSelectedCity(ev);
            //  Aprs1 = new Apartment().AprByName(SelectedFrCity.Name); //Jamshid commented out 08/11
        }


        public FrCity SelectedFrCity
        {
            get { return _selectedFrCity; }
            set
            {
                _selectedFrCity = value;
                SetSelectedFrCity(_selectedFrCity);
                OnPropertyChanged("SelectedFrCity");

            }
        }
        //public ObservableCollection<FrCity> Cities
        //{
        //    get { return _cities; }
        //    set { _cities = value; }

        //}
        //public ObservableCollection<Apartment> Aprs
        //{
        //    get { return _apr; }
        //    set { _apr = value; }

        //}

        //public ObservableCollection<Apartment> Aprs1
        //{
        //    get { return _apr; }
        //    set { _apr = value; }

        //}

        public CityViewModel()
        {
            AparCatalogSingle = AparCatalogSingle.Instance;

           // Cities = new ObservableCollection<FrCity>(AparCatalogSingle.Apartments.);
          //  Aprs = new ObservableCollection<Apartment>(Apartment.Apartments());
            //  Aprs1 = new Apartment().AprByName(SelectedFrCity.Name);
      //      SelectedFrCity = Cities[0];
     //       CitySelectedCommand = new RelayCommand(KeepSelectedCity);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

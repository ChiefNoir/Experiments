using DataModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System;
using Contracts;

namespace GkMic.ViewModel
{
    public class PassportViewModel : ViewModelBase
    {
        public Passport Passport { get; set; }
        public ICommand SaveCommand { get; set; }

        private IDataService _dataSevice;

        public PassportViewModel(IDataService dataSevice)
        {
            Passport = new Passport();
            _dataSevice = dataSevice;
            SaveCommand = new RelayCommand(Save);            
        }

        private void Save()
        {
            _dataSevice.Save(Passport, (error) =>
            {
                if (error != null)
                {
                    // Report error here
                    return;
                }
            });
        }
    }
}

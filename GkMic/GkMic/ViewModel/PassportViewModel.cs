using DataModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System;

namespace GkMic.ViewModel
{
    public class PassportViewModel : ViewModelBase
    {
        public Passport Passport { get; set; }

        public ICommand SaveCommand { get; set; }        

        public PassportViewModel()
        {
            Passport = new Passport();
            SaveCommand = new RelayCommand(Save);            
        }

        private void Save()
        {
            throw new NotImplementedException();
        }
    }
}

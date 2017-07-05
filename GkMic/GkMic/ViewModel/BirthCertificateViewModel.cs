using DataModel;
using Contracts;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System;

namespace GkMic.ViewModel
{
    public class BirthCertificateViewModel : ViewModelBase
    {
        public BirthCertificate BirthCertificate { get; set; }

        public ICommand SaveCommand { get; set; }        

        public BirthCertificateViewModel()
        {
            BirthCertificate = new BirthCertificate();
            SaveCommand = new RelayCommand(Save);
        }

        private void Save()
        {
            throw new NotImplementedException();
        }
    }
}

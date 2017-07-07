using GalaSoft.MvvmLight;
using GkMic.Common;
using GkMic.View;
using System;
using System.Windows;

namespace GkMic.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private DocumentType _selectedDocumentType;
        public DocumentType SelectedDocumentType
        {
            get
            {
                return _selectedDocumentType;
            }
            set
            {
                Set(ref _selectedDocumentType, value);
                SwitchView(value);
            }
        }

        private FrameworkElement _contentControlView;
        public FrameworkElement ContentControlView
        {
            get { return _contentControlView; }
            set
            {
                Set(ref _contentControlView, value);                
            }
        }

        public MainViewModel()
        {
            SelectedDocumentType = DocumentType.Passport;
        }

        private void SwitchView(DocumentType doctype)
        {
            switch (doctype)
            {
                case DocumentType.BirthCertificate:
                    ContentControlView = new BirthCertificateView();
                    break;
                case DocumentType.Passport:
                    ContentControlView = new PassportView();
                    break;
                default:
                    throw new Exception($"{doctype} is unknown DocumentType.");
            }            
        }
    }
}
using GalaSoft.MvvmLight;
using GkMic.Common;

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
            }
        }
        
        public MainViewModel()
        {
            SelectedDocumentType = DocumentType.Passport;
        }
    }
}
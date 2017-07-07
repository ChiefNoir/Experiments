using GkMic.Common;
using GkMic.Properties;
using System;
using System.Globalization;
using System.Windows.Data;

namespace GkMic.Converters
{
    class DocumentTypeToLocalizedStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is DocumentType))
                throw new InvalidCastException($"{value} must be DocumentType type");

            return Convert((DocumentType)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        private static string Convert(DocumentType name)
        {
            switch (name)
            {
                case DocumentType.Passport: return Resources.Passport;
                case DocumentType.BirthCertificate: return Resources.BirthCertificate;
            }

            throw new Exception($"DocumentTypeToLocalizedStringConverter can't convert from {name} to string.");
        }
    }
}

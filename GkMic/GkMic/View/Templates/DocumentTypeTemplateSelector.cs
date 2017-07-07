using GkMic.Common;
using System;
using System.Windows;
using System.Windows.Controls;

namespace GkMic.View.Templates
{
    class DocumentTypeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Passport { get; set; }
        public DataTemplate BirthCertificate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is null)
                return null;

            var doctype = (DocumentType)item;

            switch (doctype)
            {
                case DocumentType.Passport:
                    return Passport;
                case DocumentType.BirthCertificate:
                    return BirthCertificate;
            }

            throw new Exception($"Can't find template for {doctype}");
        }
    }
}

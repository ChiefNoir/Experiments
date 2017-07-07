using DataModel;
using System;

namespace Contracts
{
    public interface IDataService
    {
        void Save(Passport item, Action<Exception> callback);
        void Save(BirthCertificate item, Action<Exception> callback);
    }
}
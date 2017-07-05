using DataModel;
using System;

namespace Contracts
{
    public interface IDataService
    {
        void Save(Action<Passport, Exception> callback);

        void Save(Action<BirthCertificate, Exception> callback);
    }
}
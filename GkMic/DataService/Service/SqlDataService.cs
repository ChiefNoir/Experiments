using Contracts;
using System;
using DataModel;

namespace DataService.Service
{
    public class SqlDataService : IDataService
    {
        public void Save(Passport item, Action<Exception> callback)
        {
            try
            {
                using (var db = new ClientsContext())
                {
                    db.Passports.Add(item);
                    db.SaveChanges();
                    callback(null);
                }
            }
            catch (Exception ee)
            {
                callback(ee);
            }
        }

        public void Save(BirthCertificate item, Action<Exception> callback)
        {
            try
            {
                using (var db = new ClientsContext())
                {
                    db.BirthCertificates.Add(item);
                    db.SaveChanges();
                    callback(null);
                }
            }
            catch (Exception ee)
            {
                callback(ee);
            }
        }
    }
}

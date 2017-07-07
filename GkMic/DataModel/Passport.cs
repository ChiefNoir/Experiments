using System;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Passport
    {
        //TODO: need some research for passport restrictions
        [Key]
        public string Number { get; set; }

        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Patronymic { get; set; }

        public string Code { get; set; }

        public string Organisation { get; set; }
        public DateTime Date { get; set; }

        public Passport()
        {
            Date = DateTime.Now;
        }
    }
}

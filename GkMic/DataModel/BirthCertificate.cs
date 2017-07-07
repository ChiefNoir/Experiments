using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class BirthCertificate
    {
        //TODO: need some research for birth certificate restrictions
        [Key]
        public string Number { get; set; } 

        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Patronymic { get; set; }

        public string Organisation { get; set; }
    }
}

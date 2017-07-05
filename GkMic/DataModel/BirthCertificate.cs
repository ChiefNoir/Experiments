using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class BirthCertificate
    {
        [Key]
        public int Number { get; set; }

        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Patronymic { get; set; }

        public string Organisation { get; set; }
    }
}

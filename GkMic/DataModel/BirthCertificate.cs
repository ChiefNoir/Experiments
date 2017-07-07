using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel
{
    public class BirthCertificate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Number { get; set; }

        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string Patronymic { get; set; }

        public string Organisation { get; set; }
    }
}

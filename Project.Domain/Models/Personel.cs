using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain
{
    [Table("Personel")]
    public class Personel : BaseDataEntities
    {
        [Column("Name")]
        public string Name { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

    }
}

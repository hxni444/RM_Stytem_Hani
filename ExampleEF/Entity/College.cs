using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleEF.Entity
{
    public class College
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Column("College Name")]
        public string Name { get; set; }

        [Required]

         public int adminisId {  get; set; }

    }
}

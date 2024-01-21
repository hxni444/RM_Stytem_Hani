using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleEF.Entity
{
    public class Admin
    {
        [Key]
        public int adminisId { get; set; }

        public int cllgId { get; set; }

        [Required]

        public string name { get; set; }

        //navigation property
        [ForeignKey("cllgId")]
        public College? clg { get; set; }

    }
}

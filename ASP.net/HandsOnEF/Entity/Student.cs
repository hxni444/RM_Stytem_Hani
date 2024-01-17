using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HandsOnEF.Entity
{
    [Table("SudentTble")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }


        [Required]
        [Column("Name", TypeName = "varchar")]
        [StringLength(50)]
        public string Name { get; set; }


        [Required]
        [Column("Class", TypeName = "varchar")]
        [StringLength(50)]
        public string std { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Section { get; set; }
    }
}

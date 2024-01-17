using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HandsOnEF.Entity
{
    [Table("MarksTble")]
    public class Mark
    {
        [Key]
        public Guid MarksId { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Exam { get; set; }
        public int? TotalMarks { get; set; }//set column as null


        public int StudentId { get; set; }

        //Navigation Property
        [ForeignKey("Id")]
        public Student Student { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookApiAssignmentWithEntityFrameWoek.Enity
{
    public class Book
    {
        [Key]

     public  int BookId { get; set; }
        [Required]
        [StringLength(30)]
        [Column("Book", TypeName ="varchar(30)")]
     public  string BookName {  get; set; }
     public      double Price { get; set; }
     public  string  Author { get; set; }

    [Column("Language", TypeName = "varchar(30)")]
    public string  Lang { get; set; }
     public DateTime  ReleaseDate { get; set; }
    }
}

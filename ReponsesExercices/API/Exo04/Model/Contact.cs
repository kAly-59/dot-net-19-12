using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exo04.Model
{
    [Table("contact")]
    public class Contact
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("firstname")]
        [Required]
        //[RegularExpression(@"^\d{5}$", ErrorMessage = " ! ")]
        public string? FirstName { get; set; }
        [Column("lastname")]
        [Required]
        public string? LastName { get; set; }
        public string? FullName => FirstName + " " + LastName;
        [Column("birth_date")]
        [Required]
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateOfBirth > DateTime.Now.AddYears(-age))
                    age--;
                return age;
            }
        }
        [Column("gender")]
        [Required]
        public string? Gender { get; set; }

        public string? Avatar { get; set; }
    }
}



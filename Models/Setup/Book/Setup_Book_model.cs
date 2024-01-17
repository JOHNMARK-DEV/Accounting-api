using System.ComponentModel.DataAnnotations;

namespace accounting_api.Models.Setup.Book
{
    public class Setup_Book_model
    {
        [Key]
        public int id { get; set; } = 0;

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Code must be between 3 and 50 characters.")]
        public string? code { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string? name { get; set; }
    }
}

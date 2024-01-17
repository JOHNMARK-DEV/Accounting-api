using System.ComponentModel.DataAnnotations;

namespace accounting_api.Models.Setup
{
    public class Setup_Businesspartner_model
    {
        [Key]
        public int id { get; set; } = 0;
        public int? category_id { get; set; }
        public string? code { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string? name { get; set; }
        public string? address { get; set; }
        public int? is_active { get; set; } = 0;
    }
}

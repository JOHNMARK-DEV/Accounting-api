using System.ComponentModel.DataAnnotations;

namespace accounting_api.Models.Setup.Chart
{
    public class Setup_Chartofaccount_model
	{
        [Key]
        public int id { get; set; } = 0;

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Code must be between 3 and 50 characters.")]
        public string? code { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string? name { get; set; }
        public string? description { get; set; } 
        public int class_id { get; set; } = 0;
        public int group_id { get; set; } = 0;
        public int validation_id { get; set; } = 0;
        public DateTime date { get; set; }  
        public int is_input_vat_importation { get; set; } = 0;
        public int is_restatement { get; set; } = 0;
        public int is_unit_applicable { get; set; } = 0;
        public int is_no_compute { get; set; } = 0; 

    }
}

using System.ComponentModel.DataAnnotations;

namespace accounting_api.Models.Setup
{
    public class Setup_Company_model
    {
        [Key]
        public int id { get; set; } = 0;
 
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string? name { get; set; }
        public string? address { get; set; }
        public string? email { get; set; }
        public string? tel_no { get; set; }
        public string? fax_no { get; set; }
        public string? tin { get; set; }
        public DateTime? begbal_date { get; set; } 
        public string? rdo_code { get; set; } 
        public string? zip_code { get; set; }
        public string? based_currency { get; set; }
        public string? retained_earning { get; set; }
        public string? foreign_exchange { get; set; }
        public string? restatement { get; set; }

          
        public decimal? exchange_rate_decimal { get; set; }
        public decimal? transaction_decimal { get; set; }
        public int? is_monthly_currency_rate { get; set; } = 0;
        public int? is_multi_currency { get; set; } = 0;
        public int? is_auto_number { get; set; } = 0;


    }
}

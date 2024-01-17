using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Formats.Asn1;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace accounting_api.Models.Setup.Tax
{
    public class Setup_Expandedtax_model
    {

        [Key] 
        public int id { get; set; } = 0;

        [Required]
        public string? code { get; set; }

        [Required]  
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string? name { get; set; } = "";

        [Required]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Rate must be a valid numeric value.")]
        public decimal? rate { get; set; } = 0; 
    } 
}

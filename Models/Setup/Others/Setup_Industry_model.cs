using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Formats.Asn1;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace accounting_api.Models.Setup.Others { 

    public class Setup_Industry_model
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

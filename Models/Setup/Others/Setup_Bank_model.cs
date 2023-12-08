using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Formats.Asn1;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace accounting_api.Models.Setup.Others { 

    public class Setup_Bank_model
    {

        [Key] 
        public int id { get; set; } = 0;

        [Required]
        public string? code { get; set; }

        [Required]
        public string? name { get; set; } 
    } 
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Formats.Asn1;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace accounting_api.Models.Setup.Tax
{
    public class Setup_Finaltax_model
    {

        [Key] 
        public int id { get; set; } = 0;
        public string? code { get; set; }
        public string? name { get; set; }
    }  
}

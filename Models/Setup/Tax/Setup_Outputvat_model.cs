using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Formats.Asn1;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace accounting_api.Models.Setup.Tax
{
    public class Setup_Outputvat_model
    {

        [Key]  
        public int id { get; set; } = 0;
        public DateTime effectivity_date { get; set; } = DateTime.Now.Date;
        public decimal? rate { get; set; } = 0;
    } 
}

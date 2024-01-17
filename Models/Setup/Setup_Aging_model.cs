using System.ComponentModel.DataAnnotations;

namespace accounting_api.Models.Setup.Book
{
    public class Setup_Aging_model
    {
        [Key]
        public int id { get; set; } = 0;

        [Required] 
        public int? day_from { get; set; }

        [Required] 
        public int? day_to { get; set; }
    }
}

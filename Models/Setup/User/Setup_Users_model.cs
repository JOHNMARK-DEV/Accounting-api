using System.ComponentModel.DataAnnotations;

namespace accounting_api.Models.Setup.User
{
    public class Setup_Users_model
    {
        [Key]
        public int id { get; set; }
        public int profile_id { get; set; }
        public String? username { get; set; }
        public String? password { get; set; }
        public String? email { get; set; }
        public String? name { get; set; }  
        public int position_id { get; set; } 
        public int department_id { get; set; }
    }
}

using accounting_api.Models.Setup.Tax;

namespace accounting_api.Models.Setup.User
{
    public class Setup_Users_model_at : Setup_Users_model
    {
        public string AT_ACTION { get; set; } = "";
        public string IP_ADDRESS { get; set; } = "";
        public DateTime AT_DATE { get; set; } = DateTime.Now;
        public int AT_USER_ID { get; set; } = 0;

        public void CopyFromBase(Setup_Users_model baseInstance)
        {
            profile_id = baseInstance.profile_id; 
            username = baseInstance.username;
            password = baseInstance.password; 
            email = baseInstance.email;  
            name = baseInstance.name;
            position_id = baseInstance.position_id;
            department_id = baseInstance.department_id;
        }
    }
}

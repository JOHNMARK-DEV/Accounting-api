using accounting_api.Models.Setup.Tax;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace accounting_api.Models.Setup
{
    public class Setup_Businesspartner_model_at : Setup_Businesspartner_model
    {
        public int trans_id { get; set; } = 0;
        public string AT_ACTION { get; set; } = "";
        public string IP_ADDRESS { get; set; } = "";
        public DateTime AT_DATE { get; set; } = DateTime.Now.Date;
        public int AT_USER_ID { get; set; } = 0;

        public void CopyFromBase(Setup_Businesspartner_model baseInstance)
        {  
            category_id = baseInstance.category_id;
            code = baseInstance.code;
            name = baseInstance.name;
            address = baseInstance.address;
            is_active = baseInstance.is_active;

 
        }
    }
}

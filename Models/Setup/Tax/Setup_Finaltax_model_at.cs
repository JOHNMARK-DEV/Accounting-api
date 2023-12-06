using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.Xml.Linq;

namespace accounting_api.Models.Setup.Tax
{
    public class Setup_Finaltax_model_at : Setup_Finaltax_model
    {
        public int trans_id { get; set; } = 0;
        public string AT_ACTION { get; set; } = "";
        public string IP_ADDRESS { get; set; } = "";
        public DateTime AT_DATE { get; set; } = DateTime.Now.Date;
        public int AT_USER_ID { get; set; } = 0; 

        public void CopyFromBase(Setup_Finaltax_model baseInstance)
        {
            code = baseInstance.code;
            name = baseInstance.name;
            trans_id = baseInstance.id;
        }

    }
}

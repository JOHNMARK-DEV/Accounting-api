using accounting_api.Models.Setup.Tax;
using System.Xml.Linq;

namespace accounting_api.Models.Setup.Chart
{
    public class Setup_Chartofaccount_model_at : Setup_Chartofaccount_model
    {
        public int trans_id { get; set; } = 0;
        public string AT_ACTION { get; set; } = "";
        public string IP_ADDRESS { get; set; } = "";
        public DateTime AT_DATE { get; set; } = DateTime.Now.Date;
        public int AT_USER_ID { get; set; } = 0;

        public void CopyFromBase(Setup_Chartofaccount_model baseInstance)
        {
            code = baseInstance.code;
            name = baseInstance.name;
            trans_id = baseInstance.id;

            class_id = baseInstance.class_id;
            group_id = baseInstance.group_id;
            validation_id = baseInstance.validation_id;
            date = baseInstance.date;
            is_input_vat_importation = baseInstance.is_input_vat_importation;
            is_restatement = baseInstance.is_restatement;
            is_unit_applicable = baseInstance.is_unit_applicable;
            is_no_compute = baseInstance.is_no_compute;
        }
    }
}

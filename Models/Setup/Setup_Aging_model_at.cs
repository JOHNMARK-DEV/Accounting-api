using accounting_api.Models.Setup.Book;
using accounting_api.Models.Setup.Tax;
using System.Xml.Linq;

namespace accounting_api.Models.Setup.Chart
{
    public class Setup_Aging_model_at : Setup_Aging_model
    {
        public int trans_id { get; set; } = 0;
        public string AT_ACTION { get; set; } = "";
        public string IP_ADDRESS { get; set; } = "";
        public DateTime AT_DATE { get; set; } = DateTime.Now.Date;
        public int AT_USER_ID { get; set; } = 0;

        public void CopyFromBase(Setup_Aging_model baseInstance)
        {
            day_from = baseInstance.day_from;
            day_to = baseInstance.day_to;
            trans_id = baseInstance.id;
        }
    }
}

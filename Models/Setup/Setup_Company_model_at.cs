using accounting_api.Models.Setup.Tax;
using System.Xml.Linq;

namespace accounting_api.Models.Setup
{
    public class Setup_Company_model_at : Setup_Company_model
    {
        public int trans_id { get; set; } = 0;
        public string AT_ACTION { get; set; } = "";
        public string IP_ADDRESS { get; set; } = "";
        public DateTime AT_DATE { get; set; } = DateTime.Now.Date;
        public int AT_USER_ID { get; set; } = 0;

        public void CopyFromBase(Setup_Company_model baseInstance)
        { 
            name = baseInstance.name;
            address = baseInstance.address;
            email = baseInstance.email;
            tel_no = baseInstance.tel_no;
            fax_no = baseInstance.fax_no;
            tin = baseInstance.tin;
            begbal_date = baseInstance.begbal_date;
            rdo_code = baseInstance.rdo_code;
            zip_code = baseInstance.zip_code;
            based_currency = baseInstance.based_currency;
            exchange_rate_decimal = baseInstance.exchange_rate_decimal;
            transaction_decimal = baseInstance.transaction_decimal;
            is_monthly_currency_rate = baseInstance.is_monthly_currency_rate;
            is_multi_currency = baseInstance.is_multi_currency;
            is_auto_number = baseInstance.is_auto_number;
            trans_id = baseInstance.id;

            retained_earning = baseInstance.retained_earning;
            foreign_exchange = baseInstance.foreign_exchange;
            restatement = baseInstance.restatement;
            
        }
    }
}

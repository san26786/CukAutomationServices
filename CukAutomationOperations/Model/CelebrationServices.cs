using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class CelebrationServices
    {
        public int Org_ID { get; set; }
    }

    public class FinancialDetails
    {
        public string commitment_id { get; set; }
        public string organisation_id { get; set; }
        public string needkey { get; set; }
        public string supporter_group_id { get; set; }
        public string supporter_type { get; set; }
        public string bbid { get; set; }
        public string total_of_financial_support_in_last_year { get; set; }
        public string no_of_gifts_in_last_year { get; set; }
        public string total_of_financial_support_in_previous_year { get; set; }
        public string no_of_gifts_in_previous_year { get; set; }
        public string last_updated_time { get; set; }
        public string sup_grp_bbid { get; set; }
        public string supporterid { get; set; }
        public string lookupid { get; set; }
        public string financial_support_amount { get; set; }
        public string gift_support_count { get; set; }
        public string event_id { get; set; }
    }

    public class EntityData
    {
        public long Org_Id { get; set; }
        public long Denomination_Id { get; set; }
        public string Denomination_Name { get; set; }
        public long Network_Id { get; set; }
        public string Network_Name { get; set; }
        public long Region_Id { get; set; }
        public string Region_Name { get; set; }
        public long Regional_Manager_Id { get; set; }
        public string Regional_Manager_Name { get; set; }
        public string Postcode_Area { get; set; }
        public long Entity_Id { get; set; }

        public bool Event_flag { get; set; }
        public long Event_Id { get; set; }
        public string Event_Name { get; set; }
        public long Event_Series_Id { get; set; }
        public string Event_Series_Name { get; set; }
        public long Event_Ambassador_Id { get; set; }
        public string Event_Ambassador_Name { get; set; }

    }

}

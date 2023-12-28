using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class OrgData
    {
        public long OrgID { get; set; }
        public string Org_Name { get; set; }
        public string Org_Address { get; set; }
        public int NumberOfChild { get; set; }
        public int Financial_support_to_compassion_in_past_12_months { get; set; }
        public int Number_of_additional_gifts_given_to_children_in_past_year { get; set; }
        public int Total_children_count_per_country { get; set; }

        public int Letters_sent_by_children { get; set; }
        public int Letters_sent_to_children { get; set; }

        // Celebration service V2 
        public int Letters_sent_in_last_year { get; set; }  

        public int B2S_Letters_Sent_Last_Year { get; set; }
        public int S2B_Letters_Sent_Last_Year { get; set; }
        public int B2S_Letters_Sent_Previous_Year { get; set; } 
        public int S2B_Letters_Sent_Previous_Year { get; set; }
        public long Changed_In_B2S_Letters { get; set; }
        public long Changed_In_S2B_Letters { get; set; }

        public int Total_Of_Financial_Supp_In_Last_Year { get; set; } 
        public int No_Of_Gifts_In_Last_Year { get; set; } 
        public int Total_Of_Financial_Supp_In_Previous_Year { get; set; } 
        public int No_Of_Gifts_In_Previous_Year { get; set; }
        public long Changed_In_Financial_Support { get; set; }
        public long Changed_In_No_Of_Gift { get; set; }
        
        public string Slide7A_Text_1 { get; set; }
        public string Slide7A_Text_2 { get; set; }
        public string Slide7B_Text_1 { get; set; }
        public string Slide7B_Text_2 { get; set; }

    }

    public class ChildData
    {
        public long OrgId { get; set; }
        public string NeedKey { get; set; }
        public string FullBodyImageURL { get; set; }
        public string CountryName { get; set; }
        public string Gender { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string BirthDate { get; set; }
        public string Project { get; set; }
        public string Community { get; set; }
        public string FemaleGuardianOccupation { get; set; }
        public string MaleGuardianOccupation { get; set; }
        public string NaturalFatherAlive { get; set; }
        public string NaturalMotherAlive { get; set; }
        public string YouthheadedHousehold { get; set; }
        public string CorrespondenceLanguage { get; set; }
        public string GradeLevelUS_Name { get; set; }
        public int B2s_letter_count { get; set; }
        public int S2b_letter_count { get; set; }
        public int Bibles_given { get; set; }
        public int Nutritious_meals { get; set; }
        public int Hours_spent_at_project { get; set; }
        public int Medical_checkup { get; set; }
    }

}

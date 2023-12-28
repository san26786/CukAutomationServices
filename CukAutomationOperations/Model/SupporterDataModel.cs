using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukAutomationOperations.Model
{
    public class SupporterDataModel
    {
        public string SupId { get; set; }
        public string firtsname { get; set; }
        public string lastname { get; set; }
        public string SupporterName { get; set; }
        public string Email { get; set; }
        public string status { get; set; }
        public string BlackbaudId { get; set; }
        public string Process { get; set; }
        public string SupporterInRN { get; set; }
        public string NoOfEnq { get; set; }
        public string SupGrpInRN { get; set; }
        public string Blackbaud { get; set; }
        public string Connect { get; set; }
        public string phoneNo { get; set; }
        public string mobileNo { get; set; }
        public string OfficePhone { get; set; }
        public string Supporterpreferencesphone { get; set; }
        public string hassponplus { get; set; }
        public string GiftAidDeclaration { get; set; }
        public string AnnualBirthdayGift { get; set; }
        public string AnnualChristmasGift { get; set; }
        public string Welcomepackoption { get; set; }
        public bool TraditionalorPaperless { get; set; }
        public bool IsNewSupporter { get; set; }
        public int TotalCommitment { get; set; }
        public string Source { get; set; }
        public string postcode { get; set; }
        public string street1 { get; set; }

        public string NewSupporterPreferredName { get; set; }
        public string OldSupporterPreferredName { get; set; }
        public string SupporterGroupId { get; set; }
        public string ChildNeedKey { get; set; }
        public string ChildPreferredName { get; set; }

    }

    public class OrganizationData
    {
        public string OrgID { get; set; }
        public string OrgRelationshipStatus { get; set; }
    }
    public class Notes
    {
        public long NoteID { get; set; }
    }
}

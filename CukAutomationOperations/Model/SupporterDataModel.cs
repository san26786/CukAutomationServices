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

    public class Notes
    {
        public long NoteID { get; set; }
    }

    public class OnlineS2BDbModel
    {
        public int actionid { get; set; }
        public int Id { get; set; }
        public int Need { get; set; }
        public string NeedKey { get; set; }
        public string MessageTo { get; set; }
        public string BeneficiaryGlobalID { get; set; }
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public int SupporterGroup { get; set; }
        public string SupporterGlobalID { get; set; }
        public string MessageFrom { get; set; }
        public long ConId { get; set; }
        public string Message { get; set; }
        public string Image64 { get; set; }
        public string ImageExtension { get; set; }
        public string FtpFilePath { get; set; }
        public string FileURL { get; set; }
        public long SourceId { get; set; }
        public string CommKitId { get; set; }

        public int Type { get; set; }
        public string BatchID { get; set; }
        public DateTime DateScanned { get; set; }
        public DateTime DateProcessed { get; set; }
        public bool ItemNotScannedEligable { get; set; }
        public bool ItemNotScannedNotEligable { get; set; }
        public bool FromUtility { get; set; }
        public string Barcode { get; set; }
    }
    public class Gift
    {
        public string ClearedBank { get; set; }
        public string AmountInOriginatingCurrency { get; set; }
        public string GiftType { get; set; }
        public string PartnerGiftDate { get; set; }
        public string PartnerGiftID { get; set; }
        public string ReceipentID { get; set; }
        public string SupporterGlobalID { get; set; }
        public string GiftTransmittedtoGMCAttributeValue { get; set; }
        public string GiftReceivedbyChildAttributeValue { get; set; }
        public string GiftErrorMessageAttributeValue { get; set; }
        public string ConstituentLookupID { get; set; }
        public string DesignationName { get; set; }
        public string UndeliverableGiftReason { get; set; }
        public string GiftDelay { get; set; }
        public string GiftDelayReason { get; set; }
        public string UndeliverableGiftDate { get; set; }
    }
}

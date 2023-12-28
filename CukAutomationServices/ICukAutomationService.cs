using CukAutomationOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CukAutomationServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICukAutomationService" in both code and config file together.
    [ServiceContract]
    public interface ICukAutomationService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        void TriggerSetupBot();

        [OperationContract]
        void TriggerCheckBot();

        [OperationContract]
        void SyncAdvanceNotice(long RecordId);

        [OperationContract]
        void CreateAdvanceNoticeEnquiries(long RecordId);

        [OperationContract]
        void UpdateAdNoticeSentDateInBBMainMethod(long RecordId);

        [OperationContract]
        void TriggerResolveBot(long IncidentID);

        [OperationContract]
        void SyncCelebrationServicesData(int OrgID);

        [OperationContract]
        void UpdateSponsorship_HNM(long OrgID);

        [OperationContract]
        void UpdateOrgPPT_Type(long OrgID);

        [OperationContract]
        S2BCommData GetCorrespondenceData(string Incidentrefid);

        [OperationContract]
        string GetSpondorshipDataOnID(string SponsorshipId);

        [OperationContract]
        bool DeleteS2BCommDraft(long SupporterID);

        [OperationContract]
        string UpsertS2BCommDraft(S2BCommDraftData s2bobj);

        [OperationContract]
        Message GetS2BCommDraftTile(long SupporterID);

        [OperationContract]
        void RunEntityOperation(EntityData entityObj);

        [OperationContract]
        void RunEventOperation(EntityData entityObj);

        [OperationContract]
        void TriggerExitToResolve();


        [OperationContract]
        List<cancelRecurringGift> cancelRecurringGift(List<cancelRecurringGift> rgobj, string delinkReason, string FundType, int DonationAmount, bool IsAssignToGeneralFund, string IncidentRefId, string DDiSource, string DDiSourceDate);

        [OperationContract]
        bool CheckSponsroshipStartToday(string SponsorshipId);

        [OperationContract]
        void ImportRateChangeEnquiriesForKingslineData(long RecordId);

        [OperationContract]
        void ResolveRateChangeEnquiries(long RecordId);

    }
}

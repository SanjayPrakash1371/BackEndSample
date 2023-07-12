using Sample.Models.Rewards;

namespace Sample.Models.OtherRewards
{
    public class LeadCitationReplies
    {

        public int id { get; set; }

        public int campId { get; set; }

        public int nominatorId { get; set; }

        public string Replycitation { get; set; }

        public LeadCitation? leadCitation;

        public Campaigns? Campaigns { get; set; }




    }
}

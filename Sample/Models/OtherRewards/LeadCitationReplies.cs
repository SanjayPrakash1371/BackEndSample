using Sample.Models.Rewards;

namespace Sample.Models.OtherRewards
{
    public class LeadCitationReplies
    {

        public int id { get; set; }

        public int campId { get; set; }

        public string nominatorId { get; set; }

        public string replierId { get; set; }  

        public string Replycitation { get; set; }

        public LeadCitation? leadCitation { get; set; }

        public Campaigns? Campaigns { get; set; }




    }
}

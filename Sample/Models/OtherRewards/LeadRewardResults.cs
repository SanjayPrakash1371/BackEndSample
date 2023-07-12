using Sample.Models.Rewards;

namespace Sample.Models.OtherRewards
{
    public class LeadRewardResults
    {
        public int id {  get; set; }

        public int rewardId { get; set; }

        public int campId { get; set; }

        public string nominatorId { get; set; }

        public string nominatedEmpId { get; set; }

        public string awardType { get; set; }

        public int stars { get; set; }

        public string campname { get; set; }

        public Employee? employee { get; set; }





        public Campaigns? Campaigns
        { get; set; }

    }
}

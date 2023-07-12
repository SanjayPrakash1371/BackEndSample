using Sample.Models.Rewards;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample.Models.OtherRewards
{
    public class LeadRewards
    {
        public int id { get; set; }

        public int rewardId { get; set; }

        public int campId { get; set; }

        public string nominatorId { get; set; }

        public string nominatedEmpId { get; set;}

        public string awardCategory { get; set; }

        public int stars { get; set; }

        public int month { get; set;}

        public Employee? employee { get; set; }

       

        public Campaigns Campaigns
        { get; set; }


        public LeadCitation LeadCitation { get; set; }
        
       

        public LeadRewardResults LeadRewardResults { get; set; }

       




    }


}

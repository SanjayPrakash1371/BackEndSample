namespace Sample.Models.Rewards
{
    public class Campaigns
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public int rewardId { get; set; }

       public  RewardsTypes? types { get; set; }

         
    }
}

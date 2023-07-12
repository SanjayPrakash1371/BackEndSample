namespace Sample.Controllers.MonthlyRewards
{
    public class NewLeadRewards
    {
        public int campId { get; set; }

        public string nominatorId { get; set; }

        public string nominatedEmpId { get; set; }

        public string awardCategory { get; set; }

        public int stars { get; set; }

        public int month { get; set; }

        public string citation { get; set; }    
    }
}
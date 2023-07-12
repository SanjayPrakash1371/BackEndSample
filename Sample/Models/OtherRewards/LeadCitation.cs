namespace Sample.Models.OtherRewards
{
    public class LeadCitation
    {

        public int id { get; set; }

        public string nominatorId { get; set; }

        public string citation { get; set; }

        public ICollection<LeadCitationReplies>?  replies { get; set; }   = new List<LeadCitationReplies>(); 

       



       
    }
}

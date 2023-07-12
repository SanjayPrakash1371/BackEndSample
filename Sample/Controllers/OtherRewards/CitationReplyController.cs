using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.DbConnect;
using Sample.Models.OtherRewards;

namespace Sample.Controllers.OtherRewards
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitationReplyController : ControllerBase
    {

        private readonly AllDataAccess dataAccess;
        public CitationReplyController(AllDataAccess dataAccess) { this.dataAccess = dataAccess; }

        [HttpPost]

        public async Task<ActionResult<LeadCitationReplies>> addReply(LeadCitationReplies replies)
        {


            replies.Campaigns = dataAccess.Campaigns.FirstOrDefault(x => x.Id == replies.campId);

            replies.leadCitation=dataAccess.LeadCitation.FirstOrDefault(x=>x.nominatorId.Equals(replies.nominatorId));

            await dataAccess.LeadReplyCitation.AddAsync(replies);   

            await dataAccess.SaveChangesAsync();

            return Ok(replies);
        }
    }
}

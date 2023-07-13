using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ActionResult<LeadCitationReplies>> addReply(TempLeadCitationReplies Tempreplies)
        {
            LeadCitationReplies leadCitationReplies = new LeadCitationReplies();

            // Foreign KEy values added

            leadCitationReplies.Campaigns= dataAccess.Campaigns.FirstOrDefault(x => x.Id == Tempreplies.campId);


            // required values

            leadCitationReplies.Replycitation = Tempreplies.Replycitation;

            leadCitationReplies.nominatorId= Tempreplies.nominatorId;

            leadCitationReplies.replierId= Tempreplies.replierId;

            leadCitationReplies.campId=Tempreplies.campId;

            leadCitationReplies.leadCitation = dataAccess.LeadCitation.
                 FirstOrDefault(x => x.nominatorId.Equals(Tempreplies.nominatorId) && x.Campaigns.Id==Tempreplies.campId);


            await dataAccess.LeadReplyCitation.AddAsync(leadCitationReplies);

            await dataAccess.SaveChangesAsync();

            return Ok(leadCitationReplies);
        }
    }
}

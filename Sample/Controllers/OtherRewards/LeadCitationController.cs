using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample.DbConnect;
using Sample.Models.OtherRewards;

namespace Sample.Controllers.OtherRewards
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadCitationController : ControllerBase
    {
        private readonly AllDataAccess dataAccess;
        public LeadCitationController(AllDataAccess dataAccess) { this.dataAccess = dataAccess; }


        [HttpGet]

        public async Task<ActionResult<IEnumerable<LeadCitation>>> get()
        {
            var query = (from a in dataAccess.LeadCitation
                         join b in dataAccess.LeadReplyCitation on a.nominatorId equals b.nominatorId
                         where b.campId == 2

                         select new { Maincomment = a.citation, NId=a.nominatorId,RId = b.replierId, comment = b.Replycitation }).ToList();

            return Ok(query);
        }

        [HttpGet]
        [Route("{nominatorId}")]
        public async Task<ActionResult<LeadCitation>> get([FromRoute] string nominatorId)
        {
            // var result= await dataAccess.LeadCitation.
            //    FirstOrDefaultAsync(x=>x.nominatorId.Equals(nominatorId) && x.Campaigns.Id==2);

            // result.replies= dataAccess.LeadReplyCitation.Where(x=>x.Campaigns.Id==2 && x.nominatorId.Equals(nominatorId)).ToList();  
            /*var result = (from c in dataAccess.LeadReplyCitation
                         join mainC in dataAccess.LeadCitation on c.nominatorId equals nominatorId
                          select new { c.replierId, c.nominatorId,c.Replycitation }).ToList();

            var result1 = (from a in dataAccess.LeadCitation 
                          join b in dataAccess.LeadReplyCitation on a.nominatorId equals b.nominatorId
                          select new {a.nominatorId, b.replierId, b.Replycitation}).ToList();*/


            // return Ok(result1);


            var result = await dataAccess.LeadCitation.
                FirstOrDefaultAsync(x=>x.nominatorId.Equals(nominatorId) && x.Campaigns.Id==2);

            var query = (from a in dataAccess.LeadCitation
                        join b in dataAccess.LeadReplyCitation on a.nominatorId equals nominatorId
                         where b.campId == 2

                        select new { RId = b.replierId, comment = b.Replycitation }).ToList();

            /*var query =
  from post in database.Posts
  join meta in database.Post_Metas on post.ID equals meta.Post_ID
  where post.ID == id
  select new { Post = post, Meta = meta };*/




            return Ok(query);


        }
    }
}

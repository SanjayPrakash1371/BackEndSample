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

                         select new {  NId=a.nominatorId,RId = b.replierId, comment = b.Replycitation }).ToList();

            return Ok(query);
        }

        [HttpGet]
        [Route("{nominatorId}/{campId}")]
        public async Task<ActionResult<LeadCitation>> get([FromRoute] string nominatorId, int campId)
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


           /* var result1 = await dataAccess.LeadReplyCitation.
                FirstOrDefaultAsync(x=>x.nominatorId.Equals(nominatorId) && x.Campaigns.Id==2);
            var result =  dataAccess.LeadReplyCitation.Where(x=>x.nominatorId==nominatorId).ToList(); */
            
            

            var query = (from a in dataAccess.LeadCitation
                        join b in dataAccess.LeadReplyCitation  on a.id equals b.leadCitation.id
                         where b.nominatorId == nominatorId  && b.campId == campId

                        select new {  nId= a.nominatorId,RId = b.replierId, comment = b.Replycitation }).ToList();

                    /*var query =
          from post in database.Posts
          join meta in database.Post_Metas on post.ID equals meta.Post_ID
          where post.ID == id
          select new { Post = post, Meta = meta };*/




            return Ok(query);


        }
    }
}

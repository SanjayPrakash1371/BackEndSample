using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample.DbConnect;
using Sample.Models.OtherRewards;
using Sample.Models.P2P;

namespace Sample.Controllers.OtherRewards
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadResultsController : ControllerBase
    {

        private readonly AllDataAccess dataAccess;
        public LeadResultsController(AllDataAccess dataAccess) { this.dataAccess = dataAccess; }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeadRewardResults>>> Get()
        {

            return await dataAccess.LeadRewardResults.ToListAsync();

        }
        [HttpGet]
        [Route("result/{campId:int}/{count:int}")]

        public async Task<ActionResult<IEnumerable<LeadRewardResults>>> getResult([FromRoute] int campId,int count)
        {

            var arr = dataAccess.LeadRewardResults.GroupBy(x=> new {x.campId,x.nominatedEmpId});



            //var result = (from l in arr select new { Id = l.Key.nominatedEmpId, Count = l.ToList().Count() });

            var results = (from l in dataAccess.LeadRewardResults where l.campId == campId
                          group l by l.nominatedEmpId  into g
                          select new { EmpId=g.First().nominatedEmpId, Stars = g.Sum(s => s.stars)/g.ToList().Count() }).Take(count);
                      






            return Ok(results);


        }
    }
}

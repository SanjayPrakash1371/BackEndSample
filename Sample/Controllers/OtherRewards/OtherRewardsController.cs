using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample.DbConnect;
using Sample.Models;
using Sample.Models.OtherRewards;
using Sample.Models.Rewards;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sample.Controllers.MonthlyRewards
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtherRewardsController : ControllerBase
    {

        private readonly AllDataAccess dataAccess;
        public OtherRewardsController(AllDataAccess dataAccess) { this.dataAccess = dataAccess; }


        // GET: api/<MonthlyRewardsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeadRewards>>> Get()
        {

            return await dataAccess.LeadRewards.ToListAsync();
            
        }

    

        // POST api/<MonthlyRewardsController>
        [HttpPost]
        public async Task<ActionResult<LeadRewards>> Post( NewLeadRewards nlr)
        {
            LeadRewards leadRewards = new LeadRewards();

            leadRewards.campId = nlr.campId;

            leadRewards.nominatorId = nlr.nominatorId;

            leadRewards.nominatedEmpId = nlr.nominatedEmpId;

            leadRewards.awardCategory=nlr.awardCategory;

            leadRewards.month=nlr.month;

            leadRewards.stars=nlr.stars;

            Campaigns cmp= await dataAccess.Campaigns.FirstOrDefaultAsync(x => x.Id == leadRewards.campId);

            leadRewards.rewardId = cmp.rewardId;


            // Add Emp refernce

            Employee emp= await dataAccess.Employees.FirstOrDefaultAsync(x => x.empId.Equals(leadRewards.nominatedEmpId));

            leadRewards.employee = emp;




            // Add Campaign ref

            Campaigns campaigns= await dataAccess.Campaigns.FirstOrDefaultAsync(x=>x.Id==leadRewards.campId);

            leadRewards.Campaigns = campaigns;



            // Results table post

            LeadRewardResults leadRewardResults = new LeadRewardResults();

            leadRewardResults.rewardId = leadRewards.rewardId;

            

            leadRewardResults.campId = leadRewards.campId;

            leadRewardResults.nominatorId = leadRewards.nominatorId;

            leadRewardResults.nominatedEmpId = leadRewards.nominatedEmpId;

            leadRewardResults.awardType = leadRewards.awardCategory;

            leadRewardResults.employee = emp;

            leadRewardResults.Campaigns = campaigns;

            leadRewardResults.stars= leadRewards.stars;

            leadRewardResults.campname= dataAccess.Campaigns.Find(leadRewardResults.campId).Name;

            // add Citation

            LeadCitation citation= new LeadCitation();

            citation.citation = nlr.citation;
            citation.nominatorId= nlr.nominatorId;
            leadRewards.LeadCitation = citation;

            /// cmp added 
            citation.Campaigns = campaigns;




            // Add Final Connections

            leadRewards.LeadCitation = citation;

            leadRewards.LeadRewardResults = leadRewardResults;



            //save to database

            await dataAccess.LeadRewards.AddAsync(leadRewards);

            await dataAccess.SaveChangesAsync();

            return Ok(leadRewards);

           







        }

        // PUT api/<MonthlyRewardsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        

    }
}

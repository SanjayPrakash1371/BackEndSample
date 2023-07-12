using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample.DbConnect;
using Sample.Models.Rewards;

namespace Sample.Controllers.Rewards
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {

        private readonly AllDataAccess dataAccess;

        public CampaignController(AllDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Campaigns>>> Get()
        {

          var result= await dataAccess.Campaigns.ToListAsync();

            result.ForEach(x => x.types = dataAccess.RewardsTypes.FirstOrDefault(y => y.id == x.rewardId));

            return Ok(result);

        }


        [HttpPost]
        public async Task<ActionResult<Campaigns>> add(RequiredCampaign rcamp)
        {

            Campaigns camp = new Campaigns();

            camp.Start = rcamp.Start;
            camp.End = rcamp.End;
            camp.Name = rcamp.Name;
            camp.rewardId = rcamp.rewardId;

            RewardsTypes rewardsTypes = dataAccess.RewardsTypes.FirstOrDefault(x=>x.id == rcamp.rewardId);
            camp.types = rewardsTypes;

            await dataAccess.Campaigns.AddAsync(camp);

            await dataAccess.SaveChangesAsync();

            return Ok(camp);
        }
    }
}

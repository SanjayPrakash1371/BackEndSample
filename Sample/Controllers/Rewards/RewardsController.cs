using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample.DbConnect;
using Sample.Models.Rewards;

namespace Sample.Controllers.Rewards
{
    [Route("api/[controller]")]
    [ApiController]
    public class RewardsController : ControllerBase
    {

        private readonly AllDataAccess dataAccess;

        public RewardsController(AllDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RewardsTypes>>> Get()
        {

            return await dataAccess.RewardsTypes.ToListAsync();

        }


        [HttpPost]
        public async Task<ActionResult<RewardsTypes>> add(RewardsTypes rewardsTypes)
        {
            await dataAccess.RewardsTypes.AddAsync(rewardsTypes);

            await dataAccess.SaveChangesAsync();

            return Ok(rewardsTypes);
        }
    }
}

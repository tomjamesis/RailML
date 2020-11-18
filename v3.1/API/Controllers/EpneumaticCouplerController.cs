using Models.DB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
	[Route("api/[controller]")]
	//[Authorize]
	[ApiController]
	public class EpneumaticCouplersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EpneumaticCoupler> lEpneumaticCouplers = await db.EpneumaticCoupler.GetAllCompanyEpneumaticCouplers(id);
				 //return JsonConvert.SerializeObject(lEpneumaticCouplers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EpneumaticCoupler epneumaticcoupler)
			{
				 //Create
				 db.EpneumaticCoupler.Add(epneumaticcoupler);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(epneumaticcoupler);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EpneumaticCoupler epneumaticcoupler)
			{
				 //Update
				 db.EpneumaticCoupler.Update(epneumaticcoupler);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EpneumaticCoupler epneumaticcoupler)
			{
				 db.EpneumaticCoupler.Remove(epneumaticcoupler);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class EmechanicalCouplersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EmechanicalCoupler> lEmechanicalCouplers = await db.EmechanicalCoupler.GetAllCompanyEmechanicalCouplers(id);
				 //return JsonConvert.SerializeObject(lEmechanicalCouplers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EmechanicalCoupler emechanicalcoupler)
			{
				 //Create
				 db.EmechanicalCoupler.Add(emechanicalcoupler);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(emechanicalcoupler);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EmechanicalCoupler emechanicalcoupler)
			{
				 //Update
				 db.EmechanicalCoupler.Update(emechanicalcoupler);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EmechanicalCoupler emechanicalcoupler)
			{
				 db.EmechanicalCoupler.Remove(emechanicalcoupler);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

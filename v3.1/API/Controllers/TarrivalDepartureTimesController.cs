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
	public class TarrivalDepartureTimessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TarrivalDepartureTimes> lTarrivalDepartureTimess = await db.TarrivalDepartureTimes.GetAllCompanyTarrivalDepartureTimess(id);
				 //return JsonConvert.SerializeObject(lTarrivalDepartureTimess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TarrivalDepartureTimes tarrivaldeparturetimes)
			{
				 //Create
				 db.TarrivalDepartureTimes.Add(tarrivaldeparturetimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tarrivaldeparturetimes);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TarrivalDepartureTimes tarrivaldeparturetimes)
			{
				 //Update
				 db.TarrivalDepartureTimes.Update(tarrivaldeparturetimes);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TarrivalDepartureTimes tarrivaldeparturetimes)
			{
				 db.TarrivalDepartureTimes.Remove(tarrivaldeparturetimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class EarrivalDepartureTimessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EarrivalDepartureTimes> lEarrivalDepartureTimess = await db.EarrivalDepartureTimes.GetAllCompanyEarrivalDepartureTimess(id);
				 //return JsonConvert.SerializeObject(lEarrivalDepartureTimess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EarrivalDepartureTimes earrivaldeparturetimes)
			{
				 //Create
				 db.EarrivalDepartureTimes.Add(earrivaldeparturetimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(earrivaldeparturetimes);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EarrivalDepartureTimes earrivaldeparturetimes)
			{
				 //Update
				 db.EarrivalDepartureTimes.Update(earrivaldeparturetimes);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EarrivalDepartureTimes earrivaldeparturetimes)
			{
				 db.EarrivalDepartureTimes.Remove(earrivaldeparturetimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

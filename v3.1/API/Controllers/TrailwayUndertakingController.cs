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
	public class TrailwayUndertakingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TrailwayUndertaking> lTrailwayUndertakings = await db.TrailwayUndertaking.GetAllCompanyTrailwayUndertakings(id);
				 //return JsonConvert.SerializeObject(lTrailwayUndertakings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TrailwayUndertaking trailwayundertaking)
			{
				 //Create
				 db.TrailwayUndertaking.Add(trailwayundertaking);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(trailwayundertaking);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TrailwayUndertaking trailwayundertaking)
			{
				 //Update
				 db.TrailwayUndertaking.Update(trailwayundertaking);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TrailwayUndertaking trailwayundertaking)
			{
				 db.TrailwayUndertaking.Remove(trailwayundertaking);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class TposInTracksController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TposInTrack> lTposInTracks = await db.TposInTrack.GetAllCompanyTposInTracks(id);
				 //return JsonConvert.SerializeObject(lTposInTracks.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TposInTrack tposintrack)
			{
				 //Create
				 db.TposInTrack.Add(tposintrack);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tposintrack);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TposInTrack tposintrack)
			{
				 //Update
				 db.TposInTrack.Update(tposintrack);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TposInTrack tposintrack)
			{
				 db.TposInTrack.Remove(tposintrack);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

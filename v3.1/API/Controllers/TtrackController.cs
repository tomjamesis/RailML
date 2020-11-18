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
	public class TtracksController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ttrack> lTtracks = await db.Ttrack.GetAllCompanyTtracks(id);
				 //return JsonConvert.SerializeObject(lTtracks.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ttrack ttrack)
			{
				 //Create
				 db.Ttrack.Add(ttrack);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrack);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ttrack ttrack)
			{
				 //Update
				 db.Ttrack.Update(ttrack);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ttrack ttrack)
			{
				 db.Ttrack.Remove(ttrack);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

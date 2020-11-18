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
	public class TrailNetworksController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TrailNetwork> lTrailNetworks = await db.TrailNetwork.GetAllCompanyTrailNetworks(id);
				 //return JsonConvert.SerializeObject(lTrailNetworks.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TrailNetwork trailnetwork)
			{
				 //Create
				 db.TrailNetwork.Add(trailnetwork);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(trailnetwork);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TrailNetwork trailnetwork)
			{
				 //Update
				 db.TrailNetwork.Update(trailnetwork);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TrailNetwork trailnetwork)
			{
				 db.TrailNetwork.Remove(trailnetwork);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

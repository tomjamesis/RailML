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
	public class EtrackTopologysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrackTopology> lEtrackTopologys = await db.EtrackTopology.GetAllCompanyEtrackTopologys(id);
				 //return JsonConvert.SerializeObject(lEtrackTopologys.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrackTopology etracktopology)
			{
				 //Create
				 db.EtrackTopology.Add(etracktopology);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etracktopology);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrackTopology etracktopology)
			{
				 //Update
				 db.EtrackTopology.Update(etracktopology);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrackTopology etracktopology)
			{
				 db.EtrackTopology.Remove(etracktopology);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

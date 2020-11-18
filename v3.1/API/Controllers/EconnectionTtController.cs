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
	public class EconnectionTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EconnectionTt> lEconnectionTts = await db.EconnectionTt.GetAllCompanyEconnectionTts(id);
				 //return JsonConvert.SerializeObject(lEconnectionTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EconnectionTt econnectiontt)
			{
				 //Create
				 db.EconnectionTt.Add(econnectiontt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(econnectiontt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EconnectionTt econnectiontt)
			{
				 //Update
				 db.EconnectionTt.Update(econnectiontt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EconnectionTt econnectiontt)
			{
				 db.EconnectionTt.Remove(econnectiontt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

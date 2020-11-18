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
	public class TconnectionTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TconnectionTt> lTconnectionTts = await db.TconnectionTt.GetAllCompanyTconnectionTts(id);
				 //return JsonConvert.SerializeObject(lTconnectionTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TconnectionTt tconnectiontt)
			{
				 //Create
				 db.TconnectionTt.Add(tconnectiontt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tconnectiontt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TconnectionTt tconnectiontt)
			{
				 //Update
				 db.TconnectionTt.Update(tconnectiontt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TconnectionTt tconnectiontt)
			{
				 db.TconnectionTt.Remove(tconnectiontt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

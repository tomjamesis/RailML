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
	public class TrunTimessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TrunTimes> lTrunTimess = await db.TrunTimes.GetAllCompanyTrunTimess(id);
				 //return JsonConvert.SerializeObject(lTrunTimess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TrunTimes truntimes)
			{
				 //Create
				 db.TrunTimes.Add(truntimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(truntimes);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TrunTimes truntimes)
			{
				 //Update
				 db.TrunTimes.Update(truntimes);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TrunTimes truntimes)
			{
				 db.TrunTimes.Remove(truntimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

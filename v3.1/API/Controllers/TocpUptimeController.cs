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
	public class TocpUptimesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpUptime> lTocpUptimes = await db.TocpUptime.GetAllCompanyTocpUptimes(id);
				 //return JsonConvert.SerializeObject(lTocpUptimes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpUptime tocpuptime)
			{
				 //Create
				 db.TocpUptime.Add(tocpuptime);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocpuptime);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpUptime tocpuptime)
			{
				 //Update
				 db.TocpUptime.Update(tocpuptime);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpUptime tocpuptime)
			{
				 db.TocpUptime.Remove(tocpuptime);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

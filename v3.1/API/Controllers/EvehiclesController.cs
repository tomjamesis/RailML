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
	public class EvehiclessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Evehicles> lEvehicless = await db.Evehicles.GetAllCompanyEvehicless(id);
				 //return JsonConvert.SerializeObject(lEvehicless.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Evehicles evehicles)
			{
				 //Create
				 db.Evehicles.Add(evehicles);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(evehicles);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Evehicles evehicles)
			{
				 //Update
				 db.Evehicles.Update(evehicles);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Evehicles evehicles)
			{
				 db.Evehicles.Remove(evehicles);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

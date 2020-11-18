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
	public class EvehiclesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Evehicle> lEvehicles = await db.Evehicle.GetAllCompanyEvehicles(id);
				 //return JsonConvert.SerializeObject(lEvehicles.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Evehicle evehicle)
			{
				 //Create
				 db.Evehicle.Add(evehicle);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(evehicle);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Evehicle evehicle)
			{
				 //Update
				 db.Evehicle.Update(evehicle);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Evehicle evehicle)
			{
				 db.Evehicle.Remove(evehicle);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

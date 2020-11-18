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
	public class TwindingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Twinding> lTwindings = await db.Twinding.GetAllCompanyTwindings(id);
				 //return JsonConvert.SerializeObject(lTwindings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Twinding twinding)
			{
				 //Create
				 db.Twinding.Add(twinding);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(twinding);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Twinding twinding)
			{
				 //Update
				 db.Twinding.Update(twinding);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Twinding twinding)
			{
				 db.Twinding.Remove(twinding);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

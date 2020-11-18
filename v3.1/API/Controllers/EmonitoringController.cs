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
	public class EmonitoringsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Emonitoring> lEmonitorings = await db.Emonitoring.GetAllCompanyEmonitorings(id);
				 //return JsonConvert.SerializeObject(lEmonitorings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Emonitoring emonitoring)
			{
				 //Create
				 db.Emonitoring.Add(emonitoring);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(emonitoring);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Emonitoring emonitoring)
			{
				 //Update
				 db.Emonitoring.Update(emonitoring);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Emonitoring emonitoring)
			{
				 db.Emonitoring.Remove(emonitoring);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

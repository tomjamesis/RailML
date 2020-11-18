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
	public class TwagonsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Twagon> lTwagons = await db.Twagon.GetAllCompanyTwagons(id);
				 //return JsonConvert.SerializeObject(lTwagons.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Twagon twagon)
			{
				 //Create
				 db.Twagon.Add(twagon);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(twagon);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Twagon twagon)
			{
				 //Update
				 db.Twagon.Update(twagon);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Twagon twagon)
			{
				 db.Twagon.Remove(twagon);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

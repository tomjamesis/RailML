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
	public class EwagonsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ewagon> lEwagons = await db.Ewagon.GetAllCompanyEwagons(id);
				 //return JsonConvert.SerializeObject(lEwagons.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ewagon ewagon)
			{
				 //Create
				 db.Ewagon.Add(ewagon);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ewagon);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ewagon ewagon)
			{
				 //Update
				 db.Ewagon.Update(ewagon);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ewagon ewagon)
			{
				 db.Ewagon.Remove(ewagon);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

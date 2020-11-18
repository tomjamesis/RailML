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
	public class TgeoCoordsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TgeoCoord> lTgeoCoords = await db.TgeoCoord.GetAllCompanyTgeoCoords(id);
				 //return JsonConvert.SerializeObject(lTgeoCoords.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TgeoCoord tgeocoord)
			{
				 //Create
				 db.TgeoCoord.Add(tgeocoord);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tgeocoord);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TgeoCoord tgeocoord)
			{
				 //Update
				 db.TgeoCoord.Update(tgeocoord);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TgeoCoord tgeocoord)
			{
				 db.TgeoCoord.Remove(tgeocoord);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

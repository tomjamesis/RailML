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
	public class TgangwaysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tgangway> lTgangways = await db.Tgangway.GetAllCompanyTgangways(id);
				 //return JsonConvert.SerializeObject(lTgangways.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tgangway tgangway)
			{
				 //Create
				 db.Tgangway.Add(tgangway);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tgangway);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tgangway tgangway)
			{
				 //Update
				 db.Tgangway.Update(tgangway);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tgangway tgangway)
			{
				 db.Tgangway.Remove(tgangway);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

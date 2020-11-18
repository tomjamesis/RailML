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
	public class TgaugesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tgauge> lTgauges = await db.Tgauge.GetAllCompanyTgauges(id);
				 //return JsonConvert.SerializeObject(lTgauges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tgauge tgauge)
			{
				 //Create
				 db.Tgauge.Add(tgauge);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tgauge);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tgauge tgauge)
			{
				 //Update
				 db.Tgauge.Update(tgauge);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tgauge tgauge)
			{
				 db.Tgauge.Remove(tgauge);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

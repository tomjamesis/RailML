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
	public class TgaugeChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TgaugeChange> lTgaugeChanges = await db.TgaugeChange.GetAllCompanyTgaugeChanges(id);
				 //return JsonConvert.SerializeObject(lTgaugeChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TgaugeChange tgaugechange)
			{
				 //Create
				 db.TgaugeChange.Add(tgaugechange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tgaugechange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TgaugeChange tgaugechange)
			{
				 //Update
				 db.TgaugeChange.Update(tgaugechange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TgaugeChange tgaugechange)
			{
				 db.TgaugeChange.Remove(tgaugechange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

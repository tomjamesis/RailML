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
	public class TownerChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TownerChange> lTownerChanges = await db.TownerChange.GetAllCompanyTownerChanges(id);
				 //return JsonConvert.SerializeObject(lTownerChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TownerChange townerchange)
			{
				 //Create
				 db.TownerChange.Add(townerchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(townerchange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TownerChange townerchange)
			{
				 //Update
				 db.TownerChange.Update(townerchange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TownerChange townerchange)
			{
				 db.TownerChange.Remove(townerchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

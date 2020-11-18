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
	public class ToperatingDayDeviancesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ToperatingDayDeviance> lToperatingDayDeviances = await db.ToperatingDayDeviance.GetAllCompanyToperatingDayDeviances(id);
				 //return JsonConvert.SerializeObject(lToperatingDayDeviances.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ToperatingDayDeviance toperatingdaydeviance)
			{
				 //Create
				 db.ToperatingDayDeviance.Add(toperatingdaydeviance);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(toperatingdaydeviance);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ToperatingDayDeviance toperatingdaydeviance)
			{
				 //Update
				 db.ToperatingDayDeviance.Update(toperatingdaydeviance);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ToperatingDayDeviance toperatingdaydeviance)
			{
				 db.ToperatingDayDeviance.Remove(toperatingdaydeviance);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

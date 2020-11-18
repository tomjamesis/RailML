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
	public class ToperatingDaysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ToperatingDay> lToperatingDays = await db.ToperatingDay.GetAllCompanyToperatingDays(id);
				 //return JsonConvert.SerializeObject(lToperatingDays.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ToperatingDay toperatingday)
			{
				 //Create
				 db.ToperatingDay.Add(toperatingday);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(toperatingday);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ToperatingDay toperatingday)
			{
				 //Update
				 db.ToperatingDay.Update(toperatingday);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ToperatingDay toperatingday)
			{
				 db.ToperatingDay.Remove(toperatingday);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

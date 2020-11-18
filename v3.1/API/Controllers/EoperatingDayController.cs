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
	public class EoperatingDaysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EoperatingDay> lEoperatingDays = await db.EoperatingDay.GetAllCompanyEoperatingDays(id);
				 //return JsonConvert.SerializeObject(lEoperatingDays.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EoperatingDay eoperatingday)
			{
				 //Create
				 db.EoperatingDay.Add(eoperatingday);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eoperatingday);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EoperatingDay eoperatingday)
			{
				 //Update
				 db.EoperatingDay.Update(eoperatingday);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EoperatingDay eoperatingday)
			{
				 db.EoperatingDay.Remove(eoperatingday);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

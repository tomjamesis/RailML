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
	public class TtimetablesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ttimetable> lTtimetables = await db.Ttimetable.GetAllCompanyTtimetables(id);
				 //return JsonConvert.SerializeObject(lTtimetables.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ttimetable ttimetable)
			{
				 //Create
				 db.Ttimetable.Add(ttimetable);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttimetable);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ttimetable ttimetable)
			{
				 //Update
				 db.Ttimetable.Update(ttimetable);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ttimetable ttimetable)
			{
				 db.Ttimetable.Remove(ttimetable);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

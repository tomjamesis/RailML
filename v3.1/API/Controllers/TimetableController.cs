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
	public class TimetablesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Timetable> lTimetables = await db.Timetable.GetAllCompanyTimetables(id);
				 //return JsonConvert.SerializeObject(lTimetables.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Timetable timetable)
			{
				 //Create
				 db.Timetable.Add(timetable);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(timetable);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Timetable timetable)
			{
				 //Update
				 db.Timetable.Update(timetable);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Timetable timetable)
			{
				 db.Timetable.Remove(timetable);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

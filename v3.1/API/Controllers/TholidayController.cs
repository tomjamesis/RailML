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
	public class TholidaysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tholiday> lTholidays = await db.Tholiday.GetAllCompanyTholidays(id);
				 //return JsonConvert.SerializeObject(lTholidays.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tholiday tholiday)
			{
				 //Create
				 db.Tholiday.Add(tholiday);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tholiday);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tholiday tholiday)
			{
				 //Update
				 db.Tholiday.Update(tholiday);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tholiday tholiday)
			{
				 db.Tholiday.Remove(tholiday);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

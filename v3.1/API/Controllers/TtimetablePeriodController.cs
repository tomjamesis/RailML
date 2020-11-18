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
	public class TtimetablePeriodsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtimetablePeriod> lTtimetablePeriods = await db.TtimetablePeriod.GetAllCompanyTtimetablePeriods(id);
				 //return JsonConvert.SerializeObject(lTtimetablePeriods.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtimetablePeriod ttimetableperiod)
			{
				 //Create
				 db.TtimetablePeriod.Add(ttimetableperiod);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttimetableperiod);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtimetablePeriod ttimetableperiod)
			{
				 //Update
				 db.TtimetablePeriod.Update(ttimetableperiod);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtimetablePeriod ttimetableperiod)
			{
				 db.TtimetablePeriod.Remove(ttimetableperiod);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

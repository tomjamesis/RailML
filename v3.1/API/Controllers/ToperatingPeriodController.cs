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
	public class ToperatingPeriodsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ToperatingPeriod> lToperatingPeriods = await db.ToperatingPeriod.GetAllCompanyToperatingPeriods(id);
				 //return JsonConvert.SerializeObject(lToperatingPeriods.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ToperatingPeriod toperatingperiod)
			{
				 //Create
				 db.ToperatingPeriod.Add(toperatingperiod);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(toperatingperiod);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ToperatingPeriod toperatingperiod)
			{
				 //Update
				 db.ToperatingPeriod.Update(toperatingperiod);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ToperatingPeriod toperatingperiod)
			{
				 db.ToperatingPeriod.Remove(toperatingperiod);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

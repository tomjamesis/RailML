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
	public class EoperatingPeriodsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EoperatingPeriod> lEoperatingPeriods = await db.EoperatingPeriod.GetAllCompanyEoperatingPeriods(id);
				 //return JsonConvert.SerializeObject(lEoperatingPeriods.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EoperatingPeriod eoperatingperiod)
			{
				 //Create
				 db.EoperatingPeriod.Add(eoperatingperiod);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eoperatingperiod);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EoperatingPeriod eoperatingperiod)
			{
				 //Update
				 db.EoperatingPeriod.Update(eoperatingperiod);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EoperatingPeriod eoperatingperiod)
			{
				 db.EoperatingPeriod.Remove(eoperatingperiod);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class EtimetablePeriodsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtimetablePeriod> lEtimetablePeriods = await db.EtimetablePeriod.GetAllCompanyEtimetablePeriods(id);
				 //return JsonConvert.SerializeObject(lEtimetablePeriods.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtimetablePeriod etimetableperiod)
			{
				 //Create
				 db.EtimetablePeriod.Add(etimetableperiod);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etimetableperiod);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtimetablePeriod etimetableperiod)
			{
				 //Update
				 db.EtimetablePeriod.Update(etimetableperiod);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtimetablePeriod etimetableperiod)
			{
				 db.EtimetablePeriod.Remove(etimetableperiod);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

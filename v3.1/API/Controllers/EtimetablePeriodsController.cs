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
	public class EtimetablePeriodssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtimetablePeriods> lEtimetablePeriodss = await db.EtimetablePeriods.GetAllCompanyEtimetablePeriodss(id);
				 //return JsonConvert.SerializeObject(lEtimetablePeriodss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtimetablePeriods etimetableperiods)
			{
				 //Create
				 db.EtimetablePeriods.Add(etimetableperiods);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etimetableperiods);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtimetablePeriods etimetableperiods)
			{
				 //Update
				 db.EtimetablePeriods.Update(etimetableperiods);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtimetablePeriods etimetableperiods)
			{
				 db.EtimetablePeriods.Remove(etimetableperiods);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

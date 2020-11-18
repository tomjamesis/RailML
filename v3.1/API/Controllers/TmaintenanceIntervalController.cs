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
	public class TmaintenanceIntervalsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TmaintenanceInterval> lTmaintenanceIntervals = await db.TmaintenanceInterval.GetAllCompanyTmaintenanceIntervals(id);
				 //return JsonConvert.SerializeObject(lTmaintenanceIntervals.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TmaintenanceInterval tmaintenanceinterval)
			{
				 //Create
				 db.TmaintenanceInterval.Add(tmaintenanceinterval);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmaintenanceinterval);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TmaintenanceInterval tmaintenanceinterval)
			{
				 //Update
				 db.TmaintenanceInterval.Update(tmaintenanceinterval);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TmaintenanceInterval tmaintenanceinterval)
			{
				 db.TmaintenanceInterval.Remove(tmaintenanceinterval);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

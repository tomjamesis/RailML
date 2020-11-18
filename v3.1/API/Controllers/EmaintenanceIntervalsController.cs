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
	public class EmaintenanceIntervalssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EmaintenanceIntervals> lEmaintenanceIntervalss = await db.EmaintenanceIntervals.GetAllCompanyEmaintenanceIntervalss(id);
				 //return JsonConvert.SerializeObject(lEmaintenanceIntervalss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EmaintenanceIntervals emaintenanceintervals)
			{
				 //Create
				 db.EmaintenanceIntervals.Add(emaintenanceintervals);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(emaintenanceintervals);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EmaintenanceIntervals emaintenanceintervals)
			{
				 //Update
				 db.EmaintenanceIntervals.Update(emaintenanceintervals);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EmaintenanceIntervals emaintenanceintervals)
			{
				 db.EmaintenanceIntervals.Remove(emaintenanceintervals);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

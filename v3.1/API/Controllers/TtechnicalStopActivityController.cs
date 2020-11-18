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
	public class TtechnicalStopActivitysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtechnicalStopActivity> lTtechnicalStopActivitys = await db.TtechnicalStopActivity.GetAllCompanyTtechnicalStopActivitys(id);
				 //return JsonConvert.SerializeObject(lTtechnicalStopActivitys.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtechnicalStopActivity ttechnicalstopactivity)
			{
				 //Create
				 db.TtechnicalStopActivity.Add(ttechnicalstopactivity);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttechnicalstopactivity);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtechnicalStopActivity ttechnicalstopactivity)
			{
				 //Update
				 db.TtechnicalStopActivity.Update(ttechnicalstopactivity);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtechnicalStopActivity ttechnicalstopactivity)
			{
				 db.TtechnicalStopActivity.Remove(ttechnicalstopactivity);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

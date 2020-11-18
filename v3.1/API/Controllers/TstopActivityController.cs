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
	public class TstopActivitysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstopActivity> lTstopActivitys = await db.TstopActivity.GetAllCompanyTstopActivitys(id);
				 //return JsonConvert.SerializeObject(lTstopActivitys.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstopActivity tstopactivity)
			{
				 //Create
				 db.TstopActivity.Add(tstopactivity);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstopactivity);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstopActivity tstopactivity)
			{
				 //Update
				 db.TstopActivity.Update(tstopactivity);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstopActivity tstopactivity)
			{
				 db.TstopActivity.Remove(tstopactivity);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

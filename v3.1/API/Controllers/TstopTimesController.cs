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
	public class TstopTimessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstopTimes> lTstopTimess = await db.TstopTimes.GetAllCompanyTstopTimess(id);
				 //return JsonConvert.SerializeObject(lTstopTimess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstopTimes tstoptimes)
			{
				 //Create
				 db.TstopTimes.Add(tstoptimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstoptimes);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstopTimes tstoptimes)
			{
				 //Update
				 db.TstopTimes.Update(tstoptimes);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstopTimes tstoptimes)
			{
				 db.TstopTimes.Remove(tstoptimes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

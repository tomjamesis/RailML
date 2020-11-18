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
	public class TsignalSpeedsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsignalSpeed> lTsignalSpeeds = await db.TsignalSpeed.GetAllCompanyTsignalSpeeds(id);
				 //return JsonConvert.SerializeObject(lTsignalSpeeds.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsignalSpeed tsignalspeed)
			{
				 //Create
				 db.TsignalSpeed.Add(tsignalspeed);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignalspeed);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsignalSpeed tsignalspeed)
			{
				 //Update
				 db.TsignalSpeed.Update(tsignalspeed);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsignalSpeed tsignalspeed)
			{
				 db.TsignalSpeed.Remove(tsignalspeed);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

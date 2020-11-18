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
	public class TpassengerFlowSpeedsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TpassengerFlowSpeed> lTpassengerFlowSpeeds = await db.TpassengerFlowSpeed.GetAllCompanyTpassengerFlowSpeeds(id);
				 //return JsonConvert.SerializeObject(lTpassengerFlowSpeeds.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TpassengerFlowSpeed tpassengerflowspeed)
			{
				 //Create
				 db.TpassengerFlowSpeed.Add(tpassengerflowspeed);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tpassengerflowspeed);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TpassengerFlowSpeed tpassengerflowspeed)
			{
				 //Update
				 db.TpassengerFlowSpeed.Update(tpassengerflowspeed);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TpassengerFlowSpeed tpassengerflowspeed)
			{
				 db.TpassengerFlowSpeed.Remove(tpassengerflowspeed);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

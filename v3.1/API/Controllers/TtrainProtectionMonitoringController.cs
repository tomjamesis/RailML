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
	public class TtrainProtectionMonitoringsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainProtectionMonitoring> lTtrainProtectionMonitorings = await db.TtrainProtectionMonitoring.GetAllCompanyTtrainProtectionMonitorings(id);
				 //return JsonConvert.SerializeObject(lTtrainProtectionMonitorings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainProtectionMonitoring ttrainprotectionmonitoring)
			{
				 //Create
				 db.TtrainProtectionMonitoring.Add(ttrainprotectionmonitoring);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainprotectionmonitoring);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainProtectionMonitoring ttrainprotectionmonitoring)
			{
				 //Update
				 db.TtrainProtectionMonitoring.Update(ttrainprotectionmonitoring);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainProtectionMonitoring ttrainprotectionmonitoring)
			{
				 db.TtrainProtectionMonitoring.Remove(ttrainprotectionmonitoring);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

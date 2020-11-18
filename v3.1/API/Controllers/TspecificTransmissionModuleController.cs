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
	public class TspecificTransmissionModulesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TspecificTransmissionModule> lTspecificTransmissionModules = await db.TspecificTransmissionModule.GetAllCompanyTspecificTransmissionModules(id);
				 //return JsonConvert.SerializeObject(lTspecificTransmissionModules.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TspecificTransmissionModule tspecifictransmissionmodule)
			{
				 //Create
				 db.TspecificTransmissionModule.Add(tspecifictransmissionmodule);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tspecifictransmissionmodule);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TspecificTransmissionModule tspecifictransmissionmodule)
			{
				 //Update
				 db.TspecificTransmissionModule.Update(tspecifictransmissionmodule);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TspecificTransmissionModule tspecifictransmissionmodule)
			{
				 db.TspecificTransmissionModule.Remove(tspecifictransmissionmodule);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

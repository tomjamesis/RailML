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
	public class EvehicleBrakesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EvehicleBrake> lEvehicleBrakes = await db.EvehicleBrake.GetAllCompanyEvehicleBrakes(id);
				 //return JsonConvert.SerializeObject(lEvehicleBrakes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EvehicleBrake evehiclebrake)
			{
				 //Create
				 db.EvehicleBrake.Add(evehiclebrake);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(evehiclebrake);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EvehicleBrake evehiclebrake)
			{
				 //Update
				 db.EvehicleBrake.Update(evehiclebrake);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EvehicleBrake evehiclebrake)
			{
				 db.EvehicleBrake.Remove(evehiclebrake);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

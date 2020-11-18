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
	public class EvehicleBrakessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EvehicleBrakes> lEvehicleBrakess = await db.EvehicleBrakes.GetAllCompanyEvehicleBrakess(id);
				 //return JsonConvert.SerializeObject(lEvehicleBrakess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EvehicleBrakes evehiclebrakes)
			{
				 //Create
				 db.EvehicleBrakes.Add(evehiclebrakes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(evehiclebrakes);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EvehicleBrakes evehiclebrakes)
			{
				 //Update
				 db.EvehicleBrakes.Update(evehiclebrakes);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EvehicleBrakes evehiclebrakes)
			{
				 db.EvehicleBrakes.Remove(evehiclebrakes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

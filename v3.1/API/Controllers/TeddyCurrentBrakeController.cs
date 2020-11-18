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
	public class TeddyCurrentBrakesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TeddyCurrentBrake> lTeddyCurrentBrakes = await db.TeddyCurrentBrake.GetAllCompanyTeddyCurrentBrakes(id);
				 //return JsonConvert.SerializeObject(lTeddyCurrentBrakes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TeddyCurrentBrake teddycurrentbrake)
			{
				 //Create
				 db.TeddyCurrentBrake.Add(teddycurrentbrake);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(teddycurrentbrake);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TeddyCurrentBrake teddycurrentbrake)
			{
				 //Update
				 db.TeddyCurrentBrake.Update(teddycurrentbrake);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TeddyCurrentBrake teddycurrentbrake)
			{
				 db.TeddyCurrentBrake.Remove(teddycurrentbrake);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

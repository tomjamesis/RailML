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
	public class TvehiclesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tvehicle> lTvehicles = await db.Tvehicle.GetAllCompanyTvehicles(id);
				 //return JsonConvert.SerializeObject(lTvehicles.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tvehicle tvehicle)
			{
				 //Create
				 db.Tvehicle.Add(tvehicle);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tvehicle);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tvehicle tvehicle)
			{
				 //Update
				 db.Tvehicle.Update(tvehicle);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tvehicle tvehicle)
			{
				 db.Tvehicle.Remove(tvehicle);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

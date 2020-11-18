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
	public class TvehicleIdentificationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TvehicleIdentification> lTvehicleIdentifications = await db.TvehicleIdentification.GetAllCompanyTvehicleIdentifications(id);
				 //return JsonConvert.SerializeObject(lTvehicleIdentifications.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TvehicleIdentification tvehicleidentification)
			{
				 //Create
				 db.TvehicleIdentification.Add(tvehicleidentification);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tvehicleidentification);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TvehicleIdentification tvehicleidentification)
			{
				 //Update
				 db.TvehicleIdentification.Update(tvehicleidentification);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TvehicleIdentification tvehicleidentification)
			{
				 db.TvehicleIdentification.Remove(tvehicleidentification);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

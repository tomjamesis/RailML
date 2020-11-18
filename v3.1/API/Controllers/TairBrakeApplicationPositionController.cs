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
	public class TairBrakeApplicationPositionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TairBrakeApplicationPosition> lTairBrakeApplicationPositions = await db.TairBrakeApplicationPosition.GetAllCompanyTairBrakeApplicationPositions(id);
				 //return JsonConvert.SerializeObject(lTairBrakeApplicationPositions.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TairBrakeApplicationPosition tairbrakeapplicationposition)
			{
				 //Create
				 db.TairBrakeApplicationPosition.Add(tairbrakeapplicationposition);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tairbrakeapplicationposition);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TairBrakeApplicationPosition tairbrakeapplicationposition)
			{
				 //Update
				 db.TairBrakeApplicationPosition.Update(tairbrakeapplicationposition);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TairBrakeApplicationPosition tairbrakeapplicationposition)
			{
				 db.TairBrakeApplicationPosition.Remove(tairbrakeapplicationposition);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

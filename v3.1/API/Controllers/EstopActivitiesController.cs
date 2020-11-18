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
	public class EstopActivitiessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EstopActivities> lEstopActivitiess = await db.EstopActivities.GetAllCompanyEstopActivitiess(id);
				 //return JsonConvert.SerializeObject(lEstopActivitiess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EstopActivities estopactivities)
			{
				 //Create
				 db.EstopActivities.Add(estopactivities);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(estopactivities);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EstopActivities estopactivities)
			{
				 //Update
				 db.EstopActivities.Update(estopactivities);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EstopActivities estopactivities)
			{
				 db.EstopActivities.Remove(estopactivities);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

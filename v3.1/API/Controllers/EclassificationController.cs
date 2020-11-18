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
	public class EclassificationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Eclassification> lEclassifications = await db.Eclassification.GetAllCompanyEclassifications(id);
				 //return JsonConvert.SerializeObject(lEclassifications.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Eclassification eclassification)
			{
				 //Create
				 db.Eclassification.Add(eclassification);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eclassification);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Eclassification eclassification)
			{
				 //Update
				 db.Eclassification.Update(eclassification);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Eclassification eclassification)
			{
				 db.Eclassification.Remove(eclassification);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class EcrossingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ecrossing> lEcrossings = await db.Ecrossing.GetAllCompanyEcrossings(id);
				 //return JsonConvert.SerializeObject(lEcrossings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ecrossing ecrossing)
			{
				 //Create
				 db.Ecrossing.Add(ecrossing);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ecrossing);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ecrossing ecrossing)
			{
				 //Update
				 db.Ecrossing.Update(ecrossing);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ecrossing ecrossing)
			{
				 db.Ecrossing.Remove(ecrossing);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

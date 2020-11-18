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
	public class EspeedssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Espeeds> lEspeedss = await db.Espeeds.GetAllCompanyEspeedss(id);
				 //return JsonConvert.SerializeObject(lEspeedss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Espeeds espeeds)
			{
				 //Create
				 db.Espeeds.Add(espeeds);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(espeeds);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Espeeds espeeds)
			{
				 //Update
				 db.Espeeds.Update(espeeds);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Espeeds espeeds)
			{
				 db.Espeeds.Remove(espeeds);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

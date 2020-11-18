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
	public class EgeoMappingssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EgeoMappings> lEgeoMappingss = await db.EgeoMappings.GetAllCompanyEgeoMappingss(id);
				 //return JsonConvert.SerializeObject(lEgeoMappingss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EgeoMappings egeomappings)
			{
				 //Create
				 db.EgeoMappings.Add(egeomappings);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(egeomappings);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EgeoMappings egeomappings)
			{
				 //Update
				 db.EgeoMappings.Update(egeomappings);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EgeoMappings egeomappings)
			{
				 db.EgeoMappings.Remove(egeomappings);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

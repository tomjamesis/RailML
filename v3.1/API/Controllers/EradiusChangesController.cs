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
	public class EradiusChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EradiusChanges> lEradiusChangess = await db.EradiusChanges.GetAllCompanyEradiusChangess(id);
				 //return JsonConvert.SerializeObject(lEradiusChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EradiusChanges eradiuschanges)
			{
				 //Create
				 db.EradiusChanges.Add(eradiuschanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eradiuschanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EradiusChanges eradiuschanges)
			{
				 //Update
				 db.EradiusChanges.Update(eradiuschanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EradiusChanges eradiuschanges)
			{
				 db.EradiusChanges.Remove(eradiuschanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

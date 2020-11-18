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
	public class EcrossSectionssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EcrossSections> lEcrossSectionss = await db.EcrossSections.GetAllCompanyEcrossSectionss(id);
				 //return JsonConvert.SerializeObject(lEcrossSectionss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EcrossSections ecrosssections)
			{
				 //Create
				 db.EcrossSections.Add(ecrosssections);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ecrosssections);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EcrossSections ecrosssections)
			{
				 //Update
				 db.EcrossSections.Update(ecrosssections);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EcrossSections ecrosssections)
			{
				 db.EcrossSections.Remove(ecrosssections);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

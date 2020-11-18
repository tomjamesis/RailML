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
	public class EcouplerssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ecouplers> lEcouplerss = await db.Ecouplers.GetAllCompanyEcouplerss(id);
				 //return JsonConvert.SerializeObject(lEcouplerss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ecouplers ecouplers)
			{
				 //Create
				 db.Ecouplers.Add(ecouplers);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ecouplers);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ecouplers ecouplers)
			{
				 //Update
				 db.Ecouplers.Update(ecouplers);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ecouplers ecouplers)
			{
				 db.Ecouplers.Remove(ecouplers);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

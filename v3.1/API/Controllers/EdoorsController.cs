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
	public class EdoorssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Edoors> lEdoorss = await db.Edoors.GetAllCompanyEdoorss(id);
				 //return JsonConvert.SerializeObject(lEdoorss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Edoors edoors)
			{
				 //Create
				 db.Edoors.Add(edoors);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(edoors);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Edoors edoors)
			{
				 //Update
				 db.Edoors.Update(edoors);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Edoors edoors)
			{
				 db.Edoors.Remove(edoors);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

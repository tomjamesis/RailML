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
	public class EconnectionssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Econnections> lEconnectionss = await db.Econnections.GetAllCompanyEconnectionss(id);
				 //return JsonConvert.SerializeObject(lEconnectionss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Econnections econnections)
			{
				 //Create
				 db.Econnections.Add(econnections);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(econnections);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Econnections econnections)
			{
				 //Update
				 db.Econnections.Update(econnections);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Econnections econnections)
			{
				 db.Econnections.Remove(econnections);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

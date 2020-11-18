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
	public class EswitchsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Eswitch> lEswitchs = await db.Eswitch.GetAllCompanyEswitchs(id);
				 //return JsonConvert.SerializeObject(lEswitchs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Eswitch eswitch)
			{
				 //Create
				 db.Eswitch.Add(eswitch);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eswitch);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Eswitch eswitch)
			{
				 //Update
				 db.Eswitch.Update(eswitch);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Eswitch eswitch)
			{
				 db.Eswitch.Remove(eswitch);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

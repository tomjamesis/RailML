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
	public class TswitchsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tswitch> lTswitchs = await db.Tswitch.GetAllCompanyTswitchs(id);
				 //return JsonConvert.SerializeObject(lTswitchs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tswitch tswitch)
			{
				 //Create
				 db.Tswitch.Add(tswitch);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tswitch);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tswitch tswitch)
			{
				 //Update
				 db.Tswitch.Update(tswitch);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tswitch tswitch)
			{
				 db.Tswitch.Remove(tswitch);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

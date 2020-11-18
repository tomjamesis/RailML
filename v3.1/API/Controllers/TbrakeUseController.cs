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
	public class TbrakeUsesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TbrakeUse> lTbrakeUses = await db.TbrakeUse.GetAllCompanyTbrakeUses(id);
				 //return JsonConvert.SerializeObject(lTbrakeUses.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TbrakeUse tbrakeuse)
			{
				 //Create
				 db.TbrakeUse.Add(tbrakeuse);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbrakeuse);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TbrakeUse tbrakeuse)
			{
				 //Update
				 db.TbrakeUse.Update(tbrakeuse);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TbrakeUse tbrakeuse)
			{
				 db.TbrakeUse.Remove(tbrakeuse);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

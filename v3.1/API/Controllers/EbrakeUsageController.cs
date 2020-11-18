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
	public class EbrakeUsagesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EbrakeUsage> lEbrakeUsages = await db.EbrakeUsage.GetAllCompanyEbrakeUsages(id);
				 //return JsonConvert.SerializeObject(lEbrakeUsages.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EbrakeUsage ebrakeusage)
			{
				 //Create
				 db.EbrakeUsage.Add(ebrakeusage);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ebrakeusage);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EbrakeUsage ebrakeusage)
			{
				 //Update
				 db.EbrakeUsage.Update(ebrakeusage);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EbrakeUsage ebrakeusage)
			{
				 db.EbrakeUsage.Remove(ebrakeusage);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

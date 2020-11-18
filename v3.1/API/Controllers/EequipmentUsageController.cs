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
	public class EequipmentUsagesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EequipmentUsage> lEequipmentUsages = await db.EequipmentUsage.GetAllCompanyEequipmentUsages(id);
				 //return JsonConvert.SerializeObject(lEequipmentUsages.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EequipmentUsage eequipmentusage)
			{
				 //Create
				 db.EequipmentUsage.Add(eequipmentusage);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eequipmentusage);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EequipmentUsage eequipmentusage)
			{
				 //Update
				 db.EequipmentUsage.Update(eequipmentusage);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EequipmentUsage eequipmentusage)
			{
				 db.EequipmentUsage.Remove(eequipmentusage);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

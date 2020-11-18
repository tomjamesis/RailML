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
	public class EloadLimitsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EloadLimit> lEloadLimits = await db.EloadLimit.GetAllCompanyEloadLimits(id);
				 //return JsonConvert.SerializeObject(lEloadLimits.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EloadLimit eloadlimit)
			{
				 //Create
				 db.EloadLimit.Add(eloadlimit);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eloadlimit);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EloadLimit eloadlimit)
			{
				 //Update
				 db.EloadLimit.Update(eloadlimit);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EloadLimit eloadlimit)
			{
				 db.EloadLimit.Remove(eloadlimit);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class TtrainProtectionChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainProtectionChange> lTtrainProtectionChanges = await db.TtrainProtectionChange.GetAllCompanyTtrainProtectionChanges(id);
				 //return JsonConvert.SerializeObject(lTtrainProtectionChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainProtectionChange ttrainprotectionchange)
			{
				 //Create
				 db.TtrainProtectionChange.Add(ttrainprotectionchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainprotectionchange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainProtectionChange ttrainprotectionchange)
			{
				 //Update
				 db.TtrainProtectionChange.Update(ttrainprotectionchange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainProtectionChange ttrainprotectionchange)
			{
				 db.TtrainProtectionChange.Remove(ttrainprotectionchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

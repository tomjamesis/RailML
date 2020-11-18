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
	public class TtrainProtectionMediumsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainProtectionMedium> lTtrainProtectionMediums = await db.TtrainProtectionMedium.GetAllCompanyTtrainProtectionMediums(id);
				 //return JsonConvert.SerializeObject(lTtrainProtectionMediums.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainProtectionMedium ttrainprotectionmedium)
			{
				 //Create
				 db.TtrainProtectionMedium.Add(ttrainprotectionmedium);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainprotectionmedium);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainProtectionMedium ttrainprotectionmedium)
			{
				 //Update
				 db.TtrainProtectionMedium.Update(ttrainprotectionmedium);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainProtectionMedium ttrainprotectionmedium)
			{
				 db.TtrainProtectionMedium.Remove(ttrainprotectionmedium);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

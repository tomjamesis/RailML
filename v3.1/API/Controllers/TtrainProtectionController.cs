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
	public class TtrainProtectionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainProtection> lTtrainProtections = await db.TtrainProtection.GetAllCompanyTtrainProtections(id);
				 //return JsonConvert.SerializeObject(lTtrainProtections.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainProtection ttrainprotection)
			{
				 //Create
				 db.TtrainProtection.Add(ttrainprotection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainprotection);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainProtection ttrainprotection)
			{
				 //Update
				 db.TtrainProtection.Update(ttrainprotection);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainProtection ttrainprotection)
			{
				 db.TtrainProtection.Remove(ttrainprotection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

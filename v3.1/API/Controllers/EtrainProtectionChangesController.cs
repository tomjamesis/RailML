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
	public class EtrainProtectionChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrainProtectionChanges> lEtrainProtectionChangess = await db.EtrainProtectionChanges.GetAllCompanyEtrainProtectionChangess(id);
				 //return JsonConvert.SerializeObject(lEtrainProtectionChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrainProtectionChanges etrainprotectionchanges)
			{
				 //Create
				 db.EtrainProtectionChanges.Add(etrainprotectionchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrainprotectionchanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrainProtectionChanges etrainprotectionchanges)
			{
				 //Update
				 db.EtrainProtectionChanges.Update(etrainprotectionchanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrainProtectionChanges etrainprotectionchanges)
			{
				 db.EtrainProtectionChanges.Remove(etrainprotectionchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

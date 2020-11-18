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
	public class TnationalSystemsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TnationalSystem> lTnationalSystems = await db.TnationalSystem.GetAllCompanyTnationalSystems(id);
				 //return JsonConvert.SerializeObject(lTnationalSystems.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TnationalSystem tnationalsystem)
			{
				 //Create
				 db.TnationalSystem.Add(tnationalsystem);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tnationalsystem);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TnationalSystem tnationalsystem)
			{
				 //Update
				 db.TnationalSystem.Update(tnationalsystem);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TnationalSystem tnationalsystem)
			{
				 db.TnationalSystem.Remove(tnationalsystem);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

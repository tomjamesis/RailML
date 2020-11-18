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
	public class TelectrificationSystemsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TelectrificationSystem> lTelectrificationSystems = await db.TelectrificationSystem.GetAllCompanyTelectrificationSystems(id);
				 //return JsonConvert.SerializeObject(lTelectrificationSystems.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TelectrificationSystem telectrificationsystem)
			{
				 //Create
				 db.TelectrificationSystem.Add(telectrificationsystem);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(telectrificationsystem);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TelectrificationSystem telectrificationsystem)
			{
				 //Update
				 db.TelectrificationSystem.Update(telectrificationsystem);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TelectrificationSystem telectrificationsystem)
			{
				 db.TelectrificationSystem.Remove(telectrificationsystem);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

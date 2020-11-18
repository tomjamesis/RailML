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
	public class TlossessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tlosses> lTlossess = await db.Tlosses.GetAllCompanyTlossess(id);
				 //return JsonConvert.SerializeObject(lTlossess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tlosses tlosses)
			{
				 //Create
				 db.Tlosses.Add(tlosses);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tlosses);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tlosses tlosses)
			{
				 //Update
				 db.Tlosses.Update(tlosses);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tlosses tlosses)
			{
				 db.Tlosses.Remove(tlosses);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

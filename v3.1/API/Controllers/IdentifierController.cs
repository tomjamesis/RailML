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
	public class IdentifiersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Identifier> lIdentifiers = await db.Identifier.GetAllCompanyIdentifiers(id);
				 //return JsonConvert.SerializeObject(lIdentifiers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Identifier identifier)
			{
				 //Create
				 db.Identifier.Add(identifier);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(identifier);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Identifier identifier)
			{
				 //Update
				 db.Identifier.Update(identifier);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Identifier identifier)
			{
				 db.Identifier.Remove(identifier);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

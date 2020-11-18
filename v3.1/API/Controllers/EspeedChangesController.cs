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
	public class EspeedChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EspeedChanges> lEspeedChangess = await db.EspeedChanges.GetAllCompanyEspeedChangess(id);
				 //return JsonConvert.SerializeObject(lEspeedChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EspeedChanges espeedchanges)
			{
				 //Create
				 db.EspeedChanges.Add(espeedchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(espeedchanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EspeedChanges espeedchanges)
			{
				 //Update
				 db.EspeedChanges.Update(espeedchanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EspeedChanges espeedchanges)
			{
				 db.EspeedChanges.Remove(espeedchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

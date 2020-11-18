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
	public class EconnectionsTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EconnectionsTt> lEconnectionsTts = await db.EconnectionsTt.GetAllCompanyEconnectionsTts(id);
				 //return JsonConvert.SerializeObject(lEconnectionsTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EconnectionsTt econnectionstt)
			{
				 //Create
				 db.EconnectionsTt.Add(econnectionstt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(econnectionstt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EconnectionsTt econnectionstt)
			{
				 //Update
				 db.EconnectionsTt.Update(econnectionstt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EconnectionsTt econnectionstt)
			{
				 db.EconnectionsTt.Remove(econnectionstt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

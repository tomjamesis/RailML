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
	public class TspeedChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TspeedChange> lTspeedChanges = await db.TspeedChange.GetAllCompanyTspeedChanges(id);
				 //return JsonConvert.SerializeObject(lTspeedChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TspeedChange tspeedchange)
			{
				 //Create
				 db.TspeedChange.Add(tspeedchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tspeedchange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TspeedChange tspeedchange)
			{
				 //Update
				 db.TspeedChange.Update(tspeedchange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TspeedChange tspeedchange)
			{
				 db.TspeedChange.Remove(tspeedchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

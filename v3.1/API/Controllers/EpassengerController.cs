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
	public class EpassengersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Epassenger> lEpassengers = await db.Epassenger.GetAllCompanyEpassengers(id);
				 //return JsonConvert.SerializeObject(lEpassengers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Epassenger epassenger)
			{
				 //Create
				 db.Epassenger.Add(epassenger);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(epassenger);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Epassenger epassenger)
			{
				 //Update
				 db.Epassenger.Update(epassenger);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Epassenger epassenger)
			{
				 db.Epassenger.Remove(epassenger);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class TtiltingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ttilting> lTtiltings = await db.Ttilting.GetAllCompanyTtiltings(id);
				 //return JsonConvert.SerializeObject(lTtiltings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ttilting ttilting)
			{
				 //Create
				 db.Ttilting.Add(ttilting);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttilting);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ttilting ttilting)
			{
				 //Update
				 db.Ttilting.Update(ttilting);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ttilting ttilting)
			{
				 db.Ttilting.Remove(ttilting);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

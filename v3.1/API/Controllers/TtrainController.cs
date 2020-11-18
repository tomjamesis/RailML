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
	public class TtrainsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ttrain> lTtrains = await db.Ttrain.GetAllCompanyTtrains(id);
				 //return JsonConvert.SerializeObject(lTtrains.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ttrain ttrain)
			{
				 //Create
				 db.Ttrain.Add(ttrain);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrain);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ttrain ttrain)
			{
				 //Update
				 db.Ttrain.Update(ttrain);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ttrain ttrain)
			{
				 db.Ttrain.Remove(ttrain);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

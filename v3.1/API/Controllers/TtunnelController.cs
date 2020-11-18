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
	public class TtunnelsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Ttunnel> lTtunnels = await db.Ttunnel.GetAllCompanyTtunnels(id);
				 //return JsonConvert.SerializeObject(lTtunnels.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Ttunnel ttunnel)
			{
				 //Create
				 db.Ttunnel.Add(ttunnel);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttunnel);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Ttunnel ttunnel)
			{
				 //Update
				 db.Ttunnel.Update(ttunnel);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Ttunnel ttunnel)
			{
				 db.Ttunnel.Remove(ttunnel);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

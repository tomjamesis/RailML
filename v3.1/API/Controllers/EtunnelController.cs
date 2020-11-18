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
	public class EtunnelsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Etunnel> lEtunnels = await db.Etunnel.GetAllCompanyEtunnels(id);
				 //return JsonConvert.SerializeObject(lEtunnels.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Etunnel etunnel)
			{
				 //Create
				 db.Etunnel.Add(etunnel);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etunnel);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Etunnel etunnel)
			{
				 //Update
				 db.Etunnel.Update(etunnel);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Etunnel etunnel)
			{
				 db.Etunnel.Remove(etunnel);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

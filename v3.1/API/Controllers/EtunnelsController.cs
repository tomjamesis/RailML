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
	public class EtunnelssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Etunnels> lEtunnelss = await db.Etunnels.GetAllCompanyEtunnelss(id);
				 //return JsonConvert.SerializeObject(lEtunnelss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Etunnels etunnels)
			{
				 //Create
				 db.Etunnels.Add(etunnels);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etunnels);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Etunnels etunnels)
			{
				 //Update
				 db.Etunnels.Update(etunnels);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Etunnels etunnels)
			{
				 db.Etunnels.Remove(etunnels);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class EgeneralInfraAttributessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EgeneralInfraAttributes> lEgeneralInfraAttributess = await db.EgeneralInfraAttributes.GetAllCompanyEgeneralInfraAttributess(id);
				 //return JsonConvert.SerializeObject(lEgeneralInfraAttributess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EgeneralInfraAttributes egeneralinfraattributes)
			{
				 //Create
				 db.EgeneralInfraAttributes.Add(egeneralinfraattributes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(egeneralinfraattributes);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EgeneralInfraAttributes egeneralinfraattributes)
			{
				 //Update
				 db.EgeneralInfraAttributes.Update(egeneralinfraattributes);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EgeneralInfraAttributes egeneralinfraattributes)
			{
				 db.EgeneralInfraAttributes.Remove(egeneralinfraattributes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class EgeneralInfraAttributesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EgeneralInfraAttribute> lEgeneralInfraAttributes = await db.EgeneralInfraAttribute.GetAllCompanyEgeneralInfraAttributes(id);
				 //return JsonConvert.SerializeObject(lEgeneralInfraAttributes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EgeneralInfraAttribute egeneralinfraattribute)
			{
				 //Create
				 db.EgeneralInfraAttribute.Add(egeneralinfraattribute);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(egeneralinfraattribute);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EgeneralInfraAttribute egeneralinfraattribute)
			{
				 //Update
				 db.EgeneralInfraAttribute.Update(egeneralinfraattribute);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EgeneralInfraAttribute egeneralinfraattribute)
			{
				 db.EgeneralInfraAttribute.Remove(egeneralinfraattribute);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

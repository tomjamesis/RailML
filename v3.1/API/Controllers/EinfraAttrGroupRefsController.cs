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
	public class EinfraAttrGroupRefssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EinfraAttrGroupRefs> lEinfraAttrGroupRefss = await db.EinfraAttrGroupRefs.GetAllCompanyEinfraAttrGroupRefss(id);
				 //return JsonConvert.SerializeObject(lEinfraAttrGroupRefss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EinfraAttrGroupRefs einfraattrgrouprefs)
			{
				 //Create
				 db.EinfraAttrGroupRefs.Add(einfraattrgrouprefs);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(einfraattrgrouprefs);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EinfraAttrGroupRefs einfraattrgrouprefs)
			{
				 //Update
				 db.EinfraAttrGroupRefs.Update(einfraattrgrouprefs);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EinfraAttrGroupRefs einfraattrgrouprefs)
			{
				 db.EinfraAttrGroupRefs.Remove(einfraattrgrouprefs);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

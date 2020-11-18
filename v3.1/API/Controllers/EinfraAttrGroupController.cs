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
	public class EinfraAttrGroupsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EinfraAttrGroup> lEinfraAttrGroups = await db.EinfraAttrGroup.GetAllCompanyEinfraAttrGroups(id);
				 //return JsonConvert.SerializeObject(lEinfraAttrGroups.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EinfraAttrGroup einfraattrgroup)
			{
				 //Create
				 db.EinfraAttrGroup.Add(einfraattrgroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(einfraattrgroup);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EinfraAttrGroup einfraattrgroup)
			{
				 //Update
				 db.EinfraAttrGroup.Update(einfraattrgroup);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EinfraAttrGroup einfraattrgroup)
			{
				 db.EinfraAttrGroup.Remove(einfraattrgroup);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

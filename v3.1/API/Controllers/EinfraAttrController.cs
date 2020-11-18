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
	public class EinfraAttrsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EinfraAttr> lEinfraAttrs = await db.EinfraAttr.GetAllCompanyEinfraAttrs(id);
				 //return JsonConvert.SerializeObject(lEinfraAttrs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EinfraAttr einfraattr)
			{
				 //Create
				 db.EinfraAttr.Add(einfraattr);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(einfraattr);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EinfraAttr einfraattr)
			{
				 //Update
				 db.EinfraAttr.Update(einfraattr);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EinfraAttr einfraattr)
			{
				 db.EinfraAttr.Remove(einfraattr);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

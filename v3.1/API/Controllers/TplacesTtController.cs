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
	public class TplacesTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TplacesTt> lTplacesTts = await db.TplacesTt.GetAllCompanyTplacesTts(id);
				 //return JsonConvert.SerializeObject(lTplacesTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TplacesTt tplacestt)
			{
				 //Create
				 db.TplacesTt.Add(tplacestt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tplacestt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TplacesTt tplacestt)
			{
				 //Update
				 db.TplacesTt.Update(tplacestt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TplacesTt tplacestt)
			{
				 db.TplacesTt.Remove(tplacestt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

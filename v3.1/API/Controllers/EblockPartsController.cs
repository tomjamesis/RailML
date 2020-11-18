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
	public class EblockPartssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EblockParts> lEblockPartss = await db.EblockParts.GetAllCompanyEblockPartss(id);
				 //return JsonConvert.SerializeObject(lEblockPartss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EblockParts eblockparts)
			{
				 //Create
				 db.EblockParts.Add(eblockparts);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eblockparts);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EblockParts eblockparts)
			{
				 //Update
				 db.EblockParts.Update(eblockparts);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EblockParts eblockparts)
			{
				 db.EblockParts.Remove(eblockparts);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

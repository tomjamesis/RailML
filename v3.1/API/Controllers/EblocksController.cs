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
	public class EblockssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Eblocks> lEblockss = await db.Eblocks.GetAllCompanyEblockss(id);
				 //return JsonConvert.SerializeObject(lEblockss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Eblocks eblocks)
			{
				 //Create
				 db.Eblocks.Add(eblocks);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eblocks);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Eblocks eblocks)
			{
				 //Update
				 db.Eblocks.Update(eblocks);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Eblocks eblocks)
			{
				 db.Eblocks.Remove(eblocks);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

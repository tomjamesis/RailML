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
	public class TonOffsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TonOff> lTonOffs = await db.TonOff.GetAllCompanyTonOffs(id);
				 //return JsonConvert.SerializeObject(lTonOffs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TonOff tonoff)
			{
				 //Create
				 db.TonOff.Add(tonoff);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tonoff);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TonOff tonoff)
			{
				 //Update
				 db.TonOff.Update(tonoff);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TonOff tonoff)
			{
				 db.TonOff.Remove(tonoff);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

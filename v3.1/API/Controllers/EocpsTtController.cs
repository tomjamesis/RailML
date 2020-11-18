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
	public class EocpsTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EocpsTt> lEocpsTts = await db.EocpsTt.GetAllCompanyEocpsTts(id);
				 //return JsonConvert.SerializeObject(lEocpsTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EocpsTt eocpstt)
			{
				 //Create
				 db.EocpsTt.Add(eocpstt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eocpstt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EocpsTt eocpstt)
			{
				 //Update
				 db.EocpsTt.Update(eocpstt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EocpsTt eocpstt)
			{
				 db.EocpsTt.Remove(eocpstt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

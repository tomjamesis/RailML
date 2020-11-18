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
	public class EocpTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EocpTt> lEocpTts = await db.EocpTt.GetAllCompanyEocpTts(id);
				 //return JsonConvert.SerializeObject(lEocpTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EocpTt eocptt)
			{
				 //Create
				 db.EocpTt.Add(eocptt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eocptt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EocpTt eocptt)
			{
				 //Update
				 db.EocpTt.Update(eocptt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EocpTt eocptt)
			{
				 db.EocpTt.Remove(eocptt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

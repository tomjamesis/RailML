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
	public class TformationTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TformationTt> lTformationTts = await db.TformationTt.GetAllCompanyTformationTts(id);
				 //return JsonConvert.SerializeObject(lTformationTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TformationTt tformationtt)
			{
				 //Create
				 db.TformationTt.Add(tformationtt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tformationtt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TformationTt tformationtt)
			{
				 //Update
				 db.TformationTt.Update(tformationtt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TformationTt tformationtt)
			{
				 db.TformationTt.Remove(tformationtt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

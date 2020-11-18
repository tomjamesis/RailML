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
	public class TsectionTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsectionTt> lTsectionTts = await db.TsectionTt.GetAllCompanyTsectionTts(id);
				 //return JsonConvert.SerializeObject(lTsectionTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsectionTt tsectiontt)
			{
				 //Create
				 db.TsectionTt.Add(tsectiontt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsectiontt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsectionTt tsectiontt)
			{
				 //Update
				 db.TsectionTt.Update(tsectiontt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsectionTt tsectiontt)
			{
				 db.TsectionTt.Remove(tsectiontt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

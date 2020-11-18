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
	public class EformationTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EformationTt> lEformationTts = await db.EformationTt.GetAllCompanyEformationTts(id);
				 //return JsonConvert.SerializeObject(lEformationTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EformationTt eformationtt)
			{
				 //Create
				 db.EformationTt.Add(eformationtt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eformationtt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EformationTt eformationtt)
			{
				 //Update
				 db.EformationTt.Update(eformationtt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EformationTt eformationtt)
			{
				 db.EformationTt.Remove(eformationtt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

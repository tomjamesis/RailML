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
	public class EsectionTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EsectionTt> lEsectionTts = await db.EsectionTt.GetAllCompanyEsectionTts(id);
				 //return JsonConvert.SerializeObject(lEsectionTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EsectionTt esectiontt)
			{
				 //Create
				 db.EsectionTt.Add(esectiontt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(esectiontt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EsectionTt esectiontt)
			{
				 //Update
				 db.EsectionTt.Update(esectiontt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EsectionTt esectiontt)
			{
				 db.EsectionTt.Remove(esectiontt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

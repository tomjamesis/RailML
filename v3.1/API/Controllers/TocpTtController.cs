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
	public class TocpTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpTt> lTocpTts = await db.TocpTt.GetAllCompanyTocpTts(id);
				 //return JsonConvert.SerializeObject(lTocpTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpTt tocptt)
			{
				 //Create
				 db.TocpTt.Add(tocptt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocptt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpTt tocptt)
			{
				 //Update
				 db.TocpTt.Update(tocptt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpTt tocptt)
			{
				 db.TocpTt.Remove(tocptt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

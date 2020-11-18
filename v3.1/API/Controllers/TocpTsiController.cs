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
	public class TocpTsisController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TocpTsi> lTocpTsis = await db.TocpTsi.GetAllCompanyTocpTsis(id);
				 //return JsonConvert.SerializeObject(lTocpTsis.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TocpTsi tocptsi)
			{
				 //Create
				 db.TocpTsi.Add(tocptsi);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tocptsi);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TocpTsi tocptsi)
			{
				 //Update
				 db.TocpTsi.Update(tocptsi);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TocpTsi tocptsi)
			{
				 db.TocpTsi.Remove(tocptsi);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

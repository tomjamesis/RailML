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
	public class CoveragesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Coverage> lCoverages = await db.Coverage.GetAllCompanyCoverages(id);
				 //return JsonConvert.SerializeObject(lCoverages.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Coverage coverage)
			{
				 //Create
				 db.Coverage.Add(coverage);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(coverage);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Coverage coverage)
			{
				 //Update
				 db.Coverage.Update(coverage);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Coverage coverage)
			{
				 db.Coverage.Remove(coverage);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

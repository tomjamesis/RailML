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
	public class TspeedProfileRefRssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TspeedProfileRefRs> lTspeedProfileRefRss = await db.TspeedProfileRefRs.GetAllCompanyTspeedProfileRefRss(id);
				 //return JsonConvert.SerializeObject(lTspeedProfileRefRss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TspeedProfileRefRs tspeedprofilerefrs)
			{
				 //Create
				 db.TspeedProfileRefRs.Add(tspeedprofilerefrs);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tspeedprofilerefrs);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TspeedProfileRefRs tspeedprofilerefrs)
			{
				 //Update
				 db.TspeedProfileRefRs.Update(tspeedprofilerefrs);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TspeedProfileRefRs tspeedprofilerefrs)
			{
				 db.TspeedProfileRefRs.Remove(tspeedprofilerefrs);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

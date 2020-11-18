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
	public class EetcssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Eetcs> lEetcss = await db.Eetcs.GetAllCompanyEetcss(id);
				 //return JsonConvert.SerializeObject(lEetcss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Eetcs eetcs)
			{
				 //Create
				 db.Eetcs.Add(eetcs);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eetcs);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Eetcs eetcs)
			{
				 //Update
				 db.Eetcs.Update(eetcs);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Eetcs eetcs)
			{
				 db.Eetcs.Remove(eetcs);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

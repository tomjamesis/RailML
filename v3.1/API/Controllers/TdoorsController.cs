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
	public class TdoorssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tdoors> lTdoorss = await db.Tdoors.GetAllCompanyTdoorss(id);
				 //return JsonConvert.SerializeObject(lTdoorss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tdoors tdoors)
			{
				 //Create
				 db.Tdoors.Add(tdoors);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tdoors);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tdoors tdoors)
			{
				 //Update
				 db.Tdoors.Update(tdoors);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tdoors tdoors)
			{
				 db.Tdoors.Remove(tdoors);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class TplacessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tplaces> lTplacess = await db.Tplaces.GetAllCompanyTplacess(id);
				 //return JsonConvert.SerializeObject(lTplacess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tplaces tplaces)
			{
				 //Create
				 db.Tplaces.Add(tplaces);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tplaces);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tplaces tplaces)
			{
				 //Update
				 db.Tplaces.Update(tplaces);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tplaces tplaces)
			{
				 db.Tplaces.Remove(tplaces);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

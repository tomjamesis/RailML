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
	public class TinfrastructuresController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tinfrastructure> lTinfrastructures = await db.Tinfrastructure.GetAllCompanyTinfrastructures(id);
				 //return JsonConvert.SerializeObject(lTinfrastructures.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tinfrastructure tinfrastructure)
			{
				 //Create
				 db.Tinfrastructure.Add(tinfrastructure);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tinfrastructure);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tinfrastructure tinfrastructure)
			{
				 //Update
				 db.Tinfrastructure.Update(tinfrastructure);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tinfrastructure tinfrastructure)
			{
				 db.Tinfrastructure.Remove(tinfrastructure);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

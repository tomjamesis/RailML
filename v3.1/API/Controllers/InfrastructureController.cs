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
	public class InfrastructuresController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Infrastructure> lInfrastructures = await db.Infrastructure.GetAllCompanyInfrastructures(id);
				 //return JsonConvert.SerializeObject(lInfrastructures.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Infrastructure infrastructure)
			{
				 //Create
				 db.Infrastructure.Add(infrastructure);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(infrastructure);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Infrastructure infrastructure)
			{
				 //Update
				 db.Infrastructure.Update(infrastructure);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Infrastructure infrastructure)
			{
				 db.Infrastructure.Remove(infrastructure);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class ErosteringsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Erostering> lErosterings = await db.Erostering.GetAllCompanyErosterings(id);
				 //return JsonConvert.SerializeObject(lErosterings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Erostering erostering)
			{
				 //Create
				 db.Erostering.Add(erostering);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(erostering);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Erostering erostering)
			{
				 //Update
				 db.Erostering.Update(erostering);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Erostering erostering)
			{
				 db.Erostering.Remove(erostering);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

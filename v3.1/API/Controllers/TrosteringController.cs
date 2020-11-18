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
	public class TrosteringsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Trostering> lTrosterings = await db.Trostering.GetAllCompanyTrosterings(id);
				 //return JsonConvert.SerializeObject(lTrosterings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Trostering trostering)
			{
				 //Create
				 db.Trostering.Add(trostering);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(trostering);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Trostering trostering)
			{
				 //Update
				 db.Trostering.Update(trostering);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Trostering trostering)
			{
				 db.Trostering.Remove(trostering);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

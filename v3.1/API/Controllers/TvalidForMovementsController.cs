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
	public class TvalidForMovementssController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TvalidForMovements> lTvalidForMovementss = await db.TvalidForMovements.GetAllCompanyTvalidForMovementss(id);
				 //return JsonConvert.SerializeObject(lTvalidForMovementss.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TvalidForMovements tvalidformovements)
			{
				 //Create
				 db.TvalidForMovements.Add(tvalidformovements);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tvalidformovements);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TvalidForMovements tvalidformovements)
			{
				 //Update
				 db.TvalidForMovements.Update(tvalidformovements);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TvalidForMovements tvalidformovements)
			{
				 db.TvalidForMovements.Remove(tvalidformovements);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

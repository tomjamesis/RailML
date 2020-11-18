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
	public class TendPositionTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TendPositionType> lTendPositionTypes = await db.TendPositionType.GetAllCompanyTendPositionTypes(id);
				 //return JsonConvert.SerializeObject(lTendPositionTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TendPositionType tendpositiontype)
			{
				 //Create
				 db.TendPositionType.Add(tendpositiontype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tendpositiontype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TendPositionType tendpositiontype)
			{
				 //Update
				 db.TendPositionType.Update(tendpositiontype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TendPositionType tendpositiontype)
			{
				 db.TendPositionType.Remove(tendpositiontype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class TrelatedPositionTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TrelatedPositionType> lTrelatedPositionTypes = await db.TrelatedPositionType.GetAllCompanyTrelatedPositionTypes(id);
				 //return JsonConvert.SerializeObject(lTrelatedPositionTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TrelatedPositionType trelatedpositiontype)
			{
				 //Create
				 db.TrelatedPositionType.Add(trelatedpositiontype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(trelatedpositiontype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TrelatedPositionType trelatedpositiontype)
			{
				 //Update
				 db.TrelatedPositionType.Update(trelatedpositiontype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TrelatedPositionType trelatedpositiontype)
			{
				 db.TrelatedPositionType.Remove(trelatedpositiontype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

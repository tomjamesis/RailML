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
	public class TspeedRangeTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TspeedRangeType> lTspeedRangeTypes = await db.TspeedRangeType.GetAllCompanyTspeedRangeTypes(id);
				 //return JsonConvert.SerializeObject(lTspeedRangeTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TspeedRangeType tspeedrangetype)
			{
				 //Create
				 db.TspeedRangeType.Add(tspeedrangetype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tspeedrangetype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TspeedRangeType tspeedrangetype)
			{
				 //Update
				 db.TspeedRangeType.Update(tspeedrangetype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TspeedRangeType tspeedrangetype)
			{
				 db.TspeedRangeType.Remove(tspeedrangetype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

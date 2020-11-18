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
	public class TusageTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TusageType> lTusageTypes = await db.TusageType.GetAllCompanyTusageTypes(id);
				 //return JsonConvert.SerializeObject(lTusageTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TusageType tusagetype)
			{
				 //Create
				 db.TusageType.Add(tusagetype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tusagetype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TusageType tusagetype)
			{
				 //Update
				 db.TusageType.Update(tusagetype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TusageType tusagetype)
			{
				 db.TusageType.Remove(tusagetype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

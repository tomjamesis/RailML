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
	public class TtractionInvertersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtractionInverter> lTtractionInverters = await db.TtractionInverter.GetAllCompanyTtractionInverters(id);
				 //return JsonConvert.SerializeObject(lTtractionInverters.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtractionInverter ttractioninverter)
			{
				 //Create
				 db.TtractionInverter.Add(ttractioninverter);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttractioninverter);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtractionInverter ttractioninverter)
			{
				 //Update
				 db.TtractionInverter.Update(ttractioninverter);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtractionInverter ttractioninverter)
			{
				 db.TtractionInverter.Remove(ttractioninverter);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

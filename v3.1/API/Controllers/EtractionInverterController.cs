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
	public class EtractionInvertersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtractionInverter> lEtractionInverters = await db.EtractionInverter.GetAllCompanyEtractionInverters(id);
				 //return JsonConvert.SerializeObject(lEtractionInverters.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtractionInverter etractioninverter)
			{
				 //Create
				 db.EtractionInverter.Add(etractioninverter);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etractioninverter);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtractionInverter etractioninverter)
			{
				 //Update
				 db.EtractionInverter.Update(etractioninverter);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtractionInverter etractioninverter)
			{
				 db.EtractionInverter.Remove(etractioninverter);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

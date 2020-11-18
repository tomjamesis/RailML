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
	public class EpulsePatternValueTablesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EpulsePatternValueTable> lEpulsePatternValueTables = await db.EpulsePatternValueTable.GetAllCompanyEpulsePatternValueTables(id);
				 //return JsonConvert.SerializeObject(lEpulsePatternValueTables.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EpulsePatternValueTable epulsepatternvaluetable)
			{
				 //Create
				 db.EpulsePatternValueTable.Add(epulsepatternvaluetable);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(epulsepatternvaluetable);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EpulsePatternValueTable epulsepatternvaluetable)
			{
				 //Update
				 db.EpulsePatternValueTable.Update(epulsepatternvaluetable);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EpulsePatternValueTable epulsepatternvaluetable)
			{
				 db.EpulsePatternValueTable.Remove(epulsepatternvaluetable);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

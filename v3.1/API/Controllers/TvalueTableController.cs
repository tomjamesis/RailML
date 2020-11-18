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
	public class TvalueTablesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TvalueTable> lTvalueTables = await db.TvalueTable.GetAllCompanyTvalueTables(id);
				 //return JsonConvert.SerializeObject(lTvalueTables.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TvalueTable tvaluetable)
			{
				 //Create
				 db.TvalueTable.Add(tvaluetable);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tvaluetable);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TvalueTable tvaluetable)
			{
				 //Update
				 db.TvalueTable.Update(tvaluetable);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TvalueTable tvaluetable)
			{
				 db.TvalueTable.Remove(tvaluetable);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

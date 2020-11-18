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
	public class TcurveValueTablesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TcurveValueTable> lTcurveValueTables = await db.TcurveValueTable.GetAllCompanyTcurveValueTables(id);
				 //return JsonConvert.SerializeObject(lTcurveValueTables.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TcurveValueTable tcurvevaluetable)
			{
				 //Create
				 db.TcurveValueTable.Add(tcurvevaluetable);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcurvevaluetable);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TcurveValueTable tcurvevaluetable)
			{
				 //Update
				 db.TcurveValueTable.Update(tcurvevaluetable);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TcurveValueTable tcurvevaluetable)
			{
				 db.TcurveValueTable.Remove(tcurvevaluetable);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

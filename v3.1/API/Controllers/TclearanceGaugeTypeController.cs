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
	public class TclearanceGaugeTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TclearanceGaugeType> lTclearanceGaugeTypes = await db.TclearanceGaugeType.GetAllCompanyTclearanceGaugeTypes(id);
				 //return JsonConvert.SerializeObject(lTclearanceGaugeTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TclearanceGaugeType tclearancegaugetype)
			{
				 //Create
				 db.TclearanceGaugeType.Add(tclearancegaugetype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tclearancegaugetype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TclearanceGaugeType tclearancegaugetype)
			{
				 //Update
				 db.TclearanceGaugeType.Update(tclearancegaugetype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TclearanceGaugeType tclearancegaugetype)
			{
				 db.TclearanceGaugeType.Remove(tclearancegaugetype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

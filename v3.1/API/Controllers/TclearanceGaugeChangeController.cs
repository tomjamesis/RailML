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
	public class TclearanceGaugeChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TclearanceGaugeChange> lTclearanceGaugeChanges = await db.TclearanceGaugeChange.GetAllCompanyTclearanceGaugeChanges(id);
				 //return JsonConvert.SerializeObject(lTclearanceGaugeChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TclearanceGaugeChange tclearancegaugechange)
			{
				 //Create
				 db.TclearanceGaugeChange.Add(tclearancegaugechange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tclearancegaugechange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TclearanceGaugeChange tclearancegaugechange)
			{
				 //Update
				 db.TclearanceGaugeChange.Update(tclearancegaugechange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TclearanceGaugeChange tclearancegaugechange)
			{
				 db.TclearanceGaugeChange.Remove(tclearancegaugechange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

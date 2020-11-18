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
	public class EclearanceGaugeChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EclearanceGaugeChanges> lEclearanceGaugeChangess = await db.EclearanceGaugeChanges.GetAllCompanyEclearanceGaugeChangess(id);
				 //return JsonConvert.SerializeObject(lEclearanceGaugeChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EclearanceGaugeChanges eclearancegaugechanges)
			{
				 //Create
				 db.EclearanceGaugeChanges.Add(eclearancegaugechanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eclearancegaugechanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EclearanceGaugeChanges eclearancegaugechanges)
			{
				 //Update
				 db.EclearanceGaugeChanges.Update(eclearancegaugechanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EclearanceGaugeChanges eclearancegaugechanges)
			{
				 db.EclearanceGaugeChanges.Remove(eclearancegaugechanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

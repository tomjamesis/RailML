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
	public class EpassengerFacilityTtsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EpassengerFacilityTt> lEpassengerFacilityTts = await db.EpassengerFacilityTt.GetAllCompanyEpassengerFacilityTts(id);
				 //return JsonConvert.SerializeObject(lEpassengerFacilityTts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EpassengerFacilityTt epassengerfacilitytt)
			{
				 //Create
				 db.EpassengerFacilityTt.Add(epassengerfacilitytt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(epassengerfacilitytt);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EpassengerFacilityTt epassengerfacilitytt)
			{
				 //Update
				 db.EpassengerFacilityTt.Update(epassengerfacilitytt);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EpassengerFacilityTt epassengerfacilitytt)
			{
				 db.EpassengerFacilityTt.Remove(epassengerfacilitytt);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class EpassengerFacilitysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EpassengerFacility> lEpassengerFacilitys = await db.EpassengerFacility.GetAllCompanyEpassengerFacilitys(id);
				 //return JsonConvert.SerializeObject(lEpassengerFacilitys.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EpassengerFacility epassengerfacility)
			{
				 //Create
				 db.EpassengerFacility.Add(epassengerfacility);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(epassengerfacility);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EpassengerFacility epassengerfacility)
			{
				 //Update
				 db.EpassengerFacility.Update(epassengerfacility);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EpassengerFacility epassengerfacility)
			{
				 db.EpassengerFacility.Remove(epassengerfacility);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

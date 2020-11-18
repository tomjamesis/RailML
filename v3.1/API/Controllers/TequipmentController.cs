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
	public class TequipmentsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tequipment> lTequipments = await db.Tequipment.GetAllCompanyTequipments(id);
				 //return JsonConvert.SerializeObject(lTequipments.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tequipment tequipment)
			{
				 //Create
				 db.Tequipment.Add(tequipment);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tequipment);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tequipment tequipment)
			{
				 //Update
				 db.Tequipment.Update(tequipment);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tequipment tequipment)
			{
				 db.Tequipment.Remove(tequipment);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

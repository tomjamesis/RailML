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
	public class EequipmentsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Eequipment> lEequipments = await db.Eequipment.GetAllCompanyEequipments(id);
				 //return JsonConvert.SerializeObject(lEequipments.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Eequipment eequipment)
			{
				 //Create
				 db.Eequipment.Add(eequipment);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eequipment);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Eequipment eequipment)
			{
				 //Update
				 db.Eequipment.Update(eequipment);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Eequipment eequipment)
			{
				 db.Eequipment.Remove(eequipment);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

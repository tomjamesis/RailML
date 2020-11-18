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
	public class TotherEquipmentsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TotherEquipment> lTotherEquipments = await db.TotherEquipment.GetAllCompanyTotherEquipments(id);
				 //return JsonConvert.SerializeObject(lTotherEquipments.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TotherEquipment totherequipment)
			{
				 //Create
				 db.TotherEquipment.Add(totherequipment);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(totherequipment);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TotherEquipment totherequipment)
			{
				 //Update
				 db.TotherEquipment.Update(totherequipment);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TotherEquipment totherequipment)
			{
				 db.TotherEquipment.Remove(totherequipment);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

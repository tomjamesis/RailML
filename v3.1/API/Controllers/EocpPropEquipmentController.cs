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
	public class EocpPropEquipmentsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EocpPropEquipment> lEocpPropEquipments = await db.EocpPropEquipment.GetAllCompanyEocpPropEquipments(id);
				 //return JsonConvert.SerializeObject(lEocpPropEquipments.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EocpPropEquipment eocppropequipment)
			{
				 //Create
				 db.EocpPropEquipment.Add(eocppropequipment);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eocppropequipment);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EocpPropEquipment eocppropequipment)
			{
				 //Update
				 db.EocpPropEquipment.Update(eocppropequipment);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EocpPropEquipment eocppropequipment)
			{
				 db.EocpPropEquipment.Remove(eocppropequipment);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

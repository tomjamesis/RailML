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
	public class TpowerTransmissionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TpowerTransmission> lTpowerTransmissions = await db.TpowerTransmission.GetAllCompanyTpowerTransmissions(id);
				 //return JsonConvert.SerializeObject(lTpowerTransmissions.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TpowerTransmission tpowertransmission)
			{
				 //Create
				 db.TpowerTransmission.Add(tpowertransmission);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tpowertransmission);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TpowerTransmission tpowertransmission)
			{
				 //Update
				 db.TpowerTransmission.Update(tpowertransmission);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TpowerTransmission tpowertransmission)
			{
				 db.TpowerTransmission.Remove(tpowertransmission);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

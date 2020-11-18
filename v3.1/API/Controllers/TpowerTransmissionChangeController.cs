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
	public class TpowerTransmissionChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TpowerTransmissionChange> lTpowerTransmissionChanges = await db.TpowerTransmissionChange.GetAllCompanyTpowerTransmissionChanges(id);
				 //return JsonConvert.SerializeObject(lTpowerTransmissionChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TpowerTransmissionChange tpowertransmissionchange)
			{
				 //Create
				 db.TpowerTransmissionChange.Add(tpowertransmissionchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tpowertransmissionchange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TpowerTransmissionChange tpowertransmissionchange)
			{
				 //Update
				 db.TpowerTransmissionChange.Update(tpowertransmissionchange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TpowerTransmissionChange tpowertransmissionchange)
			{
				 db.TpowerTransmissionChange.Remove(tpowertransmissionchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

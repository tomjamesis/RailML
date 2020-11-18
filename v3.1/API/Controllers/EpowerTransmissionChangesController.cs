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
	public class EpowerTransmissionChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EpowerTransmissionChanges> lEpowerTransmissionChangess = await db.EpowerTransmissionChanges.GetAllCompanyEpowerTransmissionChangess(id);
				 //return JsonConvert.SerializeObject(lEpowerTransmissionChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EpowerTransmissionChanges epowertransmissionchanges)
			{
				 //Create
				 db.EpowerTransmissionChanges.Add(epowertransmissionchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(epowertransmissionchanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EpowerTransmissionChanges epowertransmissionchanges)
			{
				 //Update
				 db.EpowerTransmissionChanges.Update(epowertransmissionchanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EpowerTransmissionChanges epowertransmissionchanges)
			{
				 db.EpowerTransmissionChanges.Remove(epowertransmissionchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

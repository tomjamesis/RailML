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
	public class EtapTsiTransportOperationalIdentifiersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtapTsiTransportOperationalIdentifier> lEtapTsiTransportOperationalIdentifiers = await db.EtapTsiTransportOperationalIdentifier.GetAllCompanyEtapTsiTransportOperationalIdentifiers(id);
				 //return JsonConvert.SerializeObject(lEtapTsiTransportOperationalIdentifiers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtapTsiTransportOperationalIdentifier etaptsitransportoperationalidentifier)
			{
				 //Create
				 db.EtapTsiTransportOperationalIdentifier.Add(etaptsitransportoperationalidentifier);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etaptsitransportoperationalidentifier);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtapTsiTransportOperationalIdentifier etaptsitransportoperationalidentifier)
			{
				 //Update
				 db.EtapTsiTransportOperationalIdentifier.Update(etaptsitransportoperationalidentifier);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtapTsiTransportOperationalIdentifier etaptsitransportoperationalidentifier)
			{
				 db.EtapTsiTransportOperationalIdentifier.Remove(etaptsitransportoperationalidentifier);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

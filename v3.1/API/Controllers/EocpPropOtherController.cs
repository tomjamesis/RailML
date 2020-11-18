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
	public class EocpPropOthersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EocpPropOther> lEocpPropOthers = await db.EocpPropOther.GetAllCompanyEocpPropOthers(id);
				 //return JsonConvert.SerializeObject(lEocpPropOthers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EocpPropOther eocppropother)
			{
				 //Create
				 db.EocpPropOther.Add(eocppropother);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eocppropother);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EocpPropOther eocppropother)
			{
				 //Update
				 db.EocpPropOther.Update(eocppropother);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EocpPropOther eocppropother)
			{
				 db.EocpPropOther.Remove(eocppropother);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

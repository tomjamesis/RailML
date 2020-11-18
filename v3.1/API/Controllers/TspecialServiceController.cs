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
	public class TspecialServicesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TspecialService> lTspecialServices = await db.TspecialService.GetAllCompanyTspecialServices(id);
				 //return JsonConvert.SerializeObject(lTspecialServices.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TspecialService tspecialservice)
			{
				 //Create
				 db.TspecialService.Add(tspecialservice);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tspecialservice);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TspecialService tspecialservice)
			{
				 //Update
				 db.TspecialService.Update(tspecialservice);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TspecialService tspecialservice)
			{
				 db.TspecialService.Remove(tspecialservice);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

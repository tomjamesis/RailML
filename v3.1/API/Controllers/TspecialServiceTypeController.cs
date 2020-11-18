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
	public class TspecialServiceTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TspecialServiceType> lTspecialServiceTypes = await db.TspecialServiceType.GetAllCompanyTspecialServiceTypes(id);
				 //return JsonConvert.SerializeObject(lTspecialServiceTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TspecialServiceType tspecialservicetype)
			{
				 //Create
				 db.TspecialServiceType.Add(tspecialservicetype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tspecialservicetype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TspecialServiceType tspecialservicetype)
			{
				 //Update
				 db.TspecialServiceType.Update(tspecialservicetype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TspecialServiceType tspecialservicetype)
			{
				 db.TspecialServiceType.Remove(tspecialservicetype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

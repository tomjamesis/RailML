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
	public class EoperatorsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Eoperator> lEoperators = await db.Eoperator.GetAllCompanyEoperators(id);
				 //return JsonConvert.SerializeObject(lEoperators.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Eoperator eoperator)
			{
				 //Create
				 db.Eoperator.Add(eoperator);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eoperator);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Eoperator eoperator)
			{
				 //Update
				 db.Eoperator.Update(eoperator);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Eoperator eoperator)
			{
				 db.Eoperator.Remove(eoperator);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

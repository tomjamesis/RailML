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
	public class ToperatorsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Toperator> lToperators = await db.Toperator.GetAllCompanyToperators(id);
				 //return JsonConvert.SerializeObject(lToperators.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Toperator toperator)
			{
				 //Create
				 db.Toperator.Add(toperator);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(toperator);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Toperator toperator)
			{
				 //Update
				 db.Toperator.Update(toperator);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Toperator toperator)
			{
				 db.Toperator.Remove(toperator);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

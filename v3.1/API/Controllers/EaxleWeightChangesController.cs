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
	public class EaxleWeightChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EaxleWeightChanges> lEaxleWeightChangess = await db.EaxleWeightChanges.GetAllCompanyEaxleWeightChangess(id);
				 //return JsonConvert.SerializeObject(lEaxleWeightChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EaxleWeightChanges eaxleweightchanges)
			{
				 //Create
				 db.EaxleWeightChanges.Add(eaxleweightchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eaxleweightchanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EaxleWeightChanges eaxleweightchanges)
			{
				 //Update
				 db.EaxleWeightChanges.Update(eaxleweightchanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EaxleWeightChanges eaxleweightchanges)
			{
				 db.EaxleWeightChanges.Remove(eaxleweightchanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

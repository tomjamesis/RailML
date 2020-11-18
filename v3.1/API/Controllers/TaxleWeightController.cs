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
	public class TaxleWeightsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TaxleWeight> lTaxleWeights = await db.TaxleWeight.GetAllCompanyTaxleWeights(id);
				 //return JsonConvert.SerializeObject(lTaxleWeights.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TaxleWeight taxleweight)
			{
				 //Create
				 db.TaxleWeight.Add(taxleweight);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(taxleweight);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TaxleWeight taxleweight)
			{
				 //Update
				 db.TaxleWeight.Update(taxleweight);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TaxleWeight taxleweight)
			{
				 db.TaxleWeight.Remove(taxleweight);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

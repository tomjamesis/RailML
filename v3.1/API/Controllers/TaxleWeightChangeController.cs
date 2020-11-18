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
	public class TaxleWeightChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TaxleWeightChange> lTaxleWeightChanges = await db.TaxleWeightChange.GetAllCompanyTaxleWeightChanges(id);
				 //return JsonConvert.SerializeObject(lTaxleWeightChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TaxleWeightChange taxleweightchange)
			{
				 //Create
				 db.TaxleWeightChange.Add(taxleweightchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(taxleweightchange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TaxleWeightChange taxleweightchange)
			{
				 //Update
				 db.TaxleWeightChange.Update(taxleweightchange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TaxleWeightChange taxleweightchange)
			{
				 db.TaxleWeightChange.Remove(taxleweightchange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

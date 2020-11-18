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
	public class TlineClassificationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TlineClassification> lTlineClassifications = await db.TlineClassification.GetAllCompanyTlineClassifications(id);
				 //return JsonConvert.SerializeObject(lTlineClassifications.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TlineClassification tlineclassification)
			{
				 //Create
				 db.TlineClassification.Add(tlineclassification);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tlineclassification);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TlineClassification tlineclassification)
			{
				 //Update
				 db.TlineClassification.Update(tlineclassification);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TlineClassification tlineclassification)
			{
				 db.TlineClassification.Remove(tlineclassification);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

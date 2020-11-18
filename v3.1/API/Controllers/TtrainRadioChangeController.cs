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
	public class TtrainRadioChangesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainRadioChange> lTtrainRadioChanges = await db.TtrainRadioChange.GetAllCompanyTtrainRadioChanges(id);
				 //return JsonConvert.SerializeObject(lTtrainRadioChanges.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainRadioChange ttrainradiochange)
			{
				 //Create
				 db.TtrainRadioChange.Add(ttrainradiochange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttrainradiochange);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainRadioChange ttrainradiochange)
			{
				 //Update
				 db.TtrainRadioChange.Update(ttrainradiochange);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainRadioChange ttrainradiochange)
			{
				 db.TtrainRadioChange.Remove(ttrainradiochange);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class EtrainRadioChangessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrainRadioChanges> lEtrainRadioChangess = await db.EtrainRadioChanges.GetAllCompanyEtrainRadioChangess(id);
				 //return JsonConvert.SerializeObject(lEtrainRadioChangess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrainRadioChanges etrainradiochanges)
			{
				 //Create
				 db.EtrainRadioChanges.Add(etrainradiochanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrainradiochanges);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrainRadioChanges etrainradiochanges)
			{
				 //Update
				 db.EtrainRadioChanges.Update(etrainradiochanges);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrainRadioChanges etrainradiochanges)
			{
				 db.EtrainRadioChanges.Remove(etrainradiochanges);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

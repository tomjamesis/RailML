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
	public class TmaxTrainCurrentsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TmaxTrainCurrent> lTmaxTrainCurrents = await db.TmaxTrainCurrent.GetAllCompanyTmaxTrainCurrents(id);
				 //return JsonConvert.SerializeObject(lTmaxTrainCurrents.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TmaxTrainCurrent tmaxtraincurrent)
			{
				 //Create
				 db.TmaxTrainCurrent.Add(tmaxtraincurrent);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmaxtraincurrent);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TmaxTrainCurrent tmaxtraincurrent)
			{
				 //Update
				 db.TmaxTrainCurrent.Update(tmaxtraincurrent);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TmaxTrainCurrent tmaxtraincurrent)
			{
				 db.TmaxTrainCurrent.Remove(tmaxtraincurrent);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

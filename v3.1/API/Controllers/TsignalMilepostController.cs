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
	public class TsignalMilepostsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TsignalMilepost> lTsignalMileposts = await db.TsignalMilepost.GetAllCompanyTsignalMileposts(id);
				 //return JsonConvert.SerializeObject(lTsignalMileposts.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TsignalMilepost tsignalmilepost)
			{
				 //Create
				 db.TsignalMilepost.Add(tsignalmilepost);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tsignalmilepost);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TsignalMilepost tsignalmilepost)
			{
				 //Update
				 db.TsignalMilepost.Update(tsignalmilepost);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TsignalMilepost tsignalmilepost)
			{
				 db.TsignalMilepost.Remove(tsignalmilepost);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

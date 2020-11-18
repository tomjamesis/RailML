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
	public class TcommonSwitchAndCrossingDatasController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TcommonSwitchAndCrossingData> lTcommonSwitchAndCrossingDatas = await db.TcommonSwitchAndCrossingData.GetAllCompanyTcommonSwitchAndCrossingDatas(id);
				 //return JsonConvert.SerializeObject(lTcommonSwitchAndCrossingDatas.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TcommonSwitchAndCrossingData tcommonswitchandcrossingdata)
			{
				 //Create
				 db.TcommonSwitchAndCrossingData.Add(tcommonswitchandcrossingdata);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcommonswitchandcrossingdata);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TcommonSwitchAndCrossingData tcommonswitchandcrossingdata)
			{
				 //Update
				 db.TcommonSwitchAndCrossingData.Update(tcommonswitchandcrossingdata);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TcommonSwitchAndCrossingData tcommonswitchandcrossingdata)
			{
				 db.TcommonSwitchAndCrossingData.Remove(tcommonswitchandcrossingdata);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

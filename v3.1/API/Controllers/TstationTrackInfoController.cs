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
	public class TstationTrackInfosController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstationTrackInfo> lTstationTrackInfos = await db.TstationTrackInfo.GetAllCompanyTstationTrackInfos(id);
				 //return JsonConvert.SerializeObject(lTstationTrackInfos.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstationTrackInfo tstationtrackinfo)
			{
				 //Create
				 db.TstationTrackInfo.Add(tstationtrackinfo);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstationtrackinfo);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstationTrackInfo tstationtrackinfo)
			{
				 //Update
				 db.TstationTrackInfo.Update(tstationtrackinfo);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstationTrackInfo tstationtrackinfo)
			{
				 db.TstationTrackInfo.Remove(tstationtrackinfo);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

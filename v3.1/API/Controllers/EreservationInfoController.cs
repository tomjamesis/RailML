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
	public class EreservationInfosController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EreservationInfo> lEreservationInfos = await db.EreservationInfo.GetAllCompanyEreservationInfos(id);
				 //return JsonConvert.SerializeObject(lEreservationInfos.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EreservationInfo ereservationinfo)
			{
				 //Create
				 db.EreservationInfo.Add(ereservationinfo);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ereservationinfo);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EreservationInfo ereservationinfo)
			{
				 //Update
				 db.EreservationInfo.Update(ereservationinfo);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EreservationInfo ereservationinfo)
			{
				 db.EreservationInfo.Remove(ereservationinfo);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

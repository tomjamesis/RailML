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
	public class TdelimitedDirectionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TdelimitedDirection> lTdelimitedDirections = await db.TdelimitedDirection.GetAllCompanyTdelimitedDirections(id);
				 //return JsonConvert.SerializeObject(lTdelimitedDirections.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TdelimitedDirection tdelimiteddirection)
			{
				 //Create
				 db.TdelimitedDirection.Add(tdelimiteddirection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tdelimiteddirection);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TdelimitedDirection tdelimiteddirection)
			{
				 //Update
				 db.TdelimitedDirection.Update(tdelimiteddirection);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TdelimitedDirection tdelimiteddirection)
			{
				 db.TdelimitedDirection.Remove(tdelimiteddirection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

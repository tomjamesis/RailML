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
	public class TvehicleRefsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TvehicleRef> lTvehicleRefs = await db.TvehicleRef.GetAllCompanyTvehicleRefs(id);
				 //return JsonConvert.SerializeObject(lTvehicleRefs.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TvehicleRef tvehicleref)
			{
				 //Create
				 db.TvehicleRef.Add(tvehicleref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tvehicleref);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TvehicleRef tvehicleref)
			{
				 //Update
				 db.TvehicleRef.Update(tvehicleref);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TvehicleRef tvehicleref)
			{
				 db.TvehicleRef.Remove(tvehicleref);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

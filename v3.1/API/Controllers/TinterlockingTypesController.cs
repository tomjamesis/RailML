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
	public class TinterlockingTypessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TinterlockingTypes> lTinterlockingTypess = await db.TinterlockingTypes.GetAllCompanyTinterlockingTypess(id);
				 //return JsonConvert.SerializeObject(lTinterlockingTypess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TinterlockingTypes tinterlockingtypes)
			{
				 //Create
				 db.TinterlockingTypes.Add(tinterlockingtypes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tinterlockingtypes);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TinterlockingTypes tinterlockingtypes)
			{
				 //Update
				 db.TinterlockingTypes.Update(tinterlockingtypes);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TinterlockingTypes tinterlockingtypes)
			{
				 db.TinterlockingTypes.Remove(tinterlockingtypes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class ToperationModesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<ToperationMode> lToperationModes = await db.ToperationMode.GetAllCompanyToperationModes(id);
				 //return JsonConvert.SerializeObject(lToperationModes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]ToperationMode toperationmode)
			{
				 //Create
				 db.ToperationMode.Add(toperationmode);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(toperationmode);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]ToperationMode toperationmode)
			{
				 //Update
				 db.ToperationMode.Update(toperationmode);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]ToperationMode toperationmode)
			{
				 db.ToperationMode.Remove(toperationmode);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

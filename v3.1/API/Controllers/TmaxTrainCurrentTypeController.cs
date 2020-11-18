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
	public class TmaxTrainCurrentTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TmaxTrainCurrentType> lTmaxTrainCurrentTypes = await db.TmaxTrainCurrentType.GetAllCompanyTmaxTrainCurrentTypes(id);
				 //return JsonConvert.SerializeObject(lTmaxTrainCurrentTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TmaxTrainCurrentType tmaxtraincurrenttype)
			{
				 //Create
				 db.TmaxTrainCurrentType.Add(tmaxtraincurrenttype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmaxtraincurrenttype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TmaxTrainCurrentType tmaxtraincurrenttype)
			{
				 //Update
				 db.TmaxTrainCurrentType.Update(tmaxtraincurrenttype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TmaxTrainCurrentType tmaxtraincurrenttype)
			{
				 db.TmaxTrainCurrentType.Remove(tmaxtraincurrenttype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class TmechanicalWagonCouplerTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TmechanicalWagonCouplerType> lTmechanicalWagonCouplerTypes = await db.TmechanicalWagonCouplerType.GetAllCompanyTmechanicalWagonCouplerTypes(id);
				 //return JsonConvert.SerializeObject(lTmechanicalWagonCouplerTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TmechanicalWagonCouplerType tmechanicalwagoncouplertype)
			{
				 //Create
				 db.TmechanicalWagonCouplerType.Add(tmechanicalwagoncouplertype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tmechanicalwagoncouplertype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TmechanicalWagonCouplerType tmechanicalwagoncouplertype)
			{
				 //Update
				 db.TmechanicalWagonCouplerType.Update(tmechanicalwagoncouplertype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TmechanicalWagonCouplerType tmechanicalwagoncouplertype)
			{
				 db.TmechanicalWagonCouplerType.Remove(tmechanicalwagoncouplertype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

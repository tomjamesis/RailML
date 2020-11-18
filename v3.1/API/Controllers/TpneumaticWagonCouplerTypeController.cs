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
	public class TpneumaticWagonCouplerTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TpneumaticWagonCouplerType> lTpneumaticWagonCouplerTypes = await db.TpneumaticWagonCouplerType.GetAllCompanyTpneumaticWagonCouplerTypes(id);
				 //return JsonConvert.SerializeObject(lTpneumaticWagonCouplerTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TpneumaticWagonCouplerType tpneumaticwagoncouplertype)
			{
				 //Create
				 db.TpneumaticWagonCouplerType.Add(tpneumaticwagoncouplertype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tpneumaticwagoncouplertype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TpneumaticWagonCouplerType tpneumaticwagoncouplertype)
			{
				 //Update
				 db.TpneumaticWagonCouplerType.Update(tpneumaticwagoncouplertype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TpneumaticWagonCouplerType tpneumaticwagoncouplertype)
			{
				 db.TpneumaticWagonCouplerType.Remove(tpneumaticwagoncouplertype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

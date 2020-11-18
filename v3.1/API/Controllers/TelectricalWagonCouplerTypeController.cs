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
	public class TelectricalWagonCouplerTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TelectricalWagonCouplerType> lTelectricalWagonCouplerTypes = await db.TelectricalWagonCouplerType.GetAllCompanyTelectricalWagonCouplerTypes(id);
				 //return JsonConvert.SerializeObject(lTelectricalWagonCouplerTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TelectricalWagonCouplerType telectricalwagoncouplertype)
			{
				 //Create
				 db.TelectricalWagonCouplerType.Add(telectricalwagoncouplertype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(telectricalwagoncouplertype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TelectricalWagonCouplerType telectricalwagoncouplertype)
			{
				 //Update
				 db.TelectricalWagonCouplerType.Update(telectricalwagoncouplertype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TelectricalWagonCouplerType telectricalwagoncouplertype)
			{
				 db.TelectricalWagonCouplerType.Remove(telectricalwagoncouplertype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

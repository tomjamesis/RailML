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
	public class TcontrollerTechnologyTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TcontrollerTechnologyType> lTcontrollerTechnologyTypes = await db.TcontrollerTechnologyType.GetAllCompanyTcontrollerTechnologyTypes(id);
				 //return JsonConvert.SerializeObject(lTcontrollerTechnologyTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TcontrollerTechnologyType tcontrollertechnologytype)
			{
				 //Create
				 db.TcontrollerTechnologyType.Add(tcontrollertechnologytype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcontrollertechnologytype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TcontrollerTechnologyType tcontrollertechnologytype)
			{
				 //Update
				 db.TcontrollerTechnologyType.Update(tcontrollertechnologytype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TcontrollerTechnologyType tcontrollertechnologytype)
			{
				 db.TcontrollerTechnologyType.Remove(tcontrollertechnologytype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class TtrainTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TtrainType> lTtrainTypes = await db.TtrainType.GetAllCompanyTtrainTypes(id);
				 //return JsonConvert.SerializeObject(lTtrainTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TtrainType ttraintype)
			{
				 //Create
				 db.TtrainType.Add(ttraintype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(ttraintype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TtrainType ttraintype)
			{
				 //Update
				 db.TtrainType.Update(ttraintype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TtrainType ttraintype)
			{
				 db.TtrainType.Remove(ttraintype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

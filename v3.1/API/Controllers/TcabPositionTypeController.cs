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
	public class TcabPositionTypesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TcabPositionType> lTcabPositionTypes = await db.TcabPositionType.GetAllCompanyTcabPositionTypes(id);
				 //return JsonConvert.SerializeObject(lTcabPositionTypes.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TcabPositionType tcabpositiontype)
			{
				 //Create
				 db.TcabPositionType.Add(tcabpositiontype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcabpositiontype);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TcabPositionType tcabpositiontype)
			{
				 //Update
				 db.TcabPositionType.Update(tcabpositiontype);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TcabPositionType tcabpositiontype)
			{
				 db.TcabPositionType.Remove(tcabpositiontype);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

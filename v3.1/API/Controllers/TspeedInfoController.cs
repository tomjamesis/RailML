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
	public class TspeedInfosController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TspeedInfo> lTspeedInfos = await db.TspeedInfo.GetAllCompanyTspeedInfos(id);
				 //return JsonConvert.SerializeObject(lTspeedInfos.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TspeedInfo tspeedinfo)
			{
				 //Create
				 db.TspeedInfo.Add(tspeedinfo);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tspeedinfo);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TspeedInfo tspeedinfo)
			{
				 //Update
				 db.TspeedInfo.Update(tspeedinfo);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TspeedInfo tspeedinfo)
			{
				 db.TspeedInfo.Remove(tspeedinfo);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

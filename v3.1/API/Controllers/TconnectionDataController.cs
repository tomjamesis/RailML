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
	public class TconnectionDatasController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TconnectionData> lTconnectionDatas = await db.TconnectionData.GetAllCompanyTconnectionDatas(id);
				 //return JsonConvert.SerializeObject(lTconnectionDatas.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TconnectionData tconnectiondata)
			{
				 //Create
				 db.TconnectionData.Add(tconnectiondata);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tconnectiondata);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TconnectionData tconnectiondata)
			{
				 //Update
				 db.TconnectionData.Update(tconnectiondata);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TconnectionData tconnectiondata)
			{
				 db.TconnectionData.Remove(tconnectiondata);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

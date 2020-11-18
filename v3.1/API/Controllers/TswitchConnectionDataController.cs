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
	public class TswitchConnectionDatasController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TswitchConnectionData> lTswitchConnectionDatas = await db.TswitchConnectionData.GetAllCompanyTswitchConnectionDatas(id);
				 //return JsonConvert.SerializeObject(lTswitchConnectionDatas.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TswitchConnectionData tswitchconnectiondata)
			{
				 //Create
				 db.TswitchConnectionData.Add(tswitchconnectiondata);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tswitchconnectiondata);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TswitchConnectionData tswitchconnectiondata)
			{
				 //Update
				 db.TswitchConnectionData.Update(tswitchconnectiondata);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TswitchConnectionData tswitchconnectiondata)
			{
				 db.TswitchConnectionData.Remove(tswitchconnectiondata);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

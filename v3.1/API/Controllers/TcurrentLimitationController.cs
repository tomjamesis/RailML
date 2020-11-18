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
	public class TcurrentLimitationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TcurrentLimitation> lTcurrentLimitations = await db.TcurrentLimitation.GetAllCompanyTcurrentLimitations(id);
				 //return JsonConvert.SerializeObject(lTcurrentLimitations.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TcurrentLimitation tcurrentlimitation)
			{
				 //Create
				 db.TcurrentLimitation.Add(tcurrentlimitation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcurrentlimitation);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TcurrentLimitation tcurrentlimitation)
			{
				 //Update
				 db.TcurrentLimitation.Update(tcurrentlimitation);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TcurrentLimitation tcurrentlimitation)
			{
				 db.TcurrentLimitation.Remove(tcurrentlimitation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

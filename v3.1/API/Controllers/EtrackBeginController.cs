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
	public class EtrackBeginsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EtrackBegin> lEtrackBegins = await db.EtrackBegin.GetAllCompanyEtrackBegins(id);
				 //return JsonConvert.SerializeObject(lEtrackBegins.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EtrackBegin etrackbegin)
			{
				 //Create
				 db.EtrackBegin.Add(etrackbegin);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(etrackbegin);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EtrackBegin etrackbegin)
			{
				 //Update
				 db.EtrackBegin.Update(etrackbegin);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EtrackBegin etrackbegin)
			{
				 db.EtrackBegin.Remove(etrackbegin);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

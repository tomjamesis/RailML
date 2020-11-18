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
	public class TcrossingsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tcrossing> lTcrossings = await db.Tcrossing.GetAllCompanyTcrossings(id);
				 //return JsonConvert.SerializeObject(lTcrossings.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tcrossing tcrossing)
			{
				 //Create
				 db.Tcrossing.Add(tcrossing);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcrossing);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tcrossing tcrossing)
			{
				 //Update
				 db.Tcrossing.Update(tcrossing);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tcrossing tcrossing)
			{
				 db.Tcrossing.Remove(tcrossing);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

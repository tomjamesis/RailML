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
	public class TcustomersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tcustomer> lTcustomers = await db.Tcustomer.GetAllCompanyTcustomers(id);
				 //return JsonConvert.SerializeObject(lTcustomers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tcustomer tcustomer)
			{
				 //Create
				 db.Tcustomer.Add(tcustomer);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcustomer);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tcustomer tcustomer)
			{
				 //Update
				 db.Tcustomer.Update(tcustomer);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tcustomer tcustomer)
			{
				 db.Tcustomer.Remove(tcustomer);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

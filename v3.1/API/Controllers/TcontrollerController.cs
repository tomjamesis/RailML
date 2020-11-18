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
	public class TcontrollersController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tcontroller> lTcontrollers = await db.Tcontroller.GetAllCompanyTcontrollers(id);
				 //return JsonConvert.SerializeObject(lTcontrollers.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tcontroller tcontroller)
			{
				 //Create
				 db.Tcontroller.Add(tcontroller);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcontroller);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tcontroller tcontroller)
			{
				 //Update
				 db.Tcontroller.Update(tcontroller);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tcontroller tcontroller)
			{
				 db.Tcontroller.Remove(tcontroller);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

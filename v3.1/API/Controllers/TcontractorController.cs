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
	public class TcontractorsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tcontractor> lTcontractors = await db.Tcontractor.GetAllCompanyTcontractors(id);
				 //return JsonConvert.SerializeObject(lTcontractors.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tcontractor tcontractor)
			{
				 //Create
				 db.Tcontractor.Add(tcontractor);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcontractor);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tcontractor tcontractor)
			{
				 //Update
				 db.Tcontractor.Update(tcontractor);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tcontractor tcontractor)
			{
				 db.Tcontractor.Remove(tcontractor);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

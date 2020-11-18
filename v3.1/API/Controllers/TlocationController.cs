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
	public class TlocationsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Tlocation> lTlocations = await db.Tlocation.GetAllCompanyTlocations(id);
				 //return JsonConvert.SerializeObject(lTlocations.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Tlocation tlocation)
			{
				 //Create
				 db.Tlocation.Add(tlocation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tlocation);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Tlocation tlocation)
			{
				 //Update
				 db.Tlocation.Update(tlocation);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Tlocation tlocation)
			{
				 db.Tlocation.Remove(tlocation);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

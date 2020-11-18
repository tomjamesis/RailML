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
	public class SimpleLiteralsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<SimpleLiteral> lSimpleLiterals = await db.SimpleLiteral.GetAllCompanySimpleLiterals(id);
				 //return JsonConvert.SerializeObject(lSimpleLiterals.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]SimpleLiteral simpleliteral)
			{
				 //Create
				 db.SimpleLiteral.Add(simpleliteral);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(simpleliteral);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]SimpleLiteral simpleliteral)
			{
				 //Update
				 db.SimpleLiteral.Update(simpleliteral);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]SimpleLiteral simpleliteral)
			{
				 db.SimpleLiteral.Remove(simpleliteral);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

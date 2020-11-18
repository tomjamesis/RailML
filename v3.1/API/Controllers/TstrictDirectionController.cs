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
	public class TstrictDirectionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TstrictDirection> lTstrictDirections = await db.TstrictDirection.GetAllCompanyTstrictDirections(id);
				 //return JsonConvert.SerializeObject(lTstrictDirections.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TstrictDirection tstrictdirection)
			{
				 //Create
				 db.TstrictDirection.Add(tstrictdirection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tstrictdirection);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TstrictDirection tstrictdirection)
			{
				 //Update
				 db.TstrictDirection.Update(tstrictdirection);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TstrictDirection tstrictdirection)
			{
				 db.TstrictDirection.Remove(tstrictdirection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

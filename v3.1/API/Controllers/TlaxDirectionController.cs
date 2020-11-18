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
	public class TlaxDirectionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TlaxDirection> lTlaxDirections = await db.TlaxDirection.GetAllCompanyTlaxDirections(id);
				 //return JsonConvert.SerializeObject(lTlaxDirections.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TlaxDirection tlaxdirection)
			{
				 //Create
				 db.TlaxDirection.Add(tlaxdirection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tlaxdirection);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TlaxDirection tlaxdirection)
			{
				 //Update
				 db.TlaxDirection.Update(tlaxdirection);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TlaxDirection tlaxdirection)
			{
				 db.TlaxDirection.Remove(tlaxdirection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

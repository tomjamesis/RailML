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
	public class TdelimitedOrientedElementWithLengthsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TdelimitedOrientedElementWithLength> lTdelimitedOrientedElementWithLengths = await db.TdelimitedOrientedElementWithLength.GetAllCompanyTdelimitedOrientedElementWithLengths(id);
				 //return JsonConvert.SerializeObject(lTdelimitedOrientedElementWithLengths.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TdelimitedOrientedElementWithLength tdelimitedorientedelementwithlength)
			{
				 //Create
				 db.TdelimitedOrientedElementWithLength.Add(tdelimitedorientedelementwithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tdelimitedorientedelementwithlength);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TdelimitedOrientedElementWithLength tdelimitedorientedelementwithlength)
			{
				 //Update
				 db.TdelimitedOrientedElementWithLength.Update(tdelimitedorientedelementwithlength);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TdelimitedOrientedElementWithLength tdelimitedorientedelementwithlength)
			{
				 db.TdelimitedOrientedElementWithLength.Remove(tdelimitedorientedelementwithlength);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

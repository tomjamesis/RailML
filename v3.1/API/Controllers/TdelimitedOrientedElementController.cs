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
	public class TdelimitedOrientedElementsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TdelimitedOrientedElement> lTdelimitedOrientedElements = await db.TdelimitedOrientedElement.GetAllCompanyTdelimitedOrientedElements(id);
				 //return JsonConvert.SerializeObject(lTdelimitedOrientedElements.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TdelimitedOrientedElement tdelimitedorientedelement)
			{
				 //Create
				 db.TdelimitedOrientedElement.Add(tdelimitedorientedelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tdelimitedorientedelement);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TdelimitedOrientedElement tdelimitedorientedelement)
			{
				 //Update
				 db.TdelimitedOrientedElement.Update(tdelimitedorientedelement);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TdelimitedOrientedElement tdelimitedorientedelement)
			{
				 db.TdelimitedOrientedElement.Remove(tdelimitedorientedelement);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

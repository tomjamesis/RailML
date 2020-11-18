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
	public class TcrossSectionsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TcrossSection> lTcrossSections = await db.TcrossSection.GetAllCompanyTcrossSections(id);
				 //return JsonConvert.SerializeObject(lTcrossSections.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TcrossSection tcrosssection)
			{
				 //Create
				 db.TcrossSection.Add(tcrosssection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tcrosssection);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TcrossSection tcrosssection)
			{
				 //Update
				 db.TcrossSection.Update(tcrosssection);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TcrossSection tcrosssection)
			{
				 db.TcrossSection.Remove(tcrosssection);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class TbasicBrakeTypeAuxiliaryBrakessController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TbasicBrakeTypeAuxiliaryBrakes> lTbasicBrakeTypeAuxiliaryBrakess = await db.TbasicBrakeTypeAuxiliaryBrakes.GetAllCompanyTbasicBrakeTypeAuxiliaryBrakess(id);
				 //return JsonConvert.SerializeObject(lTbasicBrakeTypeAuxiliaryBrakess.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TbasicBrakeTypeAuxiliaryBrakes tbasicbraketypeauxiliarybrakes)
			{
				 //Create
				 db.TbasicBrakeTypeAuxiliaryBrakes.Add(tbasicbraketypeauxiliarybrakes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tbasicbraketypeauxiliarybrakes);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TbasicBrakeTypeAuxiliaryBrakes tbasicbraketypeauxiliarybrakes)
			{
				 //Update
				 db.TbasicBrakeTypeAuxiliaryBrakes.Update(tbasicbraketypeauxiliarybrakes);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TbasicBrakeTypeAuxiliaryBrakes tbasicbraketypeauxiliarybrakes)
			{
				 db.TbasicBrakeTypeAuxiliaryBrakes.Remove(tbasicbraketypeauxiliarybrakes);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

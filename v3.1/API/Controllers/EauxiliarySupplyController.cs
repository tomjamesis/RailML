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
	public class EauxiliarySupplysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<EauxiliarySupply> lEauxiliarySupplys = await db.EauxiliarySupply.GetAllCompanyEauxiliarySupplys(id);
				 //return JsonConvert.SerializeObject(lEauxiliarySupplys.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]EauxiliarySupply eauxiliarysupply)
			{
				 //Create
				 db.EauxiliarySupply.Add(eauxiliarysupply);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(eauxiliarysupply);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]EauxiliarySupply eauxiliarysupply)
			{
				 //Update
				 db.EauxiliarySupply.Update(eauxiliarysupply);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]EauxiliarySupply eauxiliarysupply)
			{
				 db.EauxiliarySupply.Remove(eauxiliarysupply);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

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
	public class TauxiliarySupplySystemsController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TauxiliarySupplySystem> lTauxiliarySupplySystems = await db.TauxiliarySupplySystem.GetAllCompanyTauxiliarySupplySystems(id);
				 //return JsonConvert.SerializeObject(lTauxiliarySupplySystems.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TauxiliarySupplySystem tauxiliarysupplysystem)
			{
				 //Create
				 db.TauxiliarySupplySystem.Add(tauxiliarysupplysystem);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tauxiliarysupplysystem);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TauxiliarySupplySystem tauxiliarysupplysystem)
			{
				 //Update
				 db.TauxiliarySupplySystem.Update(tauxiliarysupplysystem);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TauxiliarySupplySystem tauxiliarysupplysystem)
			{
				 db.TauxiliarySupplySystem.Remove(tauxiliarysupplysystem);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

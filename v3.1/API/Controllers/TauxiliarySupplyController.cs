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
	public class TauxiliarySupplysController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<TauxiliarySupply> lTauxiliarySupplys = await db.TauxiliarySupply.GetAllCompanyTauxiliarySupplys(id);
				 //return JsonConvert.SerializeObject(lTauxiliarySupplys.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]TauxiliarySupply tauxiliarysupply)
			{
				 //Create
				 db.TauxiliarySupply.Add(tauxiliarysupply);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(tauxiliarysupply);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]TauxiliarySupply tauxiliarysupply)
			{
				 //Update
				 db.TauxiliarySupply.Update(tauxiliarysupply);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]TauxiliarySupply tauxiliarysupply)
			{
				 db.TauxiliarySupply.Remove(tauxiliarysupply);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}

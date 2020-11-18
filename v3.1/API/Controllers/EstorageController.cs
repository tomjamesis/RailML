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
	public class EstoragesController : Controller
	{
			private RailML_3_1Context db = new RailML_3_1Context();
			// GET api/values/5
			[HttpGet("{id}")]
			public async Task<string> Get(int id)
			{
				 //IList<Estorage> lEstorages = await db.Estorage.GetAllCompanyEstorages(id);
				 //return JsonConvert.SerializeObject(lEstorages.ToArray());
				 return "";
			}

			// POST api/values
			[HttpPost]
			public async Task<string> Post([FromBody]Estorage estorage)
			{
				 //Create
				 db.Estorage.Add(estorage);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject(estorage);
			}

			// PUT api/values/5
			[HttpPut("{id}")]
			public async Task Put(int id, [FromBody]Estorage estorage)
			{
				 //Update
				 db.Estorage.Update(estorage);
				 await db.SaveChangesAsync();
			}

			// DELETE api/values/5
			[HttpDelete("{id}")]
			public async Task<string> DeleteAsync([FromBody]Estorage estorage)
			{
				 db.Estorage.Remove(estorage);
				 await db.SaveChangesAsync();
				 return JsonConvert.SerializeObject("Ok");
			}
	}
}
